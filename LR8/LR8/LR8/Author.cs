using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LR8
{
    [Serializable]
  public  class Author
    {
        [Required]

        [StringLength(10, MinimumLength = 2)]
        public string name { get; set; }

        [StringLength(10, MinimumLength = 2)]
        public string surname { get; set; }

        [Range(15, 100)]
        public int yearsOld { get; set; }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Surname
        {
            set
            {
                surname = value;
            }

            get
            {
                return surname;
            }
        }
        public int  YO
        {
            set
            {
                yearsOld = value;
            }

            get
            {
                return yearsOld;
            }
        }

    }
}
