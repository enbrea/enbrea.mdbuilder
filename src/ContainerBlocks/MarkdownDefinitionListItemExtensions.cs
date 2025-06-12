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
    /// Extensions for <see cref="IMarkdownDefinitionListItem"/>
    /// </summary>
    public static class MarkdownDefinitionListItemExtensions
    {
        public static IMarkdownDefinitionListItem AssignTitle(this IMarkdownDefinitionListItem listItem, string title)
        {
            var paragraph = new MarkdownParagraph(title);
            listItem.AssignTitle(paragraph);
            return listItem;
        }

        public static IMarkdownDefinitionListItem AssignTitle(this IMarkdownDefinitionListItem listItem, Action<MarkdownParagraph> action)
        {
            var paragraph = new MarkdownParagraph();
            action(paragraph);
            listItem.AssignTitle(paragraph);
            return listItem;
        }

    }
}
