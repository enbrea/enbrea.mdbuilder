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
    /// Represents a <a href="https://github.github.com/gfm/#thematic-breaks">thematic break</a> 
    /// </summary>
    public class MarkdownThematicBreak : IMarkdownLeafBlock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownThematicBreak"/> class.
        /// </summary>
        public MarkdownThematicBreak()
        {
        }

        /// <summary>
        /// Writes the content to a text stream
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        /// <param name="hangingIndent">An optional hanging indent</param>
        /// <param name="hangingPrefix">An optional hanging prefix</param>
        public virtual void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider, int hangingIndent = 0, string hangingPrefix = null)
        {
            textWriter.Write(StringUtils.Repeat(formatProvider.ThematicBreakCharacter, 3));
        }
    }
}
