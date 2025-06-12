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

using System;
using System.Linq;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Represents an abstract code block</a>
    /// </summary>
    public abstract class MarkdownCodeBlock : MarkdownLeafBlock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownCodeBlock"/> class.
        /// </summary>
        /// <param name="code">The code</param>
        public MarkdownCodeBlock(string code)
            : base()
        {
            if (!string.IsNullOrEmpty(code))
            {
                var codeLines = code.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

                foreach (var textLine in codeLines)
                {
                    _inlineElements.Add(new MarkdownRawText(textLine));

                    if (textLine != codeLines.Last())
                    {
                        _inlineElements.Add(new MarkdownSoftLineBreak());
                    }
                }
            }
        }
    }
}
