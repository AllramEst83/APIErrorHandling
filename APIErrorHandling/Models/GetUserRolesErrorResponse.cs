using System;
using System.Collections.Generic;
using System.Text;

namespace APIErrorHandling.Models
{
   public class GetUserRolesErrorResponse
    {
        public string Email { get; set; }
        public string UserId { get; set; }
        public List<string> Roles { get; set; }
        public int StatusCode { get; set; }
        public string Error { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
