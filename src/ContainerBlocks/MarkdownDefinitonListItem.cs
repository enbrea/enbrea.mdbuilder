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

using System.IO;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Reperesents a list item for a <see cref="MarkdownDefinitionList"/> 
    /// </summary>
    public class MarkdownDefinitionListItem : MarkdownContainerBlock, IMarkdownDefinitionListItem
    {
        private readonly MarkdownParagraph _title = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownDefinitionListItem"/> class.
        /// </summary>
        public MarkdownDefinitionListItem()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownDefinitionListItem"/> class.
        /// </summary>
        /// <param name="title">A title string</param>
        public MarkdownDefinitionListItem(string title)
            : base()
        {
            AssignTitle(title);
        }

        /// <summary>
        /// Assign the title string
        /// </summary>
        /// <param name="title"></param>
        public void AssignTitle(string title)
        {
            _title.Assign(title);
        }

        /// <summary>
        /// Assigns the title as paragraph
        /// </summary>
        /// <param name="title"></param>
        public void AssignTitle(MarkdownParagraph title)
        {
            _title.Assign(title);
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider, int hangingIndent = 0, string hangingPrefix = null)
        {
            _title.WriteContent(textWriter, formatProvider, hangingIndent, hangingPrefix);

            textWriter.WriteLine();
            textWriter.WriteLine();

            textWriter.WriteWithIndent(hangingIndent, ":   ");

            base.WriteContent(textWriter, formatProvider, hangingIndent + 4, hangingPrefix);
        }
    }
}
