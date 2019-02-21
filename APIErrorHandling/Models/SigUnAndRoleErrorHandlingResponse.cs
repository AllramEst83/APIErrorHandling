using System;
using System.Collections.Generic;
using System.Text;

namespace APIErrorHandling.Models
{
    public class SigUnAndRoleErrorHandlingResponse
    {
        public int StatusCode { get; set; }
        public string Error { get; set; }
        public string Description { get; set; }
    }
}
