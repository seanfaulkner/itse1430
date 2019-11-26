using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itse1430.CharacterLib;

namespace CharacterCreator
{
    public partial class MainForm : Form
    {
        private Character[] _characters = new Character[100];

        public List<Character> character = new List<Character> ();
        public Character Character { get; set; }
        public MainForm ()
        {
            InitializeComponent ();
            Character character = new Character ();
            character.Name = "";
            character.Description = character.Name;
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {

            var character = GetSelectedCharacter ();
            if (character == null)
                return;

            var form = new CharacterForm ();
            form.Character = character;

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                RemoveCharacter (character);
                AddCharacter (form.Character);
                UpdateUI ();
            }
        }



        private Character GetSelectedCharacter ()
        {
            var item = _lstCharacters.SelectedItem;
            return item as Character;
        }

        private void UpdateUI ()
        {
            var characters = GetCharacters ();

            _lstCharacters.Items.Clear ();
            _lstCharacters.Items.AddRange (characters);
        }

        private void AddCharacter ( Character character )
        {
            for (var i = 0; i < _characters.Length; ++i)
            {
                if (_characters[i] == null)
                {
                    _characters[i] = character;
                    return;
                };
            };
        }

        private void RemoveCharacter ( Character character )
        {
            for (var i = 0; i < _characters.Length; ++i)
            {
                if (_characters[i] == character)
                {
                    _characters[i] = null;
                    return;
                }
            }
        }

        private Character[] GetCharacters ()
        {
            var count = 0;
            foreach (var character in _characters)
                if (character != null)
                    ++count;

            var i = 0;
            var characters = new Character[count];
            foreach (var character in _characters)
                if (character != null)
                    characters[i++] = character;

            return characters;
        }

        private void OnCharacterAdd ( object sender, EventArgs e )
        {

            var form = new CharacterForm ();

            if (form.ShowDialog (this) == DialogResult.OK)
                AddCharacter (form.Character);
            UpdateUI ();
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {

            var menuItem = sender as Button;

            var text = "";
            if (menuItem != null)
                text = menuItem.Text;
            else
                text = "";

            var text2 = (menuItem != null) ? menuItem.Text : "";

            var text3 = menuItem?.Text ?? "";
            var character = GetSelectedCharacter ();
            if (character == null)
                return;

            var msg = $"Are you sure you want to delete {character.Name}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            RemoveCharacter (character);
            UpdateUI ();
        }
    }
}
