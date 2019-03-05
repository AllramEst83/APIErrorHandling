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

        public static AddUserToRoleResponse AddUserToRoleErrorResponse(AddUserToRoleResponse model)
        {
            AddUserToRoleResponse AddUserTorRoleErrorResonse = new AddUserToRoleResponse
            {
                Error = model.Error,
                Description = model.Description,
                StatusCode = model.StatusCode,
                Email = model.Email,
                Code = model.Code
            };

            return AddUserTorRoleErrorResonse;
        }

        public static GetUserRolesResponse GetUserRolesErrorResponse(GetUserRolesResponse model)
        {
            GetUserRolesResponse AddUserTorRoleErrorResonse = new GetUserRolesResponse
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

        public static DeleteRoleResponse DeleteRoleErrorResponse(DeleteRoleResponse model)
        {
            DeleteRoleResponse AddUserTorRoleErrorResonse = new DeleteRoleResponse
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

        public static DeleteUserResponse DeleteUserErrorResponse(DeleteUserResponse model)
        {
            DeleteUserResponse deleteUserErrorResponse = new DeleteUserResponse
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

        public static AddRoleResponse AddRoleErrorResponse(AddRoleResponse model)
        {
            AddRoleResponse addRoleErrorResonse = new AddRoleResponse
            {
              Role = model.Role,
              Code = model.Code,
              Description = model.Description,
              Error = model.Error,
              StatusCode = model.StatusCode
            };

            return addRoleErrorResonse;
        }

        public static AddUserToRoleResponse RemoveRoleFromUserErrorResponse(AddUserToRoleResponse model)
        {
            AddUserToRoleResponse addRoleErrorResonse = new AddUserToRoleResponse
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
