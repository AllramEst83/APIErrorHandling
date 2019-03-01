﻿using System;
using System.Collections.Generic;
using System.Text;

namespace APIErrorHandling.Models
{
   public class GetAllRolesErrorResponse
    {
        public List<object> ListOfAllRoles { get; set; }
        public int StatusCode { get; set; }
        public string Error { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
