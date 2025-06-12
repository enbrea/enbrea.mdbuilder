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
    /// Unit tests for <see cref="MarkdownTable"/>.
    /// </summary>
    public class TestTables
    {
        [Fact]
        public void SupportSimpleTables()
        {
            var markkDownText =
                """
                A | B | C
                - | - | -
                A1 | B1 | C1
                A2 | B2 | C2
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendTable(x =>
            {
                x.AssignHeader(x =>
                {
                    x.AppendColumn("A");
                    x.AppendColumn("B");
                    x.AppendColumn("C");
                });
                x.AppendRow(x =>
                {
                    x.Append("A1");
                    x.Append("B1");
                    x.Append("C1");
                });
                x.AppendRow(x =>
                {
                    x.Append("A2");
                    x.Append("B2");
                    x.Append("C2");
                });
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportComplexTables()
        {
            var markkDownText =
                """
                A | B | C
                :-- | :-: | --:
                **A1** | B1 | see `C1`
                **A2** | B2 | see `C2`
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendTable(x =>
            {
                x.AssignHeader(x =>
                {
                    x.AppendColumn(x =>
                    {
                        x.Assign("A", MarkdownTableColumnAlignment.Left);
                    });
                    x.AppendColumn(x =>
                    {
                        x.Assign("B", MarkdownTableColumnAlignment.Center);
                    });
                    x.AppendColumn(x =>
                    {
                        x.Assign("C", MarkdownTableColumnAlignment.Right);
                    });
                });
                x.AppendRow(x =>
                {
                    x.Append(x =>
                    {
                        x.AppendStrong("A1");
                    });
                    x.Append(x =>
                    {
                        x.AppendText("B1");
                    });
                    x.Append(x =>
                    {
                        x.AppendText("see ").AppendCodeSpan("C1");
                    });
                });
                x.AppendRow(x =>
                {
                    x.Append(x =>
                    {
                        x.AppendStrong("A2");
                    });
                    x.Append(x =>
                    {
                        x.AppendText("B2");
                    });
                    x.Append(x =>
                    {
                        x.AppendText("see ").AppendCodeSpan("C2");
                    });
                });
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }
    }
}
