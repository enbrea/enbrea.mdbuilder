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

using System.Collections.Generic;
using System.IO;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents an abstract <a href="https://github.github.com/gfm/#inlines">inline element</a>
    /// </summary>
    public abstract class MarkdownInline : IMarkdownInline
    {
        private readonly List<IMarkdownInline> _inlineElements = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownInline"/> class.
        /// </summary>
        public MarkdownInline()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownInline"/> class.
        /// </summary>
        /// <param name="text">A simple text</param>
        public MarkdownInline(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                _inlineElements.Add(new MarkdownText(text));
            }
        }

        /// <summary>
        /// Appends a simple text
        /// </summary>
        /// <param name="text">The simple text</param>
        public void Append(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                _inlineElements.Add(new MarkdownText(text));
            }
        }

        /// <summary>
        /// Appends an inline element
        /// </summary>
        /// <param name="inlineElement">The inline element</param>
        public void Append(IMarkdownInline inlineElement)
        {
            if (inlineElement != null)
            {
                _inlineElements.Add(inlineElement);
            }
        }

        /// <summary>
        /// Appends a a hard line break
        /// </summary>
        public void AppendLine()
        {
            Append(new MarkdownHardLineBreak());
        }

        public void AppendLine(string text)
        {
            Append(text);
            AppendLine();
        }

        /// <summary>
        /// Appends an inline element and a hard line break
        /// </summary>
        /// <param name="inlineElement">The inline element</param>
        public void AppendLine(IMarkdownInline inlineElement)
        {
            Append(inlineElement);
            AppendLine();
        }

        /// <inheritdoc />
        public virtual void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            var wasLineBreak = false;

            foreach (var element in _inlineElements)
            {
                if ((element is MarkdownHardLineBreak) || (element is MarkdownSoftLineBreak))
                {
                    wasLineBreak = true;
                }
                else
                {
                    if (wasLineBreak)
                    {
                        wasLineBreak = false;
                    }
                }

                element.WriteContent(textWriter, formatProvider);
            }
        }
    }
}
