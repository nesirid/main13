﻿using Practice_Interface_Services.Models;
using Practice_Interface_Services.Services;

namespace Practice_Interface_Services.Helpers.Responses
{
    public class EmployeeResponse
    {
        public Employee Employee { get; set; }
        public string ErrorMessage { get; set; }
    }
}
