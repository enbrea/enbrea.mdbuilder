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
    /// Extensions for <see cref="MarkdownTableHeader"/>
    /// </summary>
    public static class MarkdownTableHeaderExtensions
    {
        public static MarkdownTableHeader AppendColumn(this MarkdownTableHeader header, string columnContent)
        {
            if (!string.IsNullOrEmpty(columnContent))
            {
                header.Append(new MarkdownTableColumn(columnContent));
            }
            return header;
        }

        public static MarkdownTableHeader AppendColumn(this MarkdownTableHeader header, Action<MarkdownTableColumn> action)
        {
            var column = new MarkdownTableColumn();
            action(column);
            header.Append(column);
            return header;
        }
    }
}
