﻿

using FirstMVCDemo.Models;
namespace FirstMVCDemo.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public Employee Employee { get; set; }
        public Address Address { get; set; }
        public string PageTitle { get; set; }
        public string PageHeader { get; set; }
    }
}
