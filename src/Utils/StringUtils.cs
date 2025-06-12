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
    /// Static utils class for <see cref="string"/>
    /// </summary>
    public static class StringUtils
    {
        /// <summary>
        /// Creates an indent string
        /// </summary>
        /// <param name="indent">indent width</param>
        /// <returns>The indent string</returns>
        public static string Indent(int indent)
        {
            return Repeat(' ', indent);
        }

        /// <summary>
        /// Creates a string line by repeating a given char
        /// </summary>
        /// <param name="lineChar">The char</param>
        /// <param name="repeatCount">Repeat count</param>
        /// <returns>The string line</returns>
        public static string Repeat(char lineChar, int repeatCount)
        {
            return new string(lineChar, repeatCount);
        }
    }
}
