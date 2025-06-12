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

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents an abstract <a href="https://github.github.com/gfm/#leaf-blocks">leaf block</a>
    /// </summary>
    public abstract class MarkdownLeafBlock : IMarkdownLeafBlock
    {
        protected readonly List<IMarkdownInline> _inlineElements = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownLeafBlock"/> class.
        /// </summary>
        public MarkdownLeafBlock()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownLeafBlock"/> class.
        /// </summary>
        /// <param name="text">Simple text</param>
        public MarkdownLeafBlock(string text)
        {
            Append(text);
        }

        /// <summary>
        /// Appends simple text
        /// </summary>
        /// <param name="text">Simple text</param>
        public void Append(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                _inlineElements.Add(new MarkdownText(text));
            }
        }

        /// <summary>
        /// Appends a list of inline elements
        /// </summary>
        /// <param name="inlineElements">The list of inline elements</param>
        public void Append(params IMarkdownInline[] inlineElements)
        {
            _inlineElements.AddRange(inlineElements);
        }

        /// <summary>
        /// Replaces the content of the leaf block with simple text
        /// </summary>
        /// <param name="text">Simple text</param>
        public void Assign(string text)
        {
            Clear();
            Append(text);
        }

        /// <summary>
        /// Replaces the content of the leaf block with a new leaf block
        /// </summary>
        /// <param name="block">The leaf block</param>
        public void Assign(MarkdownLeafBlock block)
        {
            Assign(block._inlineElements.ToArray());
        }

        /// <summary>
        /// Replaces the content of the leaf block with a list of new inline elements
        /// </summary>
        /// <param name="inlineElements">The list of inline elements</param>
        public void Assign(params IMarkdownInline[] inlineElements)
        {
            Clear();
            Append(inlineElements);
        }

        /// <summary>
        /// Clears the content of the leaf block 
        /// </summary>
        public void Clear()
        {
            _inlineElements.Clear();
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
            var wasLineBreak = false;
            
            foreach (var element in _inlineElements)
            {
                if ((element is MarkdownHardLineBreak) || (element is MarkdownSoftLineBreak))
                {
                    wasLineBreak = true;
                }
                else
                {
                    if (wasLineBreak)
                    {
                        textWriter.WriteWithIndent(hangingPrefix, hangingIndent);
                        wasLineBreak = false;
                    }
                }

                element.WriteContent(textWriter, formatProvider);
            }
        }
    }
}
