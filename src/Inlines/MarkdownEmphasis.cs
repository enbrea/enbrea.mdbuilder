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
    /// Represents an <a href="https://github.github.com/gfm/#emphasis-and-strong-emphasis">emphasis indicator</a>
    /// </summary>
    public class MarkdownEmphasis : MarkdownInline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownEmphasis"/> class.
        /// </summary>
        public MarkdownEmphasis()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownEmphasis"/> class.
        /// </summary>
        /// <param name="text">A simple text</param>
        public MarkdownEmphasis(string text)
            : base(text)
        {
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.Write(formatProvider.EmphasisTag);
            base.WriteContent(textWriter, formatProvider);
            textWriter.Write(formatProvider.EmphasisTag);
        }
    }
}
