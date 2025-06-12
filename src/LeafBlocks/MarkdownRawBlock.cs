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
    /// Represents a block of unformatted text (e.g. for raw HTML)
    /// </summary>
    public class MarkdownRawBlock : MarkdownCodeBlock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownRawBlock"/> class.
        /// </summary>
        /// <param name="rawText">The unformatted text</param>
        public MarkdownRawBlock(string rawText)
            : base(rawText)
        {
        }
    }
}
