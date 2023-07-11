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
    /// Represents a <a href="https://facelessuser.github.io/pymdown-extensions/extensions/caret/">superscript indicator</a>
    /// </summary>
    public class MarkdownSuperscript : MarkdownInline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownSuperscript"/> class.
        /// </summary>
        public MarkdownSuperscript()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownSuperscript"/> class.
        /// </summary>
        /// <param name="text">A simple text</param>
        public MarkdownSuperscript(string text)
            : base(text)
        {
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.Write(formatProvider.SuperscriptTag);
            base.WriteContent(textWriter, formatProvider);
            textWriter.Write(formatProvider.SuperscriptTag);
        }
    }
}
