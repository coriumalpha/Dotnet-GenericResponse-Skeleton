using System;
using System.Collections.Generic;
using System.Text;

namespace Gaia.Helpers.GenericResponse
{
    public abstract class GenericResponse : IGenericResponse
    {
        public bool Success { get; set; }
        public ResponseCode? Code { get; set; }
        public object Data { get; set; }
    }
}
