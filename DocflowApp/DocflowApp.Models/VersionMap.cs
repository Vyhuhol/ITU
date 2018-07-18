using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace DocflowApp.Models
{
    public class VersionMap: ClassMap<Version>
    {
        public VersionMap()
        {
            Id(v => v.Id).GeneratedBy.Identity();
            References(v => v.Document).Not.Nullable().Cascade.SaveUpdate();
            Map(v => v.Date).Not.Nullable();
            Map(v => v.Contents).Not.Nullable();
        }
    }
}
