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
    /// Extensions for <see cref="MarkdownDefinitionList"/>
    /// </summary>
    public static class MarkdownDefinitionListExtensions
    {
        public static MarkdownDefinitionList Append(this MarkdownDefinitionList list, string title, Action<MarkdownDefinitionListItem> action)
        {
            var listItem = new MarkdownDefinitionListItem(title);
            action(listItem);
            list.Append(listItem);
            return list;
        }

        public static MarkdownDefinitionList Append(this MarkdownDefinitionList list, Action<MarkdownDefinitionListItem> action)
        {
            var listItem = new MarkdownDefinitionListItem();
            action(listItem);
            list.Append(listItem);
            return list;
        }
    }
}
