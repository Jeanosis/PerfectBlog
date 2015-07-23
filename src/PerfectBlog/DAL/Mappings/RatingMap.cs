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
    public class RatingMap : ClassMapping<Rating>
    {
        public RatingMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));
            
            Property(x => x.Value);

            ManyToOne(x => x.Owner, m =>
            {
                m.Column("Owner");
                m.Cascade(Cascade.All);
                m.Lazy(LazyRelation.NoLazy);
            });

            ManyToOne(x => x.Record, m =>
            {
                m.Column("RecordId");
                m.Cascade(Cascade.All);
                m.Lazy(LazyRelation.NoLazy);
            });
        }
    }
}