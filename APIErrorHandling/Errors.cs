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

        public static AddUserToRoleErrorResponse AddUserToRoleErrorResponse(AddUserToRoleErrorResponse model)
        {
            AddUserToRoleErrorResponse AddUserTorRoleErrorResonse = new AddUserToRoleErrorResponse
            {
                Error = model.Error,
                Description = model.Description,
                StatusCode = model.StatusCode,
                Email = model.Email,
                Code = model.Code
            };

            return AddUserTorRoleErrorResonse;
        }

        public static GetUserRolesErrorResponse GetUserRolesErrorResponse(GetUserRolesErrorResponse model)
        {
            GetUserRolesErrorResponse AddUserTorRoleErrorResonse = new GetUserRolesErrorResponse
            {
                Error = model.Error,
                Description = model.Description,
                StatusCode = model.StatusCode,
                Code = model.Code,
                Roles = model.Roles,
                UserId = model.UserId,
                Email = model.Email
            };

            return AddUserTorRoleErrorResonse;
        }

        public static DeleteRoleErrorResponse DeleteRoleErrorResponse(DeleteRoleErrorResponse model)
        {
            DeleteRoleErrorResponse AddUserTorRoleErrorResonse = new DeleteRoleErrorResponse
            {
                RoleName = model.RoleName,
                RoleId = model.RoleId,
                Error = model.Error,
                Description = model.Description,
                StatusCode = model.StatusCode,
                Code = model.Code
            };

            return AddUserTorRoleErrorResonse;
        }

        public static SigUnAndRoleErrorHandlingResponse SigInErrorResponse(SigUnAndRoleErrorHandlingResponse model)
        {
            SigUnAndRoleErrorHandlingResponse sigInErrorResonse = new SigUnAndRoleErrorHandlingResponse
            {
                Error = model.Error,
                Description = model.Description,
                StatusCode = model.StatusCode,
                Email = model.Email,
                Id = model.Id,
                Code = model.Code
            };

            return sigInErrorResonse;
        }

        public static GatewayAddRoleResponse AddRoleErrorResponse(GatewayAddRoleResponse model)
        {
            GatewayAddRoleResponse addRoleErrorResonse = new GatewayAddRoleResponse
            {
              Role = model.Role,
              Code = model.Code,
              Description = model.Description,
              Error = model.Error,
              StatusCode = model.StatusCode
            };

            return addRoleErrorResonse;
        }

        public static RemoveUserfromRoleErrorHAndelingResponse RemoveRoleFromUserErrorResponse(RemoveUserfromRoleErrorHAndelingResponse model)
        {
            RemoveUserfromRoleErrorHAndelingResponse addRoleErrorResonse = new RemoveUserfromRoleErrorHAndelingResponse
            {
                Role = model.Role,
                Email = model.Email,
                UserId = model.UserId,
                Code = model.Code,
                Description = model.Description,
                Error = model.Error,
                StatusCode = model.StatusCode
            };

            return addRoleErrorResonse;
        }

    }
}
