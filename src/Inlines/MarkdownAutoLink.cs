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
    /// Represents an <a href="https://github.github.com/gfm/#autolinks">auto link</a>
    /// </summary>
    public class MarkdownAutoLink : MarkdownRawText
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownAutoLink"/> class.
        /// </summary>
        /// <param name="destination">The destination</param>
        public MarkdownAutoLink(string destination)
            : base($"<{destination}>")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownAutoLink"/> class.
        /// </summary>
        /// <param name="destination">The destination</param>
        public MarkdownAutoLink(Uri uri)
            : this(uri.AbsoluteUri)
        {
        }
    }
}
