using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace RaishasBooks.Models
{
    public class CoverType
    {
        public int Id { get; set; }

        [Display(Name = "CoverType Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
