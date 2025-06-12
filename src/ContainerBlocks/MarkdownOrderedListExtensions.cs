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
    /// Extensions for <see cref="MarkdownOrderedList"/>
    /// </summary>
    public static class MarkdownOrderedListExtensions
    {
        public static MarkdownOrderedList Append(this MarkdownOrderedList list, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var listItem = new MarkdownOrderedListItem();
                listItem.AppendParagraph(text);
                list.Append(listItem);
            }
            return list;
        }

        public static MarkdownOrderedList Append(this MarkdownOrderedList list, Action<MarkdownOrderedListItem> action)
        {
            var listItem = new MarkdownOrderedListItem();
            action(listItem);
            list.Append(listItem);
            return list;
        }

        public static MarkdownOrderedList AppendOrderedList(this MarkdownOrderedList list, int start, Action<MarkdownOrderedList> action)
        {
            var listItem = new MarkdownOrderedList(start);
            action(listItem);
            list.Append(listItem);
            return list;
        }

        public static MarkdownOrderedList AppendTaskList(this MarkdownOrderedList list, Action<MarkdownTaskList> action)
        {
            var listItem = new MarkdownTaskList();
            action(listItem);
            list.Append(listItem);
            return list;
        }

        public static MarkdownOrderedList AppendUnorderedList(this MarkdownOrderedList list, Action<MarkdownUnorderedList> action)
        {
            var listItem = new MarkdownUnorderedList();
            action(listItem);
            list.Append(listItem);
            return list;
        }
    }
}
