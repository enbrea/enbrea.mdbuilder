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

namespace Enbrea.MdBuilder.Tests
{
    /// <summary>
    /// Extensions for <see cref="IMarkdownContainerBlock"/>
    /// </summary>
    public static class MyContainerBlockExtensions
    {
        public static IMarkdownContainerBlock AppendCollapsedSection(this IMarkdownContainerBlock block, string summary, Action<MyCollapsedSection> action)
        {
            var collapsedSection = new MyCollapsedSection(summary);
            action(collapsedSection);
            block.Append(collapsedSection);
            return block;
        }
    }
}
