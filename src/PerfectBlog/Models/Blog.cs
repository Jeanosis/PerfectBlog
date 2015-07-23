using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PerfectBlog.Models.Records;

namespace PerfectBlog.Models
{
    public class Blog : BaseEntity
    {
        public virtual String Name { get; set; }
        public virtual User Owner { get; set; }
        public virtual IList<BlogRecord> Records { get; set; }
    }
}