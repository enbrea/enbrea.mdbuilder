#region ENBREA.MdBuilder - Copyright (C) 2023 STÜBER SYSTEMS GmbH
/*    
 *    ENBREA.MdBuilder
 *    
 *    Copyright (C) 2023 STÜBER SYSTEMS GmbH
 *
 *    Licensed under the MIT License, Version 2.0. 
 * 
 */
#endregion

using System;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Extensions for <see cref="MarkdownParagraphExtensions"/>
    /// </summary>
    public static class MarkdownParagraphExtensions
    {
        public static MarkdownParagraph AppendAutoLink(this MarkdownParagraph paragraph, string destination)
        {
            if (!string.IsNullOrEmpty(destination))
            {
                var inlineElement = new MarkdownAutoLink(destination);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendCodeSpan(this MarkdownParagraph paragraph, string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var inlineElement = new MarkdownCodeSpan(code);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendEmoji(this MarkdownParagraph paragraph, string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var inlineElement = new MarkdownEmoji(code);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendEmphasis(this MarkdownParagraph paragraph, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var inlineElement = new MarkdownEmphasis(text);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendEmphasis(this MarkdownParagraph paragraph, Action<MarkdownEmphasis> action)
        {
            var inlineElement = new MarkdownEmphasis();
            action(inlineElement);
            paragraph.Append(inlineElement);
            return paragraph;
        }

        public static MarkdownParagraph AppendHardLineBreak(this MarkdownParagraph paragraph)
        {
            var inlineElement = new MarkdownHardLineBreak();
            paragraph.Append(inlineElement);
            return paragraph;
        }

        public static MarkdownParagraph AppendImage(this MarkdownParagraph paragraph, string text, string destination)
        {
            if (!string.IsNullOrEmpty(destination))
            {
                var inlineElement = new MarkdownImage(text, destination);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendImage(this MarkdownParagraph paragraph, string text, string destination, string title)
        {
            if (!string.IsNullOrEmpty(destination))
            {
                var inlineElement = new MarkdownImage(text, destination, title);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendImage(this MarkdownParagraph paragraph, string text, Uri destination)
        {
            var inlineElement = new MarkdownImage(text, destination);
            paragraph.Append(inlineElement);
            return paragraph;
        }

        public static MarkdownParagraph AppendImage(this MarkdownParagraph paragraph, string text, Uri destination, string title)
        {
            var inlineElement = new MarkdownImage(text, destination, title);
            paragraph.Append(inlineElement);
            return paragraph;
        }

        public static MarkdownParagraph AppendInsert(this MarkdownParagraph paragraph, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var inlineElement = new MarkdownInsert(text);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendLink(this MarkdownParagraph paragraph, string text, string destination, string title = null)
        {
            if (!string.IsNullOrEmpty(destination))
            {
                var inlineElement = new MarkdownLink(text, destination, title);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendLink(this MarkdownParagraph paragraph, string text, Uri destination, string title = null)
        {
            var inlineElement = new MarkdownLink(text, destination, title);
            paragraph.Append(inlineElement);
            return paragraph;
        }

        public static MarkdownParagraph AppendLink(this MarkdownParagraph paragraph, Action<MarkdownLink> action, string destination, string title = null)
        {
            if (!string.IsNullOrEmpty(destination))
            {
                var inlineElement = new MarkdownLink(null, destination, title);
                action(inlineElement);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendLink(this MarkdownParagraph paragraph, Action<MarkdownLink> action, Uri destination, string title = null)
        {
            var inlineElement = new MarkdownLink(null, destination, title);
            action(inlineElement);
            paragraph.Append(inlineElement);
            return paragraph;
        }

        public static MarkdownParagraph AppendRawText(this MarkdownParagraph paragraph, string rawText)
        {
            if (!string.IsNullOrEmpty(rawText))
            {
                var inlineElement = new MarkdownRawText(rawText);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendSoftLineBreak(this MarkdownParagraph paragraph)
        {
            var inlineElement = new MarkdownSoftLineBreak();
            paragraph.Append(inlineElement);
            return paragraph;
        }

        public static MarkdownParagraph AppendStrikethrough(this MarkdownParagraph paragraph, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var inlineElement = new MarkdownStrikethrough(text);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendStrikethrough(this MarkdownParagraph paragraph, Action<MarkdownStrikethrough> action)
        {
            var inlineElement = new MarkdownStrikethrough();
            action(inlineElement);
            paragraph.Append(inlineElement);
            return paragraph;
        }

        public static MarkdownParagraph AppendStrong(this MarkdownParagraph paragraph, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var inlineElement = new MarkdownStrong(text);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendStrong(this MarkdownParagraph paragraph, Action<MarkdownStrong> action)
        {
            var inlineElement = new MarkdownStrong();
            action(inlineElement);
            paragraph.Append(inlineElement);
            return paragraph;
        }

        public static MarkdownParagraph AppendStrongEmphasis(this MarkdownParagraph paragraph, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var inlineElement = new MarkdownStrongEmphasis(text);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendStrongEmphasis(this MarkdownParagraph paragraph, Action<MarkdownStrongEmphasis> action)
        {
            var inlineElement = new MarkdownStrongEmphasis();
            action(inlineElement);
            paragraph.Append(inlineElement);
            return paragraph;
        }

        public static MarkdownParagraph AppendSubscript(this MarkdownParagraph paragraph, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var inlineElement = new MarkdownSubscript(text);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendSuperscript(this MarkdownParagraph paragraph, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var inlineElement = new MarkdownSuperscript(text);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }

        public static MarkdownParagraph AppendText(this MarkdownParagraph paragraph, string text)
        {
            if (!string.IsNullOrEmpty(text))
            { 
                var inlineElement = new MarkdownText(text);
                paragraph.Append(inlineElement);
            }
            return paragraph;
        }
    }
}
