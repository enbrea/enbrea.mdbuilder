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
    /// Represents a <a href="https://github.github.com/gfm/#paragraphs">paragraph</a> 
    /// </summary>
    public class MarkdownParagraph : MarkdownLeafBlock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownParagraph"/> class.
        /// </summary>
        public MarkdownParagraph()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownParagraph"/> class.
        /// </summary>
        /// <param name="text">A text</param>
        public MarkdownParagraph(string text)
            : base(text)
        {
        }
    }
}
