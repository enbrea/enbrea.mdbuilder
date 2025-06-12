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
    /// Unit tests for <see cref="MarkdownHeading"/>.
    /// </summary>
    public class TestHeadings
    {
        [Fact]
        public void SupportH1toH6()
        {
            var markkDownText =
                """
                # Heading 1

                Paragraph 1

                ## Heading 2

                Paragraph 2
                
                ### Heading 3

                #### Heading 4

                ##### **Heading 5**

                Paragraph 3
                
                ###### Heading 6
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendHeading(1, "Heading 1");
            mdBuilder.AppendParagraph("Paragraph 1");
            mdBuilder.AppendHeading(2, "Heading 2");
            mdBuilder.AppendParagraph("Paragraph 2");
            mdBuilder.AppendHeading(3, "Heading 3");
            mdBuilder.AppendHeading(4, "Heading 4");
            mdBuilder.AppendHeading(5, x => x.AppendStrong("Heading 5"));
            mdBuilder.AppendParagraph("Paragraph 3");
            mdBuilder.AppendHeading(6, "Heading 6");

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }
    }
}
