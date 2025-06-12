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

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents a <a href="https://python-markdown.github.io/extensions/definition_lists/">definition list</a>
    /// </summary>
    public class MarkdownDefinitionList : MarkdownList
    {
        /// <inheritdoc />
        protected override string GetListMarker(int position, IMarkdownListItem listItem, IMarkdownFormatProvider formatProvider)
        {
            return null;
        }
    }
}
