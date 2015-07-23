using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using PerfectBlog.Models;

namespace PerfectBlog.DAL.Mappings
{
    public class UserMap : ClassMapping<User>
    {
        public UserMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));
            Property(x => x.Login);
            Property(x => x.Password);
        }
    }
}