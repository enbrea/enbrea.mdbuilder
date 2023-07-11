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

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Formatting options for Markdown serialization
    /// </summary>
    public interface IMarkdownFormatProvider
    {
        /// <summary>
        /// Tag for emphasis
        /// </summary>
        public string EmphasisTag { get; set; }

        /// <summary>
        /// Text escaping
        /// </summary>
        public IMarkdownEscapeProvider EscapeProvider { get; set; }

        /// <summary>
        /// Tag for inserts
        /// </summary>
        public string InsertTag { get; set; }

        /// <summary>
        /// Tag for strikethrough
        /// </summary>
        public string StrikethroughTag { get; set; }

        /// <summary>
        /// Tag for strong emphasis
        /// </summary>
        public string StrongEmphasisTag { get; set; }

        /// <summary>
        /// Tag for strong 
        /// </summary>
        public string StrongTag { get; set; }

        /// <summary>
        /// Tag for subscripts
        /// </summary>
        public string SubscriptTag { get; set; }

        /// <summary>
        /// Tag for superscripts
        /// </summary>
        public string SuperscriptTag { get; set; }

        /// <summary>
        /// Character for thematic breaks
        /// </summary>
        public char ThematicBreakCharacter { get; set; }
    }
}
