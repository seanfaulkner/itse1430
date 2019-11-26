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
        public int Id { get; set; }
        public string Name
        {
        get { return _name ?? ""; }
        set { _name = value; }
        }
        public string Profession
        {
        get { return _profession ?? ""; }
        set { _profession = value; }
        }
        public string Race
        {
        get { return _race ?? ""; }
        set { _race = value; }
        }
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        public int Strength { get; set; } = 0;
        public int Intelligence { get; set; } = 0;
        public int Agility { get; set; } = 0;
        public int Constitution { get; set; } = 0;
        public int Charisma { get; set; } = 0;

        public override string ToString ()
        {
            return $"{Name}({Profession})";
        }
        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {

                return Enumerable.Empty<ValidationResult> ();
        }

        #region Private Members
        private string _name = "";
        private string _profession = "";
        private string _race = "";
        private string _description = "";
        #endregion
    }


}
