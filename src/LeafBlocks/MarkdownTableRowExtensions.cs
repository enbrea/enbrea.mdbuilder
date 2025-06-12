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
    /// Extensions for <see cref="MarkdownTableRow"/>
    /// </summary>
    public static class MarkdownTableRowExtensions
    {
        public static MarkdownTableRow Append(this MarkdownTableRow row, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                row.Append(text);
            }
            return row;
        }

        public static MarkdownTableRow Append(this MarkdownTableRow row, Action<MarkdownParagraph> action)
        {
            var paragraph = new MarkdownParagraph();
            action(paragraph);
            row.Append(paragraph);
            return row;
        }
    }
}
