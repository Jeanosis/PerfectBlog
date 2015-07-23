using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerfectBlog.Models
{
    public class BaseEntity
    {
        public virtual Guid Id { get; protected set; }
    }
}