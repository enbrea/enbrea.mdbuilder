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
    /// Reperesents a list item for a <see cref="MarkdownTaskList"/> 
    /// </summary>
    public class MarkdownTaskListItem : MarkdownContainerBlock, IMarkdownTaskListItem
    {
        private bool _isChecked = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTaskListItem"/> class.
        /// </summary>
        /// <param name="isChecked">Is the task active?</param>
        public MarkdownTaskListItem(bool isChecked)
            : base()
        {
            _isChecked = isChecked;
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider options, int hangingIndent = 0, string hangingPrefix = null)
        {
            if (_isChecked)
            {
                textWriter.Write("[x] ");
            }
            else
            {
                textWriter.Write("[ ] ");
            }

            base.WriteContent(textWriter, options, hangingIndent, hangingPrefix);
        }
    }
}
