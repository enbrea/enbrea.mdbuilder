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

using System;
using Xunit;

namespace Enbrea.MdBuilder.Tests
{
    /// <summary>
    /// Unit tests for <see cref="MarkdownInline"/>.
    /// </summary>
    public class TestInlineElements
    {
        [Fact]
        public void SupportCodeSpans()
        {
            var markkDownText =
                """
                This is a `code span with strange characters: _?!\*`\.
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendParagraph(x => x.AppendText("This is a ").AppendCodeSpan("code span with strange characters: _?!\\*").AppendText("."));

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportEmphasis()
        {
            var markkDownText =
                """
                This is a *emphasised* argument\.

                This is a *emphasised <https://example.com/>*\.
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendParagraph(x => x.AppendText("This is a ").AppendEmphasis("emphasised").AppendText(" argument."));
            mdBuilder.AppendParagraph(x =>
            {
                x.AppendText("This is a ");
                x.AppendEmphasis(x =>
                {
                    x.AppendText("emphasised ").AppendAutoLink(new Uri("https://example.com"));
                });
                x.AppendText(".");
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportImages()
        {
            var markkDownText =
                """
                This is an ![image](https://example.com/img.jpeg)\.

                This is an ![image](https://example.com/img.jpeg "title") with title\.
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendParagraph(x =>
            {
                x.AppendText("This is an ").AppendImage("image", new Uri("https://example.com/img.jpeg")).AppendText(".");
            });
            mdBuilder.AppendParagraph(x =>
            {
                x.AppendText("This is an ").AppendImage("image", new Uri("https://example.com/img.jpeg"), "title").AppendText(" with title.");
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportLinks()
        {
            var markkDownText =
                """
                This is a [link](https://example.com/ "a title")\.

                This is a [**strong link**](https://example.com/)\.
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendParagraph(x =>
            {
                x.AppendText("This is a ").AppendLink("link", new Uri("https://example.com"), "a title").AppendText(".");
            });
            mdBuilder.AppendParagraph(x => 
            { 
                x.AppendText("This is a ").AppendLink(x => x.AppendStrong("strong link"), new Uri("https://example.com")).AppendText("."); 
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportStrikethrough()
        {
            var markkDownText =
                """
                This is a ~~strikethrough~~ argument\.

                This is a ~~strikethrough [link](https://example.com/)~~\.
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendParagraph(x => x.AppendText("This is a ").AppendStrikethrough("strikethrough").AppendText(" argument."));
            mdBuilder.AppendParagraph(x =>
            {
                x.AppendText("This is a ");
                x.AppendStrikethrough(x =>
                {
                    x.AppendText("strikethrough ").AppendLink("link", new Uri("https://example.com"));
                });
                x.AppendText(".");
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportStrong()
        {
            var markkDownText =
                """
                This is a **strong** argument\.

                This is a **strong [link](https://example.com/)**\.
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendParagraph(x => x.AppendText("This is a ").AppendStrong("strong").AppendText(" argument."));
            mdBuilder.AppendParagraph(x =>
            {
                x.AppendText("This is a ");
                x.AppendStrong(x =>
                {
                    x.AppendText("strong ").AppendLink("link", new Uri("https://example.com"));
                });
                x.AppendText(".");
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }

        [Fact]
        public void SupportStrongEmphasis()
        {
            var markkDownText =
                """
                This is a ***very strong*** argument\.

                This is a ***very strong [link](https://example.com/)***\.
                """;

            var mdBuilder = new MarkdownBuilder();

            mdBuilder.AppendParagraph(x => x.AppendText("This is a ").AppendStrongEmphasis("very strong").AppendText(" argument."));
            mdBuilder.AppendParagraph(x =>
            {
                x.AppendText("This is a ");
                x.AppendStrongEmphasis(x =>
                {
                    x.AppendText("very strong ").AppendLink("link", new Uri("https://example.com"));
                });
                x.AppendText(".");
            });

            Assert.Equal(markkDownText, mdBuilder.ToString());
        }
    }
}
