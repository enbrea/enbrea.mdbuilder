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

namespace Enbrea.MdBuilder.Tests
{
    /// <summary>
    /// Example for a custom container block.
    /// </summary>
    /// <remarks>
    /// Represents an <a href="https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/organizing-information-with-collapsed-sections">collapsed section</a>
    /// </remarks>
    public class MyCollapsedSection : MarkdownContainerBlock
    {
        private readonly string _summary;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyCollapsedSection"/> class.
        /// </summary>
        /// <param name="summary">A summary text</param>
        public MyCollapsedSection(string summary)
            : base()
        {
            _summary = summary;
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider options, int hangingIndent = 0, string hangingPrefix = null)
        {
            textWriter.WriteLine("<details>");

            textWriter.WriteLineWithIndent(hangingPrefix, hangingIndent, $"<summary>{_summary}</summary>");

            textWriter.WriteLine(hangingPrefix);

            textWriter.WriteWithIndent(hangingPrefix, hangingIndent);

            base.WriteContent(textWriter, options, hangingIndent, hangingPrefix);

            textWriter.WriteLine(hangingPrefix);
            textWriter.WriteLine(hangingPrefix);

            textWriter.WriteWithIndent(hangingPrefix, hangingIndent, "</details>");
        }
    }
}