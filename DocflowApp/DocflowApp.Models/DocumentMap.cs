using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace DocflowApp.Models
{
    public class DocumentMap: ClassMap<Document>
    {
        public DocumentMap()
        {
            Id(f => f.Id).GeneratedBy.Identity();
            Map(f => f.Date).Not.Nullable();
            Map(f => f.Name).Not.Nullable();
            References(f => f.Author).Not.Nullable().Cascade.SaveUpdate();
            References(d => d.Folder).Not.Nullable().Cascade.SaveUpdate();
        }
    }
}
