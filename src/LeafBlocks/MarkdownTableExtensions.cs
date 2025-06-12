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
    /// Extensions for <see cref="MarkdownTable"/>
    /// </summary>
    public static class MarkdownTableExtensions
    {
        public static MarkdownTable AppendRow(this MarkdownTable table, Action<MarkdownTableRow> action)
        {
            var row = new MarkdownTableRow();
            action(row);
            table.Append(row);
            return table;
        }

        public static MarkdownTable AssignHeader(this MarkdownTable table, Action<MarkdownTableHeader> action)
        {
            var header = new MarkdownTableHeader();
            action(header);
            table.AssignHeader(header);
            return table;
        }
    }
}
