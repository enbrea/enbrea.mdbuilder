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
    /// Represents a <a href="https://github.github.com/gfm/#task-list-items-extension-">task list</a>
    /// </summary>
    public class MarkdownTaskList : MarkdownList
    {
        /// <inheritdoc />
        protected override string GetListMarker(int position, IMarkdownListItem listItem, IMarkdownFormatProvider formatProvider)
        {
            return "- ";
        }
    }
}
