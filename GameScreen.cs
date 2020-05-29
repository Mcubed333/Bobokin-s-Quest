using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using TestProject.Battles;

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

            textTimer = new Timer();
            textTimer.Interval = 20;
            textTimer.Tick += new System.EventHandler(textTimer_Tick);
            textTimer.Start();
            // load character image
            pictureBoxCharacter.Image = game.Character.Portrait;
            buttonExitGame.Hide();

            displayText("Hello " + game.Character.Title + ", welcome to Bobokin's Quest for the Salty Yoga Queen!\n");
            clearGameText();
            generateRandomEncounter();
            updateUI();
        }

        private void generateRandomEncounter()
        {
            game.GetRandomEnemy();
            game.IsInBattle = true;
            displayText("Oh no! A " + game.CurrentEnemy.Title + " has appeared!");
            displayText("What would you like to do?\n");
            startEncounter();
        }

        private void startEncounter()
        {
            clearGameText();
            buttonNewEncounter.Hide();
            pictureBoxEncounter.Image = game.CurrentEnemy.Portrait;
            labelEncounter.Text = game.CurrentEnemy.Title;
            updateUI();
        }

        private void updateUI()
        {
            labelCharacter.Text = game.Character.Title + " Lvl " + game.Character.Level;

            progressBarCharacterHealth.Minimum = 0;
            progressBarCharacterHealth.Maximum = game.Character.MaxHealth;
            progressBarCharacterHealth.Value = game.Character.Health;
            progressBarCharacterHealth.Refresh();
            labelCharacterHealthOutOfTotal.Text = game.Character.Health + @"\" + game.Character.MaxHealth;

            progressBarCharacterMana.Minimum = 0;
            progressBarCharacterMana.Maximum = game.Character.MaxMana;
            progressBarCharacterMana.Value = game.Character.Mana;
            progressBarCharacterMana.Refresh();
            labelCharacterManaOutOfTotal.Text = game.Character.Mana + @"\" + game.Character.MaxMana;

            labelCharacterGoldValue.Text = game.Character.Gold.ToString();

            if (game.CurrentEnemy != null && game.CurrentEnemy.IsAlive)
            {
                labelEnemyHealthOutOfTotal.Show();
                labelEnemyHealth.Show();
                progressBarEnemyHealth.Show();

                labelEncounter.Text = game.CurrentEnemy.Title.ToString();
                progressBarEnemyHealth.Minimum = 0;
                progressBarEnemyHealth.Maximum = game.CurrentEnemy.MaxHealth;
                progressBarEnemyHealth.Value = game.CurrentEnemy.Health;
                progressBarEnemyHealth.Refresh();
                labelEnemyHealthOutOfTotal.Text = game.CurrentEnemy.Health+ @"\" + game.CurrentEnemy.MaxHealth;
            }
            else
            {
                labelEnemyHealthOutOfTotal.Hide();
                labelEnemyHealth.Hide();
                progressBarEnemyHealth.Hide();

                labelEncounter.Text = string.Empty;
                labelEnemyHealthOutOfTotal.Text = string.Empty;
                progressBarEnemyHealth.Maximum = 1;
                progressBarEnemyHealth.Value = 0;
                pictureBoxEncounter.Image = null;
                labelEncounter.Text = String.Empty;
                progressBarEnemyHealth.Refresh();
            }

            if (game.IsInBattle)
            {
                buttonRest.Hide();
                buttonFindMerchant.Hide();
                buttonNewEncounter.Hide();

                buttonAttack.Show();
                buttonCast.Show();
                buttonRun.Show();
            }
            else
            {
                buttonNewEncounter.Show();
                buttonRest.Show();
                buttonFindMerchant.Show();

                buttonAttack.Hide();
                buttonCast.Hide();
                buttonRun.Hide();
            }

            progressBarCharacterExperience.Minimum = 0;
            progressBarCharacterExperience.Maximum = game.Character.TotalExperienceToNextLevel;
            progressBarCharacterExperience.Value = game.Character.Experience;
            labelExperienceText.Text = game.Character.Experience + " / " + game.Character.TotalExperienceToNextLevel + " experience";
        }

        private void attackEnemy()
        {
            clearGameText();

            displayText(game.Character.Title + " attacked the " + game.CurrentEnemy.Title + "!");

            Damage damage = game.Character.Attack(game.CurrentEnemy);
            if (damage.IsCrit)
            {
                displayText("You unleash a devastating blow, dealing " + damage.DamageInflicted + " damage");
            }
            else
            {
                displayText("You have inflicted " + damage.DamageInflicted + " damage");
            }
            
            Shake(damage.DamageInflicted);

            updateUI();
        }

        private void enemyAttacksCharacter()
        {
            if (game.CurrentEnemy.IsAlive && game.Character.IsAlive)
            {
                Damage damage = game.CurrentEnemy.Attack(game.Character);
                
                displayText(game.CurrentEnemy.Title + " attacked the " + game.Character.Title + "!");
                if (damage.IsCrit)
                {
                    displayText(game.CurrentEnemy.Title + " unleashes a devastating blow, dealing " + damage.DamageInflicted + " damage");
                }
                else
                {
                    displayText(game.CurrentEnemy.Title + " has inflicted " + damage.DamageInflicted + " damage");
                }

                Shake(damage.DamageInflicted);

                if (!game.Character.IsAlive)
                {
                    displayText("\n" + game.CurrentEnemy.Title + " has defeated you!");
                    displayText(game.Character.Title + " blacks out...");

                    buttonExitGame.Show();

                    pictureBoxCharacter.Image = null;
                    game.Character.Health = 0;
                    game.Character.Mana = 0;
                }
                
            }
            else if (game.Character.IsAlive)
            {
                game.IsInBattle = false;
                displayText(game.Character.Title + " has defeated the " + game.CurrentEnemy.Title + ".");
                displayText(game.CurrentEnemy.Title + " has dropped " + game.CurrentEnemy.GoldRewarded + " gold and " + game.CurrentEnemy.ExperienceRewarded + " experience. \n");
                game.Character.Gold += game.CurrentEnemy.GoldRewarded;
                if (game.AddExperience(game.CurrentEnemy.ExperienceRewarded))
                {
                    levelUp();
                }
                buttonNewEncounter.Show();

                game.CurrentEnemy = null;

            }

            updateUI();
        }

        private void levelUp()
        {
            displayText("Congratulations! You are now level " + game.Character.Level + "!");

            LevelUp levelUp = new LevelUp(game.Character);
            levelUp.ShowDialog();
        }

        private void displayText(string text)
        {
            DisableControls(this);
            if (textToDisplay == String.Empty)
            {
                textTimer.Start();
            }
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

            enemyAttacksCharacter();
        }

        private void buttonNewEncounter_Click(object sender, EventArgs e)
        {
            generateRandomEncounter();
        }

        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            StaticFunctions.ChangeScreens(this, new Menu());
        }

        private void buttonFindMerchant_Click(object sender, EventArgs e)
        {
            pictureBoxEncounter.Image = game.Merchant.Portrait;
            labelEncounter.Text = game.Merchant.Title;

            displayText("Welcome to my shop " + game.Character.Title + "!");
            displayText("What would you like to do?");
        }

        private void buttonRest_Click(object sender, EventArgs e)
        {
            pictureBoxEncounter.Image = null;
            labelEncounter.Text = "";

            game.Rest();
            if (game.CurrentEnemy != null)
            {
                displayText("Oh no! You were awoken by a " + game.CurrentEnemy.Title);
                displayText("What would you like to do?");
                startEncounter();
            }
            else
            {
                displayText("Your rest was undisturbed.");
            }

            updateUI();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (game.CurrentEnemy != null)
            {
                if (game.RunFromFight())
                {
                    displayText("You ran away successfully...");
                }
                else
                {
                    displayText("You can't escape!"); 
                    enemyAttacksCharacter();
                }
            }

            updateUI();
        }
    }
}
