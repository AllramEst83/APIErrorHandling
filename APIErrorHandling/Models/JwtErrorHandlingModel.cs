using System;
using System.Collections.Generic;
using System.Text;

namespace APIErrorHandling.Models
{
    public class JwtErrorHandlingModel
    {
        public string Auth_Token { get; set; }
        public string Code { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public int StatusCode { get; set; }
        public int Expires_In { get; set; }
    }
}
