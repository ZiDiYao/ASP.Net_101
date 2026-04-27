using WebApplicationC__Tut101.Common.Enums;
namespace WebApplicationC__Tut101.Common
{
    // This class is used to standardize the API responses across the application. It can include properties like status code, message, and data.
    public class ApiResponse
    {
        public StatusCodeEnum StatusCode { get; set; }

        public string Message { get; set; } = string.Empty;

        public T? Date { get; set; }


    }
}
