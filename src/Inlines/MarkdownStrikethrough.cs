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
    /// Represents a <a href="https://github.github.com/gfm/#strikethrough-extension-">strikethrough indicator</a>
    /// </summary>
    public class MarkdownStrikethrough : MarkdownInline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownStrikethrough"/> class.
        /// </summary>
        public MarkdownStrikethrough()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownStrikethrough"/> class.
        /// </summary>
        /// <param name="text">A simple text</param>
        public MarkdownStrikethrough(string text)
            : base(text)
        {
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.Write(formatProvider.StrikethroughTag);
            base.WriteContent(textWriter, formatProvider);
            textWriter.Write(formatProvider.StrikethroughTag);
        }
    }
}
