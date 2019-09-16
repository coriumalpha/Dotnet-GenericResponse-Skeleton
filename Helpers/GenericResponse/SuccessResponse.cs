using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.GenericResponse
{
    public class SuccessResponse : GenericResponse
    {
        public SuccessResponse()
        {
        }

        public SuccessResponse(ResponseCode code)
        {
            this.Code = code;
        }

        public SuccessResponse(object data)
        {
            this.Data = data;
        }

        public SuccessResponse(int code, object data)
            : this(code)
        {
            this.Data = data;
        }

        public bool Success { get; } = true;
    }
}
