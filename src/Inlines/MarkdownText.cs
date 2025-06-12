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
using System.IO;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents a <a href="https://github.github.com/gfm/#textual-content">text element</a>
    /// </summary>
    public class MarkdownText : IMarkdownInline
    {
        private readonly string _text;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownText"/> class.
        /// </summary>
        /// <param name="text">The text</param>
        public MarkdownText(string text)
        {
            _text = text.Replace(Environment.NewLine, " ");
        }

        /// <summary>
        /// Writes the content to a text stream
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        public void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.Write(formatProvider.EscapeProvider.EscapeText(_text));
        }
    }
}
