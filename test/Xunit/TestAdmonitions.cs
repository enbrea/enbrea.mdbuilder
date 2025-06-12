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
    /// Unit tests for <see cref="MarkdownAdmonition"/>.
    /// </summary>
    public class TestAdmonitions
    {
        [Fact]
        public void SupportSimpleAdmonition()
        {
            var markkDownText =
                """
                !!! info "title"
                
                    A text description\.
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendAdmonition(MarkdownAdmonitionType.Standard, "info", "title", x => x.AppendParagraph("A text description."));

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportSimpleAdmonitionWithoutTitle()
        {
            var markkDownText =
                """
                !!! warning
                
                    A text description\.
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendAdmonition(MarkdownAdmonitionType.Standard, "warning", null, x => x.AppendParagraph("A text description."));

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportComplexAdmonition()
        {
            var markkDownText =
                """
                ??? info "A title string"
                
                    A text description with embedded code:

                    ``` sql
                    select *
                    from table
                    ```

                    Nice\!
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendAdmonition(MarkdownAdmonitionType.Collapsed, "info", "A title string", x =>
            {
                x.AppendParagraph("A text description with embedded code:");
                x.AppendFencedCode("sql",
                     """
                     select *
                     from table
                     """);

                x.AppendParagraph("Nice!");
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }
    }
}
