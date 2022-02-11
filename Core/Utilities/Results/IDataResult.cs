using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public interface IDataResul<T>:IResult
    {
        T Data { get; }
    }
}
