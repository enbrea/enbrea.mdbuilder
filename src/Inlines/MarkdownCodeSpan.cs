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

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents a <a href="https://github.github.com/gfm/#code-spans">code span</a>
    /// </summary>
    public class MarkdownCodeSpan : MarkdownRawText
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownCodeSpan"/> class.
        /// </summary>
        /// <param name="code">The code</param>
        public MarkdownCodeSpan(string code)
            : base($"`{code}`")
        {
        }
    }
}
