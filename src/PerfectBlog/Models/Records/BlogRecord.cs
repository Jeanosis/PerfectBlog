using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerfectBlog.Models.Records
{
    public class BlogRecord : Record
    {
        #region Properties

        public virtual Blog Blog { get; set; }
        public virtual IList<Rating> Ratings { get; set; }
        public virtual IList<Comment> Comments { get; set; }

        #endregion
    }
}