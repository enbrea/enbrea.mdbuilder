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
    /// Represents a <a href="https://facelessuser.github.io/pymdown-extensions/extensions/tilde/">subscript indicator</a>
    /// </summary>
    public class MarkdownSubscript : MarkdownInline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownSubscript"/> class.
        /// </summary>
        public MarkdownSubscript()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownSubscript"/> class.
        /// </summary>
        /// <param name="text">A simple text</param>
        public MarkdownSubscript(string text)
            : base(text)
        {
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider)
        {
            textWriter.Write(formatProvider.SubscriptTag);
            base.WriteContent(textWriter, formatProvider);
            textWriter.Write(formatProvider.SubscriptTag);
        }
    }
}
