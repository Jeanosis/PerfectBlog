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
    public class BlogMap : ClassMapping<Blog>
    {
        public BlogMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));
            
            Property(x => x.Name, m => m.Length(255));

            ManyToOne(x => x.Owner, m =>
            {
                m.Column("Owner");
                m.Cascade(Cascade.All);
                m.Lazy(LazyRelation.NoLazy);
            });

            Bag(x => x.Records, m =>
            {
                m.Key(k => k.Column("BlogId"));
                m.Cascade(Cascade.All);
                m.Lazy(CollectionLazy.NoLazy);
            }, r => r.OneToMany());
        }
    }
}