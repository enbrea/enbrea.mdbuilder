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
    /// Represents an <a href="https://github.github.com/gfm/#emphasis-and-strong-emphasis">strong emphasis indicator</a>
    /// </summary>
    public class MarkdownStrongEmphasis : MarkdownInline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownStrongEmphasis"/> class.
        /// </summary>
        public MarkdownStrongEmphasis()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownStrongEmphasis"/> class.
        /// </summary>
        /// <param name="text">A simple text</param>
        public MarkdownStrongEmphasis(string text)
            : base(text)
        {
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.Write(formatProvider.StrongEmphasisTag);
            base.WriteContent(textWriter, formatProvider);
            textWriter.Write(formatProvider.StrongEmphasisTag);
        }
    }
}
