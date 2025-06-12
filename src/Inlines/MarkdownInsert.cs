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
    /// Represents a <a href="https://facelessuser.github.io/pymdown-extensions/extensions/caret/">insert indicator</a>
    /// </summary>
    public class MarkdownInsert : MarkdownInline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownInsert"/> class.
        /// </summary>
        public MarkdownInsert()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownInsert"/> class.
        /// </summary>
        /// <param name="text">A simple text</param>
        public MarkdownInsert(string text)
            : base(text)
        {
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.Write(formatProvider.InsertTag);
            base.WriteContent(textWriter, formatProvider);
            textWriter.Write(formatProvider.InsertTag);
        }
    }
}
