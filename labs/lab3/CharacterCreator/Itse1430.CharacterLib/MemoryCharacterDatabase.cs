using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.CharacterLib
{
    public class MemoryCharacterDatabase : CharacterDatabase
    {
        protected override Character AddCore ( Character character )
        {
            character.Id = ++_id;

            var newCharacter = Clone (new Character (), character);
            _character.Add (newCharacter);

            return character;
        }

        protected override Character GetCore ( int id )
        {
            var character = FindCharacter (id);

            return character != null ? Clone (new Character (), character) : null;
        }
        protected override IEnumerable<Character> GetAllCore ()
        {
            return from c in _character
                   select Clone (new Character (), c);
        }
        protected override Character GetByNameCore ( string name )
        {
            return _character.FirstOrDefault (c => String.Compare (c.Name, name, true) == 0);
        }
        
        protected override void RemoveCore ( int id )
        {
            var character = FindCharacter (id);
            if (character != null)
                _character.Remove (character);
        }
        protected override Character UpdateCore ( int id, Character newCharacter )
        {
            var existing = FindCharacter (id);
            if (existing == null)
                throw new IOException ("Character not found");

            newCharacter.Id = id;
            Clone (existing, newCharacter);

            return newCharacter;
        }

        private Character Clone(Character target, Character source)
        {
            target.Id = source.Id;
            target.Description = source.Description;
            target.Agility = source.Agility;
            target.Charisma = source.Charisma;
            target.Constitution = source.Constitution;
            target.Intelligence = source.Intelligence;
            target.Name = source.Name;
            target.Profession = source.Profession;
            target.Race = source.Race;
            target.Strength = source.Strength;

            return target;
        }

        private Character FindCharacter(int id)
        {
            foreach (var character in _character)
                if (character.Id == id)
                    return character;

            return null;
        }

        private List<Character> _character = new List<Character> ();

        private int _id = 0;
    }
}
