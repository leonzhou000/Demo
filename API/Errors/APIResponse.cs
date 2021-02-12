using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatueCode();
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatueCode()
        {
            return StatusCode switch
            {
                400 => "Bad Request",
                401 => "Not Authorized",
                404 => "Resource was not found",
                500 => "An Errors",
                _ => null
            };
        }
    }
}