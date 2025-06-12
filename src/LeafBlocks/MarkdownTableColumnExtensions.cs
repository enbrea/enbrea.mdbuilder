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
    /// Extensions for <see cref="MarkdownTableColumn"/>
    /// </summary>
    public static class MarkdownTableColumnExtensions
    {
        public static MarkdownTableColumn Assign(this MarkdownTableColumn column, string content, MarkdownTableColumnAlignment alignment = MarkdownTableColumnAlignment.None)
        {
            if (!string.IsNullOrEmpty(content))
            {
                column.Assign(content, alignment);
            }
            return column;
        }

        public static MarkdownTableColumn Assign(this MarkdownTableColumn column, Action<MarkdownParagraph> action, MarkdownTableColumnAlignment alignment = MarkdownTableColumnAlignment.None)
        {
            var paragraph = new MarkdownParagraph();
            action(paragraph);
            column.Assign(paragraph, alignment);
            return column;
        }
    }
}
