using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Composite
{
    public interface IComponent
    {
        IOperationResponse Operation(Func<ICollection<IComponent>, IOperationArgument[], IOperationResponse> func, params IOperationArgument[] list);
    }
}
