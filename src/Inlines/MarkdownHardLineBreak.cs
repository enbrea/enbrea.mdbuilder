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
    /// Represents a <a href="https://github.github.com/gfm/#hard-line-breaks">hard line break</a>
    /// </summary>
    public class MarkdownHardLineBreak : IMarkdownInline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownHardLineBreak"/> class.
        /// </summary>
        public MarkdownHardLineBreak()
        {
        }

        /// <inheritdoc />
        public void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.WriteLine("  ");
        }
    }
}
