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
    public partial class NewCharForm : Form
    {
        private Character[] _characters = new Character[100];


        string name, profession, race, description;
        decimal attributes, strength, intelligence, agility, constitution, charisma;


        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        public NewCharForm()
        {
            InitializeComponent();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e) //This button is the save click
        {
            name = Name.Text;
            profession = comboBoxProfession.Text;
            race = comboBoxRace.Text;
            description = Description.Text;
            strength = Strength.Value;
            intelligence = Intelligence.Value;
            agility = Agility.Value;
            constitution = Constitution.Value;
            charisma = Charisma.Value;

            if (name == "")
            {
                MessageBox.Show("Your Name is Blank", "Error");
            }
            else if (race == "")
            {
                MessageBox.Show("Your Race is Blank", "Error");
            }
            else if (profession == "")
            {
                MessageBox.Show("Your Profession is Blank", "Error");
            }
            else
            {
                List<Character>characterarray.Add(name, profession, race, description, strength, intelligence, agility, constitution, charisma);
                DialogResult = DialogResult.OK;
                Close();
            }
        } // end of save button       
    }
}