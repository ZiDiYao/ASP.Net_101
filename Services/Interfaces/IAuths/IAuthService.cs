using WebApplicationC__Tut101.Common;
using WebApplicationC__Tut101.DTOs.Requests;
using WebApplicationC__Tut101.DTOs.Responses;

namespace WebApplicationC__Tut101.Services.Interfaces.IAuths
{
    public interface IAuthService
    {
        Task<ApiResponse<UserSignupResponseDto>> Signup(UserSignupRequestDto request);

        Task<ApiResponse<UserSigninResponseDto>> Signin(UserSigninRequestDto request);
    }
}