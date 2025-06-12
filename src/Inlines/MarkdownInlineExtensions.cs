#region ENBREA.MdBuilder - Copyright (C) STÜBER SYSTEMS GmbH
/*    
 *    ENBREA.MdBuilder
 *    
 *    Copyright (C) STÜBER SYSTEMS GmbH
 *
 *    Licensed under the MIT License, Version 2.0. 
 * 
 */
#endregion

using System;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Extensions for <see cref="MarkdownInline"/>
    /// </summary>
    public static class MarkdownInlineExtensions
    {
        public static MarkdownInline AppendAutoLink(this MarkdownInline inlineElement, string destination)
        {
            if (!string.IsNullOrEmpty(destination))
            {
                var subElement = new MarkdownAutoLink(destination);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendAutoLink(this MarkdownInline inlineElement, Uri destination)
        {
            var subElement = new MarkdownAutoLink(destination);
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendCodeSpan(this MarkdownInline inlineElement, string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var subElement = new MarkdownCodeSpan(code);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendEmoij(this MarkdownInline inlineElement, string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var subElement = new MarkdownEmoji(code);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendEmphasis(this MarkdownInline inlineElement, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var subElement = new MarkdownEmphasis(text);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendEmphasis(this MarkdownInline inlineElement, Action<MarkdownEmphasis> action)
        {
            var subElement = new MarkdownEmphasis();
            action(subElement);
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendHardLineBreak(this MarkdownInline inlineElement)
        {
            var subElement = new MarkdownHardLineBreak();
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendImage(this MarkdownInline inlineElement, string text, string destination)
        {
            if (!string.IsNullOrEmpty(destination))
            {
                var subElement = new MarkdownImage(text, destination);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendImage(this MarkdownInline inlineElement, string text, string destination, string title)
        {
            if (!string.IsNullOrEmpty(destination))
            {
                var subElement = new MarkdownImage(text, destination, title);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendImage(this MarkdownInline inlineElement, string text, Uri destination)
        {
            var subElement = new MarkdownImage(text, destination);
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendImage(this MarkdownInline inlineElement, string text, Uri destination, string title)
        {
            var subElement = new MarkdownImage(text, destination, title);
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendImage(this MarkdownInline inlineElement, MarkdownImage subElement)
        {
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendLink(this MarkdownInline inlineElement, string text, string destination, string title = null)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var subElement = new MarkdownLink(text, destination, title);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendLink(this MarkdownInline inlineElement, string text, Uri destination, string title = null)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var subElement = new MarkdownLink(text, destination, title);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendRawText(this MarkdownInline inlineElement, string rawText)
        {
            var subElement = new MarkdownRawText(rawText);
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendSoftLineBreak(this MarkdownInline inlineElement)
        {
            var subElement = new MarkdownSoftLineBreak();
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendStrikethrough(this MarkdownInline inlineElement, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var subElement = new MarkdownStrikethrough(text);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendStrikethrough(this MarkdownInline inlineElement, Action<MarkdownStrikethrough> action)
        {
            var subElement = new MarkdownStrikethrough();
            action(subElement);
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendStrong(this MarkdownInline inlineElement, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var subElement = new MarkdownStrong(text);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendStrong(this MarkdownInline inlineElement, Action<MarkdownStrong> action)
        {
            var subElement = new MarkdownStrong();
            action(subElement);
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendStrongEmphasis(this MarkdownInline inlineElement, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var subElement = new MarkdownStrongEmphasis(text);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }

        public static MarkdownInline AppendStrongEmphasis(this MarkdownInline inlineElement, Action<MarkdownStrongEmphasis> action)
        {
            var subElement = new MarkdownStrongEmphasis();
            action(subElement);
            inlineElement.Append(subElement);
            return inlineElement;
        }

        public static MarkdownInline AppendText(this MarkdownInline inlineElement, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var subElement = new MarkdownText(text);
                inlineElement.Append(subElement);
            }
            return inlineElement;
        }
    }
}
