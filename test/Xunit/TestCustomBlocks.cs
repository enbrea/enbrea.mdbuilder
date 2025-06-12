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

using Xunit;

namespace Enbrea.MdBuilder.Tests
{
    /// <summary>
    /// Unit tests for custom example <see cref="MyCollapsedSection"/>.
    /// </summary>
    public class TestCustomBlocks
    {
        [Fact]
        public void SupportSimpleCollapsedSection()
        {
            var markkDownText =
                """
                <details>
                <summary>A summary</summary>
                
                Some text\.

                </details>
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendCollapsedSection("A summary", x => x.AppendParagraph("Some text."));

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportComplexCollapsedSection()
        {
            var markkDownText =
                """
                <details>
                <summary>A summary</summary>
                
                ## Heading
                
                A list:
                
                + List item 1
                
                + List item 2

                </details>
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendCollapsedSection("A summary", x =>
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


    }
}
