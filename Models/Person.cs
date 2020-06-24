using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteASP.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Job { get; set; }
        public string PhotoName { get; set; }
        public string Description { get; set; }
    }
}