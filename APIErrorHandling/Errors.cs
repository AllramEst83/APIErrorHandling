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

        public static JwtErrorHandlingResponse ErrorResponse(JwtErrorHandlingModel model)
        {
            JwtErrorHandlingResponse jwtErrorResonse = new JwtErrorHandlingResponse
            {
                Auth_Token = model.Auth_Token,
                Code = model.Code,
                Id = model.Id,
                Description = model.Description,
                Expires_In = model.Expires_In,
                StatusCode = model.StatusCode
            };

            return jwtErrorResonse;
        }

        public static SigUnAndRoleErrorHandlingResponse SigInErrorResponse(SigUnAndRoleErrorHandlingResponse model)
        {
            SigUnAndRoleErrorHandlingResponse sigInErrorResonse = new SigUnAndRoleErrorHandlingResponse
            {
                Error = model.Error,
                Description = model.Description,
                StatusCode = model.StatusCode
            };

            return sigInErrorResonse;
        }

    }
}
