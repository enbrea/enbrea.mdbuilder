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
    /// Extensions for <see cref="MarkdownTaskList"/>
    /// </summary>
    public static class MarkdownTaskListExtensions
    {
        public static MarkdownTaskList Append(this MarkdownTaskList list, bool isChecked, Action<MarkdownTaskListItem> action)
        {
            var listItem = new MarkdownTaskListItem(isChecked);
            action(listItem);
            list.Append(listItem);
            return list;
        }
    }
}
