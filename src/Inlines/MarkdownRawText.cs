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
using System.IO;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents an unescaped text element (e.g. for raw HTML)</a>
    /// </summary>
    public class MarkdownRawText : IMarkdownInline
    {
        private readonly string _text;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownRawText"/> class.
        /// </summary>
        /// <param name="text">The raw text</param>
        public MarkdownRawText(string text)
        {
            _text = text.Replace(Environment.NewLine, " ");
        }

        /// <summary>
        /// Writes the content to a text stream
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        public virtual void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.Write(_text);
        }
    }
}
