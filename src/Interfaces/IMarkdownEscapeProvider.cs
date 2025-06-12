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

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Text escaping for Markdown serialization
    /// </summary>
    public interface IMarkdownEscapeProvider
    {
        /// <summary>
        /// Escapes the specified text.
        /// </summary>
        /// <param name="text">The text to process.</param>
        string EscapeText(string text);  
    }
}
