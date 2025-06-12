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
    /// Represents an <a href="https://github.github.com/gfm/#images">image</a>
    /// </summary>
    public class MarkdownImage : MarkdownRawText
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownImage"/> class.
        /// </summary>
        /// <param name="text">The text</param>
        /// <param name="destination">The destination</param>
        /// <param name="title">The link title</param>
        public MarkdownImage(string text, string destination)
            : base($"![{text}]({destination})")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownImage"/> class.
        /// </summary>
        /// <param name="text">The text</param>
        /// <param name="destination">The destination</param>
        /// <param name="title">The link title</param>
        public MarkdownImage(string text, Uri destination)
            : this(text, destination.AbsoluteUri)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownImage"/> class.
        /// </summary>
        /// <param name="text">The text</param>
        /// <param name="destination">The destination</param>
        /// <param name="title">The image title</param>
        public MarkdownImage(string text, string destination, string title)
            : base($"![{text}]({destination} \"{title}\")")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownImage"/> class.
        /// </summary>
        /// <param name="text">The text</param>
        /// <param name="destination">The destination</param>
        /// <param name="title">The image title</param>
        public MarkdownImage(string text, Uri destination, string title)
            : this(text, destination.AbsoluteUri, title)
        {
        }
    }
}
