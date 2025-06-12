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
    /// Represents an <a href="https://python-markdown.github.io/extensions/admonition/">admonition block</a> or 
    /// <a href="https://facelessuser.github.io/pymdown-extensions/extensions/details/">details block</a>.
    /// </summary>
    public class MarkdownAdmonition : MarkdownContainerBlock
    {
        private readonly string _theme;
        private readonly string _title;
        private readonly MarkdownAdmonitionType _type;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownAdmonition"/> class.
        /// </summary>
        /// <param name="type">The admonition type</param>
        /// <param name="type">The admonition theme (e.g. info, warning etc.)</param>
        /// <param name="title">The title</param>
        public MarkdownAdmonition(MarkdownAdmonitionType type, string theme, string title)
            : base()
        {
            _type = type;
            _theme = theme;
            _title = title;
        }

        /// <inheritdoc />
        public override void WriteContent(TextWriter textWriter, IMarkdownFormatProvider formatProvider, int hangingIndent = 0, string hangingPrefix = null)
        {
            switch (_type)
            {
                case MarkdownAdmonitionType.Standard:
                    textWriter.WriteLine(string.IsNullOrEmpty(_title) ? $"!!! {_theme}" : $"!!! {_theme} \"{_title}\"");
                    break;
                case MarkdownAdmonitionType.WithoutTitle:
                    textWriter.WriteLine($"!!! {_theme} \"\"");
                    break;
                case MarkdownAdmonitionType.Collapsed:
                    textWriter.WriteLine($"??? {_theme} \"{_title}\"");
                    break;
                case MarkdownAdmonitionType.Expanded:
                    textWriter.WriteLine($"???+ {_theme} \"{_title}\"");
                    break;
            }

            textWriter.WriteLine(hangingPrefix);

            textWriter.WriteWithIndent(hangingPrefix, 4);

            base.WriteContent(textWriter, formatProvider, hangingIndent + 4, hangingPrefix);
        }
    }
}

