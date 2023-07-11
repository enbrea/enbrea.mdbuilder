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

using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// The Markdown builder
    /// </summary>
    public class MarkdownBuilder : MarkdownContainerBlock
    {
        /// <summary>
        /// Gives back the content of the Markdown document as string
        /// </summary>
        /// <returns>The Markdown document as string</returns>
        public override string ToString()
        {
            return ToString(new MarkdownDefaultFormatProvider());
        }

        /// <summary>
        /// Gives back the content of the Markdown document as string
        /// </summary>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        /// <returns>The Markdown document as string</returns>
        public string ToString(IMarkdownFormatProvider formatProvider)
        {
            var sb = new StringBuilder();

            using var textWriter = new StringWriter(sb);
            WriteContent(textWriter, formatProvider);

            return sb.ToString();
        }

        /// <summary>
        /// Writes the content of the content of the Markdown document to a stream
        /// </summary>
        /// <param name="stream">The stream</param>
        public void WriteTo(Stream stream)
        {
            WriteTo(stream, new MarkdownDefaultFormatProvider());
        }

        /// <summary>
        /// Writes the content of the content of the Markdown document to a stream
        /// </summary>
        /// <param name="stream">The stream</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        public void WriteTo(Stream stream, IMarkdownFormatProvider formatProvider)
        {
            using var textWriter = new StreamWriter(stream);
            WriteContent(textWriter, formatProvider);
        }

        /// <summary>
        /// Writes the content of the content of the Markdown document to a new file
        /// </summary>
        /// <param name="fileInfo">The file</param>
        public void WriteTo(FileInfo fileInfo)
        {
            WriteTo(fileInfo, new MarkdownDefaultFormatProvider());
        }

        /// <summary>
        /// Writes the content of the content of the Markdown document to a new file
        /// </summary>
        /// <param name="fileInfo">The file</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        public void WriteTo(FileInfo fileInfo, IMarkdownFormatProvider formatProvider)
        {
            using var textStream = fileInfo.Create();
            WriteTo(textStream, formatProvider);
        }

        /// <summary>
        /// Writes the content of the content of the Markdown document to a new file
        /// </summary>
        /// <param name="filePath">The file path</param>
        public void WriteTo(string filePath)
        {
            WriteTo(filePath, new MarkdownDefaultFormatProvider());
        }

        /// <summary>
        /// Writes the content of the content of the Markdown document to a new file
        /// </summary>
        /// <param name="filePath">The file path</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        public void WriteTo(string filePath, IMarkdownFormatProvider formatProvider)
        {
            WriteTo(new FileInfo(filePath), formatProvider);
        }

        /// <summary>
        /// Asynchronously writes the content of the content of the Markdown document to a stream
        /// </summary>
        /// <param name="stream">The stream</param>
        /// <returns>A task that represents the asynchronous write operation</returns>
        public async Task WriteToAsync(Stream stream)
        {
            await WriteToAsync(stream, new MarkdownDefaultFormatProvider());
        }

        /// <summary>
        /// Asynchronously writes the content of the content of the Markdown document to a stream
        /// </summary>
        /// <param name="stream">The stream</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        /// <returns>A task that represents the asynchronous write operation</returns>
        public async Task WriteToAsync(Stream stream, IMarkdownFormatProvider formatProvider)
        {
            using var textWriter = new StreamWriter(stream);
            await textWriter.WriteAsync(ToString(formatProvider));
        }

        /// <summary>
        /// Asynchronously writes the content of the content of the Markdown document to a new file
        /// </summary>
        /// <param name="fileInfo">The file</param>
        /// <returns>A task that represents the asynchronous write operation</returns>
        public async Task WriteToAsync(FileInfo fileInfo)
        {
            await WriteToAsync(fileInfo, new MarkdownDefaultFormatProvider());
        }

        /// <summary>
        /// Asynchronously writes the content of the content of the Markdown document to a new file
        /// </summary>
        /// <param name="fileInfo">The file</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        /// <returns>A task that represents the asynchronous write operation</returns>
        public async Task WriteToAsync(FileInfo fileInfo, IMarkdownFormatProvider formatProvider)
        {
            using var textStream = fileInfo.Create();
            await WriteToAsync(textStream, formatProvider);
        }

        /// <summary>
        /// Asynchronously writes the content of the content of the Markdown document to a new file
        /// </summary>
        /// <param name="filePath">The file path</param>
        /// <returns>A task that represents the asynchronous write operation</returns>
        public async Task WriteToAsync(string filePath)
        {
            await WriteToAsync(filePath, new MarkdownDefaultFormatProvider());
        }

        /// <summary>
        /// Asynchronously writes the content of the content of the Markdown document to a new file
        /// </summary>
        /// <param name="filePath">The file path</param>
        /// <param name="formatProvider">Formatting rules for serialization</param>
        /// <returns>A task that represents the asynchronous write operation</returns>
        public async Task WriteToAsync(string filePath, IMarkdownFormatProvider formatProvider)
        {
            await WriteToAsync(new FileInfo(filePath), formatProvider);
        }
    }
}