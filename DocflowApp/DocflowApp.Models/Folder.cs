using System;
using System.ComponentModel.DataAnnotations;

namespace DocflowApp.Models
{
    public class Folder
    {
        public virtual long Id { get; set; }

        [Display(Name = "Название")]
        public virtual string Name { get; set; }

        public virtual User Author { get; set; }

        [Display(Name = "Корневая Папка")]
        public virtual Folder Root { get; set; }

        [Display(Name = "Дата создания")]
        public virtual DateTime Date { get; set; }
    }
}
