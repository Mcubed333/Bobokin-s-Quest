using System;
using System.Windows.Forms;

namespace TestProject
{
    public partial class GameScreen : Form
    {
        private Game game;
        private string textToDisplay;
        Timer textTimer = new Timer();

        public GameScreen(Game game)
        {
            InitializeComponent();
            this.game = game;
            Timer textTimer = new Timer();
            textTimer.Interval = 35;
            textTimer.Tick += new System.EventHandler(textTimer_Tick);
            textTimer.Start();


            displayText("Hello " + game.character.Title + ", welcome to the game!\n");
            generateRandomEncounter();
            updateUI();
        }

        private void generateRandomEncounter()
        {
            game.getRandomEnemy();
            displayText("Oh no! A " + game.currentEnemy.Title + " has appeared!");
            displayText("What would you like to do?\n");
            updateUI();
        }

        private void updateUI()
        {
            this.textBoxCharacterTitle.Text = game.character.Title;
            this.textBoxCharacterHealth.Text = game.character.Health.ToString();
            this.textBoxCharacterMana.Text = game.character.Mana.ToString();
            if (game.currentEnemy != null)
            {
                this.textBoxEnemyTitle.Text = game.currentEnemy.Title.ToString();
                this.textBoxEnemyHealth.Text = game.currentEnemy.Health.ToString();
            }
        }

        private void displayText(string text)
        {
            textToDisplay += text + "\n";
        }

        private void textTimer_Tick(object sender, EventArgs e)
        {
            if (textToDisplay != String.Empty)
            {
                richTextBoxGameText.Text += textToDisplay[0];
                textToDisplay = textToDisplay.Substring(1, textToDisplay.Length - 1);
            }
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            displayText(game.character.Title + " attacked the " + game.currentEnemy.Title + "!");
            displayText("You have inflicted " + game.character.Attack(game.currentEnemy) + " damage");
            
            if (game.currentEnemy.IsAlive)
            {
                displayText(game.currentEnemy.Title + " attacked the " + game.character.Title + "!");
                displayText(game.currentEnemy.Title + " has inflicted " + game.currentEnemy.Attack(game.character) + " damage");
            }

            updateUI();
        }

        private void richTextBoxGameText_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBoxGameText.SelectionStart = richTextBoxGameText.Text.Length;
            // scroll it automatically
            richTextBoxGameText.ScrollToCaret();
        }
    }
}
