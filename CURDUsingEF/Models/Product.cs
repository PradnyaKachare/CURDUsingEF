using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CURDUsingEF.Models
{
    [Table("Productt")]
    public class Product
    {   
       [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company Name is Required")]
        [Display(Name="Company Name")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        public int Price { get; set; }


    }
}
