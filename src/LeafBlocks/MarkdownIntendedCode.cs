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
    /// Represents a <a href="https://github.github.com/gfm/#indented-code-blocks">intended code block</a>
    /// </summary>
    public class MarkdownIntendedCode : MarkdownCodeBlock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownIntendedCode"/> class.
        /// </summary>
        /// <param name="code">The code</param>
        public MarkdownIntendedCode(string code)
            : base(code)
        {
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider, int hangingIndent = 0, string hangingPrefix = null)
        {
            textWriter.WriteIndent(4);

            base.WriteContent(textWriter, formatProvider, hangingIndent + 4);
        }
    }
}
