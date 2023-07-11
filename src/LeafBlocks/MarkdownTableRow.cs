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

using System.Collections.Generic;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents a table data row</a> 
    /// </summary>
    public class MarkdownTableRow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTableRow"/> class.
        /// </summary>
        public MarkdownTableRow()
        {
        }

        /// <summary>
        /// The data cells
        /// </summary>
        public List<IMarkdownLeafBlock> CellContents { get; } = new();

        /// <summary>
        /// Appends a new data cell
        /// </summary>
        /// <param name="cellContent">The cell content</param>
        public void Append(string cellContent)
        {
            CellContents.Add(new MarkdownParagraph(cellContent));
        }

        /// <summary>
        /// Appends a new data cell
        /// </summary>
        /// <param name="cellContent">The The cell content</param>
        public void Append(IMarkdownLeafBlock cellContent)
        {
            CellContents.Add(cellContent);
        }
    }
}
