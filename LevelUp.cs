using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class LevelUp : Form
    {
        CharacterClass character;
        public LevelUp(CharacterClass character)
        {
            InitializeComponent();
            labelError.Text = String.Empty;
            this.character = character;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (radioButtonStrength.Checked)
            {
                character.Strength += 1;
                this.Close();
            }
            else if (radioButtonVitality.Checked)
            {
                character.Vitality += 1;
                this.Close();
            }
            else if (radioButtonIntellect.Checked)
            {
                character.Intellect += 1;
                this.Close();
            }
            else if (radioButtonDexterity.Checked)
            {
                character.Dexterity += 1;
                this.Close();
            }
            else
                labelError.Text = "Please select a stat to increase";
        }
    }
}
