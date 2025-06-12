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
    /// Represents a <a href="https://github.github.com/gfm/#tables-extension-">table</a> 
    /// </summary>
    public class MarkdownTable : IMarkdownLeafBlock
    {
        private readonly List<MarkdownTableRow> _rows = new();
        private readonly MarkdownTableHeader _header = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTable"/> class.
        /// </summary>
        public MarkdownTable()
        {
        }

        /// <summary>
        /// Appends a new data row to the table
        /// </summary>
        /// <param name="row">The data row</param>
        public void Append(MarkdownTableRow row)
        {
            _rows.Add(row);
        }

        /// <summary>
        /// Assign a new header to the table
        /// </summary>
        /// <param name="header">The header</param>
        public void AssignHeader(MarkdownTableHeader header)
        {
            _header.Assign(header);
        }

        /// <summary>
        /// Writes the content to a text stream
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        /// <param name="hangingIndent">An optional hanging indent</param>
        /// <param name="hangingPrefix">An optional hanging prefix</param>
        public virtual void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider, int hangingIndent = 0, string hangingPrefix = null)
        {
            foreach (var cell in _header.Columns)
            {
                cell.Content.WriteContent(textWriter, formatProvider, hangingIndent, hangingPrefix);

                if (cell != _header.Columns.Last())
                {
                    textWriter.Write(" | ");
                }
            }

            textWriter.WriteLine();

            foreach (var cell in _header.Columns)
            {
                if (cell == _header.Columns.First())
                {
                    textWriter.WriteWithIndent(hangingPrefix, hangingIndent);
                }

                switch (cell.Alignment)
                {
                    case MarkdownTableColumnAlignment.None:
                        textWriter.Write("-");
                        break;
                    case MarkdownTableColumnAlignment.Left:
                        textWriter.Write(":--");
                        break;
                    case MarkdownTableColumnAlignment.Right:
                        textWriter.Write("--:");
                        break;
                    case MarkdownTableColumnAlignment.Center:
                        textWriter.Write(":-:");
                        break;
                }

                if (cell != _header.Columns.Last())
                {
                    textWriter.Write(" | ");
                }
            }

            textWriter.WriteLine();

            foreach (var row in _rows)
            {
                textWriter.WriteIndent(hangingIndent);

                foreach (var cell in row.CellContents)
                {
                    cell.WriteContent(textWriter, formatProvider, hangingIndent, hangingPrefix);

                    if (cell != row.CellContents.Last())
                    {
                        textWriter.Write(" | ");
                    }
                }

                if (row != _rows.Last())
                {
                    textWriter.WriteLine();
                }
            }
        }
    }
}
