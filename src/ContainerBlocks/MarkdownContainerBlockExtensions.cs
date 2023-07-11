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

using System;

namespace Enbrea.MdBuilder
{
    /// <summary>
    /// Extensions for <see cref="IMarkdownContainerBlock"/>
    /// </summary>
    public static class MarkdownContainerBlockExtensions
    {
        public static IMarkdownContainerBlock AppendAdmonition(this IMarkdownContainerBlock block, MarkdownAdmonitionType type, string theme, string title, Action<MarkdownAdmonition> action)
        {
            var admonition = new MarkdownAdmonition(type, theme, title);
            action(admonition);
            block.Append(admonition);
            return block;
        }

        public static IMarkdownContainerBlock AppendBlockQuote(this IMarkdownContainerBlock block, Action<MarkdownBlockQuote> action)
        {
            var blockQuote = new MarkdownBlockQuote();
            action(blockQuote);
            block.Append(blockQuote);
            return block;
        }

        public static IMarkdownContainerBlock AppendDefinitionList(this IMarkdownContainerBlock block, Action<MarkdownDefinitionList> action)
        {
            var list = new MarkdownDefinitionList();
            action(list);
            block.Append(list);
            return block;
        }

        public static IMarkdownContainerBlock AppendFencedCode(this IMarkdownContainerBlock block, string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var fencedCode = new MarkdownFencedCode(code);
                block.Append(fencedCode);
            }
            return block;
        }

        public static IMarkdownContainerBlock AppendFencedCode(this IMarkdownContainerBlock block, string language, string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var fencedCode = new MarkdownFencedCode(language, code);
                block.Append(fencedCode);
            }
            return block;
        }

        public static IMarkdownContainerBlock AppendHeading(this IMarkdownContainerBlock block, byte level, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var heading = new MarkdownHeading(level, text);
                block.Append(heading);
            }
            return block;
        }

        public static IMarkdownContainerBlock AppendHeading(this IMarkdownContainerBlock block, byte level, Action<MarkdownHeading> action)
        {
            var heading = new MarkdownHeading(level);
            action(heading);
            block.Append(heading);
            return block;
        }

        public static IMarkdownContainerBlock AppendIntendedCode(this IMarkdownContainerBlock block, string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var intendedCode = new MarkdownIntendedCode(code);
                block.Append(intendedCode);
            }
            return block;
        }

        public static IMarkdownContainerBlock AppendOrderedList(this IMarkdownContainerBlock block, Action<MarkdownOrderedList> action)
        {
            var list = new MarkdownOrderedList(1);
            action(list);
            block.Append(list);
            return block;
        }

        public static IMarkdownContainerBlock AppendOrderedList(this IMarkdownContainerBlock block, int start, Action<MarkdownOrderedList> action)
        {
            var list = new MarkdownOrderedList(start);
            action(list);
            block.Append(list);
            return block;
        }

        public static IMarkdownContainerBlock AppendParagraph(this IMarkdownContainerBlock block, string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var paragraph = new MarkdownParagraph(text);
                block.Append(paragraph);
            }
            return block;
        }

        public static IMarkdownContainerBlock AppendParagraph(this IMarkdownContainerBlock block, Action<MarkdownParagraph> action)
        {
            var paragraph = new MarkdownParagraph();
            action(paragraph);
            block.Append(paragraph);
            return block;
        }

        public static IMarkdownContainerBlock AppendRawBlock(this IMarkdownContainerBlock block, string rawText)
        {
            if (!string.IsNullOrEmpty(rawText))
            {
                var fencedCode = new MarkdownRawBlock(rawText);
                block.Append(fencedCode);
            }
            return block;
        }

        public static IMarkdownContainerBlock AppendTable(this IMarkdownContainerBlock block, Action<MarkdownTable> action)
        {
            var table = new MarkdownTable();
            action(table);
            block.Append(table);
            return block;
        }

        public static IMarkdownContainerBlock AppendTaskList(this IMarkdownContainerBlock block, Action<MarkdownTaskList> action)
        {
            var list = new MarkdownTaskList();
            action(list);
            block.Append(list);
            return block;
        }

        public static IMarkdownContainerBlock AppendThematicBreak(this IMarkdownContainerBlock block)
        {
            var fencedCode = new MarkdownThematicBreak();
            block.Append(fencedCode);
            return block;
        }

        public static IMarkdownContainerBlock AppendUnorderedList(this IMarkdownContainerBlock block, Action<MarkdownUnorderedList> action)
        {
            var list = new MarkdownUnorderedList();
            action(list);
            block.Append(list);
            return block;
        }
    }
}
