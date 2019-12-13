using System;
using System.Drawing;
using System.Drawing.Text;
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
            clearGameText();
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
            labelCharacterTitleValue.Text = game.character.Title;

            progressBarCharacterHealth.Minimum = 0;
            progressBarCharacterHealth.Maximum = game.character.MaxHealth;
            progressBarCharacterHealth.Value = game.character.Health;
            progressBarCharacterHealth.Refresh();

            progressBarCharacterMana.Minimum = 0;
            progressBarCharacterMana.Maximum = game.character.MaxMana;
            progressBarCharacterMana.Value = game.character.Mana;
            progressBarCharacterMana.Refresh();

            if (game.currentEnemy != null && game.currentEnemy.IsAlive)
            {
                labelEnemyTitleValue.Text = game.currentEnemy.Title.ToString();
                progressBarEnemyHealth.Minimum = 0;
                progressBarEnemyHealth.Maximum = game.currentEnemy.MaxHealth;
                progressBarEnemyHealth.Value = game.currentEnemy.Health;
                progressBarEnemyHealth.Refresh();
            }
            else
            {
                labelEnemyTitleValue.Text = string.Empty;
                progressBarEnemyHealth.Maximum = 1;
                progressBarEnemyHealth.Value = 0;
                progressBarEnemyHealth.Refresh();
            }
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            clearGameText();

            displayText(game.character.Title + " attacked the " + game.currentEnemy.Title + "!");
            displayText("You have inflicted " + game.character.Attack(game.currentEnemy) + " damage");
            
            if (game.currentEnemy.IsAlive)
            {
                displayText(game.currentEnemy.Title + " attacked the " + game.character.Title + "!");
                displayText(game.currentEnemy.Title + " has inflicted " + game.currentEnemy.Attack(game.character) + " damage");
            }
            else
            {
                displayText(game.character.Title + " has defeated the " + game.currentEnemy.Title + ".");
                game.getRandomEnemy();
            }


            updateUI();
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

        private void richTextBoxGameText_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBoxGameText.SelectionStart = richTextBoxGameText.Text.Length;
            // scroll it automatically
            richTextBoxGameText.ScrollToCaret();
        }

        private void clearGameText()
        {
            richTextBoxGameText.Clear();
        }
    }
}
