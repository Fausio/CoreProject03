using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject03.Models
{
    public class Band
    {
        [Display(Name ="The name of music")]
        public string Title { get; set; }

        [Display(Name = "The name of origin")]
        public string Origin { get; set; }

        [Display(Name = "The name of gender")]
        public string Gender { get; set; }

        [Display(Name = "Biography")]
        public string Biography { get; set; }
    }
}
