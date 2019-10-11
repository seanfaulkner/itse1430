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

        public List<Character> characterarray = new List<Character> ();
        public MainForm ()
        {
            InitializeComponent ();
            
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
        }

        private void ListBox1_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        
    }
}
