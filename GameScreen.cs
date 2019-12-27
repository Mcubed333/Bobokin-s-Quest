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
            // load character image
            pictureBoxCharacter.Image = game.character.Portrait;

            displayText("Hello " + game.character.Title + ", welcome to Bobokin's Quest for the Salty Yoga Queen!\n");
            clearGameText();
            generateRandomEncounter();
            updateUI();
        }

        private void generateRandomEncounter()
        {
            clearGameText();
            buttonNewEncounter.Hide();
            game.getRandomEnemy();
            pictureBoxEnemy.Image = game.currentEnemy.Portrait;
            labelEnemy.Text = game.currentEnemy.Title;
            displayText("Oh no! A " + game.currentEnemy.Title + " has appeared!");
            displayText("What would you like to do?\n");
            updateUI();
        }

        private void updateUI()
        {
            labelCharacter.Text = game.character.Title;

            progressBarCharacterHealth.Minimum = 0;
            progressBarCharacterHealth.Maximum = game.character.MaxHealth;
            progressBarCharacterHealth.Value = game.character.Health;
            progressBarCharacterHealth.Refresh();
            labelCharacterHealthOutOfTotal.Text = game.character.Health + @"\" + game.character.MaxHealth;

            progressBarCharacterMana.Minimum = 0;
            progressBarCharacterMana.Maximum = game.character.MaxMana;
            progressBarCharacterMana.Value = game.character.Mana;
            progressBarCharacterMana.Refresh();
            labelCharacterManaOutOfTotal.Text = game.character.Mana + @"\" + game.character.MaxMana;

            labelCharacterGoldValue.Text = game.character.Gold.ToString();

            if (game.currentEnemy != null && game.currentEnemy.IsAlive)
            {
                labelEnemy.Text = game.currentEnemy.Title.ToString();
                progressBarEnemyHealth.Minimum = 0;
                progressBarEnemyHealth.Maximum = game.currentEnemy.MaxHealth;
                progressBarEnemyHealth.Value = game.currentEnemy.Health;
                progressBarEnemyHealth.Refresh();
                labelEnemyHealthOutOfTotal.Text = game.currentEnemy.Health+ @"\" + game.currentEnemy.MaxHealth;
            }
            else
            {
                labelEnemy.Text = string.Empty;
                progressBarEnemyHealth.Maximum = 1;
                progressBarEnemyHealth.Value = 0;
                pictureBoxEnemy.Image = null;
                labelEnemy.Text = String.Empty;
                progressBarEnemyHealth.Refresh();
            }
        }

        private void attackEnemy()
        {
            clearGameText();

            displayText(game.character.Title + " attacked the " + game.currentEnemy.Title + "!");

            int damageInflicted = game.character.Attack(game.currentEnemy);
            displayText("You have inflicted " + damageInflicted + " damage");
            Shake(damageInflicted);

            if (game.currentEnemy.IsAlive)
            {
                displayText(game.currentEnemy.Title + " attacked the " + game.character.Title + "!");
                displayText(game.currentEnemy.Title + " has inflicted " + game.currentEnemy.Attack(game.character) + " damage");
            }
            else
            {
                displayText(game.character.Title + " has defeated the " + game.currentEnemy.Title + ".");
                displayText(game.currentEnemy.Title + " has dropped " + game.currentEnemy.GoldRewarded + " gold and " + game.currentEnemy.ExperienceRewarded + " experience.");
                game.character.Gold += game.currentEnemy.GoldRewarded;
                game.character.Experience += game.currentEnemy.ExperienceRewarded;
                buttonNewEncounter.Show();

                game.currentEnemy = null;
                
            }


            updateUI();
        }

        private void displayText(string text)
        {
            DisableControls(this);
            if (textToDisplay == String.Empty)
                textTimer.Start();
            textToDisplay += text + "\n";
        }

        public void Shake(int amplitude)
        {
            var original = this.Location;
            var rnd = new Random(1337);
            int shake_amplitude = amplitude;
            for (int i = 0; i < amplitude*2; i++)
            {
                this.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            this.Location = original;
        }

        private void textTimer_Tick(object sender, EventArgs e)
        {
            if (textToDisplay != String.Empty)
            {
                richTextBoxGameText.Text += textToDisplay[0];
                textToDisplay = textToDisplay.Substring(1, textToDisplay.Length - 1);
            }
            else
            {
                EnableControls(this);
                textTimer.Stop();
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

        private void DisableControls(Form form)
        {
            foreach (Control c in form.Controls)
            {
                c.Enabled = false;
            }
        }

        private void EnableControls(Form form)
        {
            foreach (Control c in form.Controls)
            {
                c.Enabled = true;
            }
        }
        private void buttonAttack_Click(object sender, EventArgs e)
        {
            attackEnemy();
        }

        private void buttonNewEncounter_Click(object sender, EventArgs e)
        {
            generateRandomEncounter();
        }
    }
}
