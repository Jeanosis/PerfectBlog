using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerfectBlog.Models.Records
{
    public class Rating : BaseEntity
    {
        #region Properties

        public virtual bool Value { get; set; }
        public virtual User Owner { get; set; }
        public virtual BlogRecord Record { get; set; }

        #endregion
    }
}