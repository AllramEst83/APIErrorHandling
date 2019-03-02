using APIErrorHandling.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ResponseModels.ViewModels;

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

        public static DeleteUserErrorMessage DeleteUserErrorResponse(DeleteUserErrorMessage model)
        {
            DeleteUserErrorMessage deleteUserErrorResponse = new DeleteUserErrorMessage
            {
                Id = model.Id,
                Email = model.Email,
                Error = model.Error,
                Description = model.Description,
                StatusCode = model.StatusCode,
                Code = model.Code
            };

            return deleteUserErrorResponse;
        }

        public static SignUpAndRoleErrorHandlingResponse SigInErrorResponse(SignUpAndRoleErrorHandlingResponse model)
        {
            SignUpAndRoleErrorHandlingResponse sigInErrorResonse = new SignUpAndRoleErrorHandlingResponse
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

        public static AddRoleErrorResponse AddRoleErrorResponse(AddRoleErrorResponse model)
        {
            AddRoleErrorResponse addRoleErrorResonse = new AddRoleErrorResponse
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

        public static GetAllRolesResponse GetAllRolesErrorResponse(GetAllRolesResponse model)
        {
            GetAllRolesResponse addRoleErrorResonse = new GetAllRolesResponse
            {
                ListOfAllRoles = model.ListOfAllRoles,
                Description = model.Description,
                Error = model.Error,
                StatusCode = model.StatusCode,
                Code = model.Code
            };

            return addRoleErrorResonse;
        }

    }
}
