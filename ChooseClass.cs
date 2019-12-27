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
    public partial class ChooseClass : Form
    {
        public ChooseClass()
        {
            InitializeComponent();
        }

        private void buttonChooseWarrior_Click(object sender, EventArgs e)
        {
            startGame(new Barbarian());
        }

        private void buttonChooseRogue_Click(object sender, EventArgs e)
        {
            startGame(new Rogue());
        }

        private void buttonChooseMage_Click(object sender, EventArgs e)
        {
            startGame(new Mage());
        }

        private void startGame(CharacterClass characterClass)
        {
            this.Hide();
            Game game = new Game(characterClass);
            GameScreen gameScreen = new GameScreen(game);
            gameScreen.ShowDialog();
            this.Close();
        }
    }
}
