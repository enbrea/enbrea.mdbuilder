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

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents an abstract <a href="https://github.github.com/gfm/#container-blocks">container block</a>
    /// </summary>
    public class MarkdownContainerBlock : IMarkdownContainerBlock
    {
        protected readonly List<IMarkdownBlock> _blockElements = new();

        /// <summary>
        /// Appends a list of container and/or leaf elements
        /// </summary>
        /// <param name="blockElements"></param>
        public void Append(params IMarkdownBlock[] blockElements)
        {
            _blockElements.AddRange(blockElements);
        }

        /// <summary>
        /// Clears the internal list of block elements
        /// </summary>
        public void Clear()
        {
            _blockElements.Clear();
        }

        /// <summary>
        /// Writes the content to a text stream
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="formatProvider">Formatting options for serialization</param>
        /// <param name="hangingIndent">An optional hanging indent</param>
        /// <param name="hangingPrefix">An optional hanging prefix</param>
        public virtual void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider, int hangingIndent = 0, string hangingPrefix = null)
        {
            foreach (var element in _blockElements) 
            {
                if (element != _blockElements.First())
                {
                    textWriter.WriteWithIndent(hangingPrefix, hangingIndent);
                }

                element.WriteContent(textWriter, formatProvider, hangingIndent, hangingPrefix);

                if (element != _blockElements.Last())
                {
                    textWriter.WriteLine();
                    textWriter.WriteLine(hangingPrefix);
                }
            }
        }
    }
}
