using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace APIErrorHandling
{
   public class CustomExceptionHandeling
    {
        public async Task<T> TryCatch<R, T>(Func<Task<T>> function) 
            where R : Exception
            where T : class, new()
        {
            try
            {
                return await function();
            }
            catch (R ex)
            {
                //Skriv till logfil här
                //https://github.com/NLog/NLog/wiki/Tutorial#best-practices-for-logging

                return await Task.FromResult(new T());

                //if (ex is ArgumentNullException)
                //{

                //}
            }
            catch (MissingMethodException ex)
            {
                return await Task.FromResult(new T());
            }
            //Last Exception in the order
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception thrown: {ex.Message}");

                throw new Exception(ex.Message);
            }
        }
    }
}
