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
    /// Represents a <a href="https://github.github.com/gfm/#emphasis-and-strong-emphasis">strong indicator</a>
    /// </summary>
    public class MarkdownStrong : MarkdownInline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownStrong"/> class.
        /// </summary>
        public MarkdownStrong()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownStrong"/> class.
        /// </summary>
        /// <param name="text">A simple text</param>
        public MarkdownStrong(string text)
            : base(text)
        {
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.Write(formatProvider.StrongTag);
            base.WriteContent(textWriter, formatProvider);
            textWriter.Write(formatProvider.StrongTag);
        }
    }
}
