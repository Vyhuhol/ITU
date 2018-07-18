using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocflowApp.Models.Filters
{
    public class DocumentFilter: BaseFilter
    {
        public virtual string Name { get; set; }

        public virtual User Author { get; set; }

        public DateRange Date { get; set; }
    }
}
