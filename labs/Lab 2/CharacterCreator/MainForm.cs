using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();
            
        }

        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);

            //
        }

        private void ExitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Close ();
        }

        private void AboutToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            var form = new OnAboutBox ();
            form.ShowDialog (this);
        }

        private void NewToolStripMenuItem_Click ( object sender, EventArgs e )
        {         
            var form = new NewCharForm ();
            form.ShowDialog (this);
            form.Close ();
        }        

        public Character Add ( Character character ) // https://stackoverflow.com/questions/25137498/display-specified-text-for-listbox-items i think this listBox1 
        {
            ////Add to array
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index] == null)
                {
                    _characters[index] = character;                    
                    return character;
                }
            };
            return character;
        }
        private void ListBox1_SelectedIndexChanged ( object sender, EventArgs e ) //nope
        {
            GetAll();
        }
        public Character[] GetAll ()
        {
            ////Filter out empty characters
            //var count = 0;
            //foreach (var character in _characters)
            //    if (character != null)
            //        ++count;

            var index = 0;
            var characters = new Character[_characters.Length];
            foreach (var character in _characters)
                if (character != null)
                    characters[index++] = character;



            _lstCharacter.Items.Clear ();
            _lstCharacter.Items.AddRange (_characters.ToArray ());
            _lstCharacter.Items.Add (_characters.ToArray ());
            _lstCharacter.Show ();           //DisplayMember = "name";
            //still got nothin, idk where this statement goes, i feel like its not adding to the array for some reason
            //do we have it named right?
            // _characters is the array and character is an instance of Character even when i take the list away from the top it still doesnt display
            //try to do a message box for the array to make sure after we set it, that it's correct. how do i do that?

            return characters;
        }

        private List<Character> _characters = new List<Movie> ();

    }
}
