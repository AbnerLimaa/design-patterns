using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Builder
{
    public interface IBuilder
    {
        IBuilder AddItem(IBuilderItem item);

        IBuilderResult Build();
    }
}
