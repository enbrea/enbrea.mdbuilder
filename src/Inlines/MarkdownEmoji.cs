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
    /// Represents an emoji</a>
    /// </summary>
    public class MarkdownEmoji : MarkdownRawText
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownEmoji"/> class.
        /// </summary>
        /// <param name="code">The emoij code</param>
        public MarkdownEmoji(string code)
            : base($":{code}:")
        {
        }
    }
}
