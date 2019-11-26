using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.CharacterLib
{
    public class Character : IValidatableObject
    {
        public string Name
        {
           
        }

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {

            return Enumerable.Empty<ValidationResult> ();
        }
    }
}
