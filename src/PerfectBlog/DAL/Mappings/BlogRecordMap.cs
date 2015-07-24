using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using PerfectBlog.Models.Records;

namespace PerfectBlog.DAL.Mappings
{
    public class BlogRecordMap : ClassMapping<BlogRecord>
    {
        public BlogRecordMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));

            Property(x => x.Name, m => m.Length(255));
            Property(x => x.Value, m => m.Length(255));
            Property(x => x.CreationTime);

            ManyToOne(x => x.Blog, m =>
            {
                m.Column("BlogId");
                m.Cascade(Cascade.All);
                m.Lazy(LazyRelation.NoLazy);
            });

            Bag(x => x.Ratings, m =>
            {
                m.Key(k => k.Column("RecordId"));
                m.Cascade(Cascade.All);
                m.Lazy(CollectionLazy.NoLazy);
            }, r => r.OneToMany());

            Bag(x => x.Comments, m =>
            {
                m.Key(k => k.Column("RecordId"));
                m.Cascade(Cascade.All);
                m.Lazy(CollectionLazy.NoLazy);
            }, r => r.OneToMany());
        }
    }
}