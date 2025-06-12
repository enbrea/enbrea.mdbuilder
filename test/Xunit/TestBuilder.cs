#region ENBREA.MdBuilder - Copyright (C) STÜBER SYSTEMS GmbH
/*    
 *    ENBREA.MDBUILDER
 *    
 *    Copyright (C) STÜBER SYSTEMS GmbH
 *
 *    Licensed under the MIT License, Version 2.0. 
 * 
 */
#endregion

using System.Text.RegularExpressions;
using Xunit;

namespace Enbrea.MdBuilder.Tests
{
    /// <summary>
    /// Unit tests for <see cref="MarkdownBuilder"/>.
    /// </summary>
    public class TestBuilder
    {
        [Fact]
        public void SmokeTest()
        {
            var markkDownText =
                """
                # Top header
                
                Some text
                
                ## First sub header

                > A list:
                > 
                > 1. List item 1
                > 
                >    An additional paragraph
                > 
                > 2. List item 2

                key 1

                :   value 1

                key 2
                
                :   value 2
                
                A list:
                
                1. List item 1

                   An additional paragraph
                
                2. List item 2
                
                3. List item 3 with some `Code`

                ## Second sub header

                A code block:

                ```
                <xml>
                  node
                </xml>
                ```

                    <xml>
                      node
                    </xml>
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder
                .AppendHeading(1, "Top header")

                .AppendParagraph("Some text")

                .AppendHeading(2, "First sub header")

                .AppendBlockQuote(x =>
                {
                    x.AppendParagraph("A list:");
                    x.AppendOrderedList(x =>
                    {
                        x.Append(x =>
                        {
                            x.AppendParagraph("List item 1");
                            x.AppendParagraph("An additional paragraph");
                        });
                        x.Append(x =>
                        {
                            x.AppendParagraph("List item 2");
                        });
                    });
                })

                .AppendDefinitionList(x =>
                {
                    x.Append("key 1", x => x.AppendParagraph("value 1"));
                    x.Append("key 2", x => x.AppendParagraph("value 2"));
                })

                .AppendParagraph("A list:")

                .AppendOrderedList(x =>
                {
                    x.Append(x =>
                    {
                        x.AppendParagraph("List item 1");
                        x.AppendParagraph("An additional paragraph");
                    });
                    x.Append(x =>
                    {
                        x.AppendParagraph("List item 2");
                    });
                    x.Append(x =>
                    {
                        x.AppendParagraph(x =>
                        {
                            x.AppendText("List item 3 with some ").AppendCodeSpan("Code");
                        });
                    });
                })

                .AppendHeading(2, "Second sub header")

                .AppendParagraph("A code block:")

                .AppendFencedCode(
                    """
                    <xml>
                      node
                    </xml>
                    """)

                .AppendIntendedCode(
                    """
                    <xml>
                      node
                    </xml>
                    """);

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SpecialTest()
        {
            var inputText =
                """
                This is a text with 2 variables: @ns.var1 and @ns.var2
                """;

            var markkDownText =
                """
                This is a text with 2 variables: `NS.VAR1` and `NS.VAR2`
                """;

            var mdBuilder = new MarkdownBuilder();

            var regex = new Regex(@"@(?<ns>\w+)\.(?<var>\w+)", RegexOptions.IgnoreCase);

            var matches = regex.Matches(inputText);

            mdBuilder.AppendParagraph(x =>
            {
                var currentIndex = 0;
                
                for (int i = 0; i < matches.Count; i++)
                {
                    var match = matches[i];

                    var textBeforeMatch = inputText[currentIndex..match.Index];

                    x.AppendText(textBeforeMatch);
                    x.AppendCodeSpan($"{match.Groups["ns"].Value.ToUpperInvariant()}.{match.Groups["var"].Value.ToUpperInvariant()}");

                    currentIndex = match.Index + match.Length;
                }

                var remainingText = inputText[currentIndex..inputText.Length];

                x.AppendText(remainingText);
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }
    }
}
