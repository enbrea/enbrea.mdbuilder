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

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents a table column</a> 
    /// </summary>
    public class MarkdownTableColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTableColumn"/> class.
        /// </summary>
        /// <param name="alignment">The column alignment</param>
        public MarkdownTableColumn(MarkdownTableColumnAlignment alignment = MarkdownTableColumnAlignment.None)
        {
            Alignment = alignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTableColumn"/> class.
        /// </summary>
        /// <param name="content">The column text</param>
        /// <param name="alignment">The column alignment</param>
        public MarkdownTableColumn(string content, MarkdownTableColumnAlignment alignment = MarkdownTableColumnAlignment.None)
        {
            Alignment = alignment;
            Content = new MarkdownParagraph(content);
        }

        /// <summary>
        /// Assigns new content to the column
        /// </summary>
        /// <param name="content">The column content</param>
        /// <param name="alignment">The column alignment</param>
        public void Assign(string content, MarkdownTableColumnAlignment alignment = MarkdownTableColumnAlignment.None)
        {
            Alignment = alignment;
            Content = new MarkdownParagraph(content);
        }

        /// <summary>
        /// Assigns new content to the column
        /// </summary>
        /// <param name="content">The column content</param>
        /// <param name="alignment">The column alignment</param>
        public void Assign(IMarkdownLeafBlock content, MarkdownTableColumnAlignment alignment = MarkdownTableColumnAlignment.None)
        {
            Alignment = alignment;
            Content = content;
        }

        /// <summary>
        /// The column alignment
        /// </summary>
        public MarkdownTableColumnAlignment Alignment { get; internal set; }

        /// <summary>
        /// The column content
        /// </summary>
        public IMarkdownLeafBlock Content { get; internal set; }
    }
}
