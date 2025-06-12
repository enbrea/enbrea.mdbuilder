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
    /// Extensions for <see cref="TextWriter"/>
    /// </summary>
    public static class TextWriterExtensions
    {
        /// <summary>
        /// Writes an indent to the text stream.
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="indent">The indent width</param>
        public static void WriteIndent(this TextWriter textWriter, int indent)
        {
            if (indent > 0)
            {
                textWriter.Write(StringUtils.Indent(indent));
            }
        }

        /// <summary>
        /// Writes an indent and a line break to the text stream.
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="indent">The indent width</param>
        public static void WriteLineWithIndent(this TextWriter textWriter, int indent)
        {
            textWriter.WriteIndent(indent);
            textWriter.WriteLine();
        }

        /// <summary>
        /// Writes a prefix, an indent and a line break to the text stream.
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="prefix">The prefix string</param>
        /// <param name="indent">The indent width</param>
        public static void WriteLineWithIndent(this TextWriter textWriter, string prefix, int indent)
        {
            textWriter.Write(prefix);
            textWriter.WriteIndent(indent);
            textWriter.WriteLine();
        }

        /// <summary>
        /// Writes an indent, a text string and a line break to the text stream.
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="indent">The indent width</param>
        /// <param name="text">A text string</param>
        public static void WriteLineWithIndent(this TextWriter textWriter, int indent, string text)
        {
            textWriter.WriteIndent(indent);
            textWriter.WriteLine(text);
        }

        /// <summary>
        /// Writes a prefix, an indent, a text string and a line break to the text stream.
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="prefix">The prefix string</param>
        /// <param name="indent">The indent width</param>
        /// <param name="text">A text string</param>
        public static void WriteLineWithIndent(this TextWriter textWriter, string prefix, int indent, string text)
        {
            textWriter.Write(prefix);
            textWriter.WriteIndent(indent);
            textWriter.WriteLine(text);
        }

        /// <summary>
        /// Writes a prefix plus an indent to the text stream.
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="prefix">The prefix string</param>
        /// <param name="indent">The indent width</param>
        public static void WriteWithIndent(this TextWriter textWriter, string prefix, int indent)
        {
            textWriter.Write(prefix);
            textWriter.WriteIndent(indent);
        }

        /// <summary>
        /// Writes an indent and a text string to the text stream.
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="indent">The indent width</param>
        /// <param name="text">A text string</param>
        public static void WriteWithIndent(this TextWriter textWriter, int indent, string text)
        {
            textWriter.WriteIndent(indent);
            textWriter.Write(text);
        }

        /// <summary>
        /// Writes a prefix, an indent and a text string to the text stream.
        /// </summary>
        /// <param name="textWriter">The text stream</param>
        /// <param name="prefix">The prefix string</param>
        /// <param name="indent">The indent width</param>
        /// <param name="text">A text string</param>
        public static void WriteWithIndent(this TextWriter textWriter, string prefix, int indent, string text)
        {
            textWriter.Write(prefix);
            textWriter.WriteIndent(indent);
            textWriter.Write(text);
        }
    }
}
