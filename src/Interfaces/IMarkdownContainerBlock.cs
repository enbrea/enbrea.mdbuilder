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
    public interface IMarkdownContainerBlock : IMarkdownBlock
    {
        void Append(params IMarkdownBlock[] blockElements);
        void Clear();
    }
}
