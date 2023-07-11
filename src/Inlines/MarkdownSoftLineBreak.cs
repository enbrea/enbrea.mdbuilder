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

using System.IO;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents a <a href="https://github.github.com/gfm/#soft-line-breaks">soft line break</a>
    /// </summary>
    public class MarkdownSoftLineBreak : IMarkdownInline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownSoftLineBreak"/> class.
        /// </summary>
        public MarkdownSoftLineBreak()
        {
        }

        /// <inheritdoc />
        public void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.WriteLine();
        }
    }
}
