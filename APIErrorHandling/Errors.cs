using APIErrorHandling.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace APIErrorHandling
{
    public static class Errors
    {
        public static ModelStateDictionary AddErrorsToModelState(IdentityResult identityResult, ModelStateDictionary modelState)
        {
            foreach (var e in identityResult.Errors)
            {
                modelState.TryAddModelError(e.Code, e.Description);
            }

            return modelState;
        }

        public static ModelStateDictionary AddErrorToModelState(string code, string description, ModelStateDictionary modelState)
        {
            modelState.TryAddModelError(code, description);
            return modelState;
        }

        public static JwtErrorHandlingResponse JwtLogInErrorResponse()
        {
            JwtErrorHandlingResponse jwtErrorResonse = new JwtErrorHandlingResponse
            {
                Auth_Token = "",
                Code = "login_failure",
                Id = "",
                Description = "Invalid username or password.",
                Expires_In = 0,
                StatusCode = 400
            };

            return jwtErrorResonse;
        }

    }
}
