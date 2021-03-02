using System;
using System.Collections.Generic;

namespace Laboratory
{
    public class Company
    {
        public int Id { get; set; }
        
        public string TitleOfCompany { get; set; }
        
        public List<Employee> Employees { get; set; }
    }
}