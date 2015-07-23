using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerfectBlog.Models
{
    public class User : BaseEntity
    {
        /*public bool IsMyBlog(Blog blog)
        {
            return blog.Owner == this;
        }*/
        #region Properties

        public virtual String Login { get; set; }
        public virtual String Password { get; set; }

        #endregion
        #region Variables

        private String password;

        #endregion
    }
}