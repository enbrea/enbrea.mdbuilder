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

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents an <a href="https://github.github.com/gfm/#lists">ordered list</a>
    /// </summary>
    public class MarkdownOrderedList : MarkdownList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownUnorderedList"/> class.
        /// </summary>
        /// <param name="start">Start number of the first list item</param>
        public MarkdownOrderedList(int start)
            : base()
        {
            Start = start;
        }

        /// <summary>
        /// Start number of the first list item</param>
        /// </summary>
        public int Start { get; }

        /// <inheritdoc />
        protected override string GetListMarker(int position, IMarkdownListItem listItem, IMarkdownFormatProvider formatProvider)
        {
            return $"{Start + position}. ";
        }
    }
}
