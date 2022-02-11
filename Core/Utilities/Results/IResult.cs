using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başangıc
    public interface IResult
    {
        bool Success { get; }  // get sadece okunabilir,set yazmak  demektir.
        string Message { get; }
    }
}
