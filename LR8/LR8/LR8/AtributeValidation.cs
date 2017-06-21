using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LR8
{
    class AtributeValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string Name = value.ToString();
                if (!Name.StartsWith("A"))
                    return true;
                else
                    this.ErrorMessage = "Имя не должно начинаться с буквы A";
            }
            return false;
        }
    }
}
