using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Composite
{
    public interface IComponent
    {
        IOperationResponse Operation(params IOperationArgument[] args);
    }
}
