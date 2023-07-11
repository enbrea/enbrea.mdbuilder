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
    /// Unit tests for <see cref="MarkdownList"/>.
    /// </summary>
    public class TestLists
    {
        [Fact]
        public void SupportDefinitionLists()
        {
            var markkDownText =
                """
                Definition 1
                
                :   Description line 1
                
                    Description line 2
                
                    Description line 3
                
                Definition 2

                :   Description line 1

                    ```
                    <xml>
                      node
                    </xml>
                    ```
                
                    Description line 2
                
                Definition 3
                
                :   Description line 1
                
                    + Item 1

                    + Item 2

                    + Item 3
                
                    Description line 2

                Definition 4
                
                :   Description line 1
                
                    Description line 2
                
                    Value | Description
                    - | -
                    Value 1 | Description 1
                    Value 2 | Description 2
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendDefinitionList(x =>
            {
                x.Append("Definition 1", x =>
                {
                    x.AppendParagraph("Description line 1");
                    x.AppendParagraph("Description line 2");
                    x.AppendParagraph("Description line 3");
                });
                x.Append("Definition 2", x =>
                {
                    x.AppendParagraph("Description line 1");
                    x.AppendFencedCode(
                        """
                        <xml>
                          node
                        </xml>
                        """
                    );
                    x.AppendParagraph("Description line 2");
                });
                x.Append("Definition 3", x =>
                {
                    x.AppendParagraph("Description line 1");
                    x.AppendUnorderedList(x =>
                    {
                        x.Append("Item 1");
                        x.Append("Item 2");
                        x.Append("Item 3");
                    });
                    x.AppendParagraph("Description line 2");
                });
                x.Append("Definition 4", x =>
                {
                    x.AppendParagraph("Description line 1");
                    x.AppendParagraph("Description line 2");
                    x.AppendTable(x =>
                    {
                        x.AssignHeader(x =>
                        {
                            x.AppendColumn("Value");
                            x.AppendColumn("Description");
                        });
                        x.AppendRow(x =>
                        {
                            x.Append("Value 1");
                            x.Append("Description 1");
                        });
                        x.AppendRow(x =>
                        {
                            x.Append("Value 2");
                            x.Append("Description 2");
                        });
                    });
                });
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportHierarchicalLists()
        {
            var markkDownText =
                """
                1. First line
                
                2. Second line

                   + Sub item 1
                
                   + Sub item 2
                
                   + Sub item 3

                3. Third line
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendOrderedList(1, x =>
            {
                x.Append(x => x.AppendParagraph("First line"));
                x.Append(x => x.AppendParagraph("Second line"));
                x.AppendUnorderedList(x =>
                {
                    x.Append(x => x.AppendParagraph("Sub item 1"));
                    x.Append(x => x.AppendParagraph("Sub item 2"));
                    x.Append(x => x.AppendParagraph("Sub item 3"));
                });
                x.Append(x => x.AppendParagraph("Third line"));
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportOrderedLists()
        {
            var markkDownText =
                """
                8. First line
                
                9. Second line

                   with one more paragraph

                10. Third line with some code

                    ```
                    <xml>
                      node
                    </xml>
                    ```

                11. Fourth line
                
                    with two more
                
                    paragraphs
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendOrderedList(8, x =>
            {
                x.Append(x =>
                {
                    x.AppendParagraph("First line");
                });
                x.Append(x =>
                {
                    x.AppendParagraph("Second line");
                    x.AppendParagraph("with one more paragraph");
                });
                x.Append(x =>
                {
                    x.AppendParagraph("Third line with some code");
                    x.AppendFencedCode(
                        """
                        <xml>
                          node
                        </xml>
                        """
                    );
                });
                x.Append(x =>
                {
                    x.AppendParagraph("Fourth line");
                    x.AppendParagraph("with two more");
                    x.AppendParagraph("paragraphs");
                });
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportTaskLists()
        {
            var markkDownText =
                """
                - [ ] First task
                
                - [x] Second task

                  with one more paragraph

                - [ ] Third task with some code

                  ```
                  <xml>
                    node
                  </xml>
                  ```

                - [x] Fourth task
                
                  with two more
                
                  paragraphs
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendTaskList(x =>
            {
                x.Append(false, x =>
                {
                    x.AppendParagraph("First task");
                });
                x.Append(true, x =>
                {
                    x.AppendParagraph("Second task");
                    x.AppendParagraph("with one more paragraph");
                });
                x.Append(false, x =>
                {
                    x.AppendParagraph("Third task with some code");
                    x.AppendFencedCode(
                        """
                        <xml>
                          node
                        </xml>
                        """
                    );
                });
                x.Append(true, x =>
                {
                    x.AppendParagraph("Fourth task");
                    x.AppendParagraph("with two more");
                    x.AppendParagraph("paragraphs");
                });
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportUnorderedLists()
        {
            var markkDownText =
                """
                + First line
                
                + Second line

                  with one more paragraph

                + Third line with some code

                  ```
                  <xml>
                    node
                  </xml>
                  ```

                + Fourth line
                
                  with two more
                
                  paragraphs
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendUnorderedList(x =>
            {
                x.Append(x =>
                {
                    x.AppendParagraph("First line");
                });
                x.Append(x =>
                {
                    x.AppendParagraph("Second line");
                    x.AppendParagraph("with one more paragraph");
                });
                x.Append(x =>
                {
                    x.AppendParagraph("Third line with some code");
                    x.AppendFencedCode(
                        """
                        <xml>
                          node
                        </xml>
                        """
                    );
                });
                x.Append(x =>
                {
                    x.AppendParagraph("Fourth line");
                    x.AppendParagraph("with two more");
                    x.AppendParagraph("paragraphs");
                });
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }
    }
}
