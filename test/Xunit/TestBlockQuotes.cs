#region ENBREA.MdBuilder - Copyright (C) 2023 STÜBER SYSTEMS GmbH
/*    
 *    ENBREA.MDBUILDER
 *    
 *    Copyright (C) 2023 STÜBER SYSTEMS GmbH
 *
 *    Licensed under the MIT License, Version 2.0. 
 * 
 */
#endregion

using Xunit;

namespace Enbrea.MdBuilder.Tests
{
    /// <summary>
    /// Unit tests for <see cref="MarkdownBlockQuote"/>.
    /// </summary>
    public class TestBlockQuotes
    {
        [Fact]
        public void SupportSimpleBlockQuote()
        {
            var markkDownText =
                """
                > Some text
                > 
                > Some more text  
                > \.\.\.and more
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendBlockQuote(x =>
            {
                x.AppendParagraph("Some text");
                x.AppendParagraph(x =>
                {
                    x.AppendText("Some more text").AppendHardLineBreak().AppendText("...and more");
                });
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportComplexBlockQuote()
        {
            var markkDownText =
                """
                > ## Heading
                > 
                > A list:
                > 
                > + List item 1
                > 
                > + List item 2
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendBlockQuote(x =>
            {
                x.AppendHeading(2, "Heading");
                x.AppendParagraph("A list:");
                x.AppendUnorderedList(x =>
                {
                    x.Append("List item 1");
                    x.Append("List item 2");
                });
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportRecursiveBlockQuotes()
        {
            var markkDownText =
                """
                > Paragraph 1
                > 
                > > Line 1\.1
                > > 
                > > Line 1\.2
                > 
                > Paragraph 2
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendBlockQuote(x =>
            {
                x.AppendParagraph("Paragraph 1");
                x.AppendBlockQuote(x =>
                {
                    x.AppendParagraph(x =>
                    {
                        x.AppendText("Line 1.1");
                    });
                    x.AppendParagraph(x =>
                    {
                        x.AppendText("Line 1.2");
                    });
                });
                x.AppendParagraph("Paragraph 2");
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }
    }
}
