using System;
using System.Collections.Generic;
using System.Text;

namespace Gaia.Helpers.GenericResponse
{
    public class ErrorResponse : GenericResponse
    {
        public ErrorResponse()
        {
            this.Code = (int)ResponseCode.Unhandled;
        }

        public ErrorResponse(ResponseCode code)
        {
            this.Code = code;
        }

        public ErrorResponse(object data)
        {
            this.Data = data;
        }

        public ErrorResponse(ResponseCode code, object data)
            : this((ResponseCode)code)
        {
            this.Data = data;
        }
        public new bool Success { get; } = false;
    }
}
