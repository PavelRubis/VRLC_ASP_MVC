using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteASP.Models
{
    public class PropertySearchRequest : Request
    {
        public string DebtorName { get; set; }
        public string DebtorRegistr { get; set; }
        public string DebtorBirthDate { get; set; }
        public string Spouse { get; set; }
    }
}