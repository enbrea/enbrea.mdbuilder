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
    /// Represents a <a href="https://github.github.com/gfm/#links">link</a>
    /// </summary>
    public class MarkdownLink : MarkdownInline
    {
        private readonly string _destination;
        private readonly string _title;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownLink"/> class.
        /// </summary>
        /// <param name="text">The text</param>
        /// <param name="destination">The destination</param>
        /// <param name="title">The link title</param>
        public MarkdownLink(string text, string destination, string title = null)
            : base(text)
        {
            _destination = destination;
            _title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownLink"/> class.
        /// </summary>
        /// <param name="text">The text</param>
        /// <param name="destination">The destination</param>
        /// <param name="title">The link title</param>
        public MarkdownLink(string text, Uri destination, string title = null)
            : this(text, destination.AbsoluteUri, title)
        {
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.Write("[");
            base.WriteContent(textWriter, formatProvider);
            
            if (string.IsNullOrEmpty(_title))
            {
                textWriter.Write($"]({_destination})");
            }
            else
            {
                textWriter.Write($"]({_destination} \"{_title}\")");
            }
        }
    }
}
