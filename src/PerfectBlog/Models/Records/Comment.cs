using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerfectBlog.Models.Records
{
    public class Comment : Record
    {
        #region Properties

        public virtual User Owner { get; set; }
        public virtual BlogRecord Record { get; set; }

        #endregion
    }
}