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

using System.Text;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Default text escaping for Markdown serialization
    /// </summary>
    public class MarkdownDefaultEscapeProvider : IMarkdownEscapeProvider
    {
        /// <summary>
        /// Escapes the specified text.
        /// </summary>
        /// <param name="text">The text to process.</param>
        public string EscapeText(string value)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < value.Length; i++)
            {
                switch (value[i])
                {
                    case '\\':
                    case '`':
                    case '*':
                    case '_':
                    case '/':
                    case '{':
                    case '}':
                    case '(':
                    case ')':
                    case '[':
                    case ']':
                    case '-':
                    case '.':
                    case '#':
                    case '!':
                    case '|':
                        sb.Append('\\');
                        break;
                    default:
                        break;
                }
                sb.Append(value[i]);
            }
            return sb.ToString();
        }

    }
}
