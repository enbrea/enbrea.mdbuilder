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
    /// Represents a table header</a> 
    /// </summary>
    public class MarkdownTableHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTableHeader"/> class.
        /// </summary>
        public MarkdownTableHeader()
        {
        }

        /// <summary>
        /// List of table header columns
        /// </summary>
        public List<MarkdownTableColumn> Columns { get; } = new();

        /// <summary>
        /// Appends a new column to the table header
        /// </summary>
        /// <param name="column">The column</param>
        public void Append(MarkdownTableColumn column)
        {
            Columns.Add(column);
        }

        /// <summary>
        /// Assign the columns from another header
        /// </summary>
        /// <param name="header">The other header</param>
        public void Assign(MarkdownTableHeader header)
        {
            Columns.Clear();
            Columns.AddRange(header.Columns);
        }
    }
}
