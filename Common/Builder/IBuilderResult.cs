using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Builder
{
    public interface IBuilderResult
    {
        ICollection<IBuilderItem> Items { get; set; }
    }
}
