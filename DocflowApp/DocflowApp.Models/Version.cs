using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocflowApp.Models
{
    public class Version
    {
        public virtual long Id{get; set;}

        public virtual Document Document { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual byte[] Contents { get; set; }
    }
}
