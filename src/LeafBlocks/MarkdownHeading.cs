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

using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents an <a href="https://github.github.com/gfm/#atx-headings">ATX heading</a>
    /// </summary>
    public class MarkdownHeading : MarkdownParagraph
    {
        private static readonly string[] _prefixes = { "# ", "## ", "### ", "#### ", "##### ", "###### " };

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownHeading"/> class.
        /// </summary>
        /// <param name="level">The heading level</param>
        public MarkdownHeading([Range(1, 6)] byte level)
            : base()
        {
            Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownHeading"/> class.
        /// </summary>
        /// <param name="level">The heading level</param>
        /// <param name="text">The heading text</param>
        public MarkdownHeading([Range(1, 6)] byte level, string text)
            : base(text)
        {
            Level = level;
        }

        /// <summary>
        /// The heading level
        /// </summary>
        public byte Level { get; }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider, int hangingIndent = 0, string prefix = null)
        {
            textWriter.Write(_prefixes[Level - 1]);

            base.WriteContent(textWriter, formatProvider, 0);
        }
    }
}
