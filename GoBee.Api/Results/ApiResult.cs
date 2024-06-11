using GoBee.Api.Results;

namespace GobeeApi.Domain.DTO
{
    public class ApiResponse<T>
    {
        public ErrorCode ErrorCode { get; set; }
        public bool Success { get; set; }
        public T? Body { get; set; }

        public static ApiResponse<T> BuildSuccess(T body)
        {
            return new ApiResponse<T> { Body = body, Success = true, ErrorCode = 0 };
        }

        public static ApiResponse<T> BuildFailure(ErrorCode errorCode)
        {
            return new ApiResponse<T> { Success = false, ErrorCode = errorCode };
        }
    }
}
