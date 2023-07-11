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
    /// Represents a <a href="https://github.github.com/gfm/#fenced-code-blocks">fenced code block</a>
    /// </summary>
    public class MarkdownFencedCode : MarkdownCodeBlock
    {
        private readonly string _language = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownFencedCode"/> class.
        /// </summary>
        /// <param name="code">The code</param>
        public MarkdownFencedCode(string code)
            : base(code)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownFencedCode"/> class.
        /// </summary>
        /// <param name="language">The code language</param>
        /// <param name="code">The code</param>
        public MarkdownFencedCode(string language, string code)
            : base(code)
        {
            _language = language;
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider, int hangingIndent = 0, string hangingPrefix = null)
        {
            if (!string.IsNullOrEmpty(_language))
            {
                textWriter.WriteLine($"``` {_language}");
            }
            else
            {
                textWriter.WriteLine("```");
            }

            textWriter.WriteIndent(hangingIndent);

            base.WriteContent(textWriter, formatProvider, hangingIndent);

            textWriter.WriteLine();
            
            textWriter.WriteWithIndent(hangingIndent, "```");
        }
    }
}
