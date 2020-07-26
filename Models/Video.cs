using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteASP.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime UploadDate { get; set; }
    }
}