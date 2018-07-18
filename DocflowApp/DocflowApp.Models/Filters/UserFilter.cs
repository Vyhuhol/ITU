using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocflowApp.Models.Filters
{
    public class UserFilter: BaseFilter
    {
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [Display(Name = "Дата")]
        public DateRange Date { get; set; }

        public long? Id { get; set; }
    }
}
