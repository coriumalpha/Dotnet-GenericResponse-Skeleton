using System;
using System.Collections.Generic;
using System.Text;

namespace Gaia.Helpers.GenericResponse
{
    public interface IGenericResponse
    {
        bool Success { get; set; }
        ResponseCode? Code { get; set; }
        object Data { get; set; }
    }
}
