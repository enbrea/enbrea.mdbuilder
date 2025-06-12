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

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents an abstract list</a>
    /// </summary>
    public abstract class MarkdownList : IMarkdownList, IMarkdownListItem
    {
        protected readonly List<IMarkdownListItem> _listItems = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownDefinitionList"/> class.
        /// </summary>
        public MarkdownList()
        {
        }

        /// <summary>
        /// Appends a list of inline elements
        /// </summary>
        /// <param name="listItems"></param>
        public void Append(params IMarkdownListItem[] listItems)
        {
            _listItems.AddRange(listItems);
        }


        /// <summary>
        /// clears the list of inline elements
        /// </summary>
        public void Clear()
        {
            _listItems.Clear();
        }

        /// <summary>
        /// Writes the content to a text stream
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        /// <param name="hangingIndent">An optional hanging indent</param>
        /// <param name="hangingPrefix">An optional hanging prefix</param>
        public void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider, int hangingIndent = 0, string hangingPrefix = null)
        {
            var listItemIndex = 0;

            for (var itemIndex = 0; itemIndex < _listItems.Count; itemIndex++)
            {
                var listItem = _listItems[itemIndex];

                if (listItem != _listItems.First())
                {
                    textWriter.WriteWithIndent(hangingPrefix, hangingIndent);
                }

                var listMarker = GetListMarker(listItemIndex, listItem, formatProvider);

                if (listItem is IMarkdownList)
                {
                    textWriter.WriteIndent(listMarker.Length);
                }
                else
                {
                    if (listMarker != null)
                    {
                        textWriter.Write(listMarker);
                    }

                    listItemIndex++;
                }

                listItem.WriteContent(textWriter, formatProvider, hangingIndent + (listMarker == null ? 0 : listMarker.Length), hangingPrefix);

                if (listItem != _listItems.Last())
                {
                    textWriter.WriteLine();
                    textWriter.WriteLine(hangingPrefix);
                }
            }
        }

        /// <summary>
        /// Gives back an optional marker (e.g. number or bullet point) for a given list item
        /// </summary>
        /// <param name="position">The current position of the list iten</param>
        /// <param name="listItem">The list item</param>
        /// <param name="formatProvider">Formatting options for serialization</param>
        /// <returns>The marker as string</returns>
        protected abstract string GetListMarker(int position, IMarkdownListItem listItem, IMarkdownFormatProvider formatProvider);
    }
}
