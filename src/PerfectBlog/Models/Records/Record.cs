using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerfectBlog.Models.Records
{
    public class Record : BaseEntity
    {
        public Record()
        {
            CreationTime = DateTime.Now;
        }
        #region Properties

        public virtual String Value { get; set; }
        public virtual DateTime CreationTime { get; protected set; }

        #endregion
    }
}