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
    /// Extensions for <see cref="MarkdownUnorderedList"/>
    /// </summary>
    public static class MarkdownUnorderedListExtensions
    {
        public static MarkdownUnorderedList Append(this MarkdownUnorderedList list, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var listItem = new MarkdownUnorderedListItem();
                listItem.AppendParagraph(text);
                list.Append(listItem);
            }
            return list;
        }

        public static MarkdownUnorderedList Append(this MarkdownUnorderedList list, Action<MarkdownUnorderedListItem> action)
        {
            var listItem = new MarkdownUnorderedListItem();
            action(listItem);
            list.Append(listItem);
            return list;
        }

        public static MarkdownUnorderedList AppendOrderedList(this MarkdownUnorderedList list, int start, Action<MarkdownOrderedList> action)
        {
            var listItem = new MarkdownOrderedList(start);
            action(listItem);
            list.Append(listItem);
            return list;
        }

        public static MarkdownUnorderedList AppendTaskList(this MarkdownUnorderedList list, Action<MarkdownTaskList> action)
        {
            var listItem = new MarkdownTaskList();
            action(listItem);
            list.Append(listItem);
            return list;
        }

        public static MarkdownUnorderedList AppendUnorderedList(this MarkdownUnorderedList list, Action<MarkdownUnorderedList> action)
        {
            var listItem = new MarkdownUnorderedList();
            action(listItem);
            list.Append(listItem);
            return list;
        }
    }
}
