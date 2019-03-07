using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ResponseModels.ViewModels;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;

namespace APIErrorHandling
{
    public static class Errors
    {
        //AddErrorsToModelState
        public static ModelStateDictionary AddErrorsToModelState(IdentityResult identityResult, ModelStateDictionary modelState)
        {
            foreach (var e in identityResult.Errors)
            {
                modelState.TryAddModelError(e.Code, e.Description);
            }

            return modelState;
        }

        //AddErrorToModelState
        public static ModelStateDictionary AddErrorToModelState(string code, string description, ModelStateDictionary modelState)
        {
            modelState.TryAddModelError(code, description);
            return modelState;
        }

        //GetGenericErrorResponse
        public static async Task<T> GetGenericErrorResponse<T>(T model)
        {
            Type objectType = model.GetType();
            PropertyInfo[] objectProperties = objectType.GetProperties();

            object[] args = new object[objectProperties.Length];

            for (int i = 0; i < objectProperties.Length; i++)
            {
                string propertyName = objectProperties[i].Name;
                PropertyInfo valueInfo = objectType.GetProperty(propertyName);

                args[i] = valueInfo.GetValue(model);
            }

            Type t = typeof(T);

            return await Task.FromResult((T)Activator.CreateInstance(t, args));
        }
    }
}
