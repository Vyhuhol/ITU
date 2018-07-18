using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocflowApp.Models
{
    public class Document : Folder
    {
        public virtual Folder Folder { get; set; }
    }
}
