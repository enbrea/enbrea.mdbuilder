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
    /// Represents a <a href="https://github.github.com/gfm/#block-quotes">block quote</a>
    /// </summary>
    public class MarkdownBlockQuote : MarkdownContainerBlock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownBlockQuote"/> class.
        /// </summary>
        public MarkdownBlockQuote()
            : base()
        {
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider, int hangingIndent = 0, string hangingPrefix = null)
        {
            textWriter.Write("> ");

            base.WriteContent(textWriter, formatProvider, hangingIndent, (hangingPrefix != null) ? $"{hangingPrefix}> " : "> ");
        }
    }
}

