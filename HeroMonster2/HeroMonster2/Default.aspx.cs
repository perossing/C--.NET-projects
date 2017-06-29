using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HeroMonster2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character()
            {
                Name = "Acis",
                Health = 200,
                MaxAttackForce = 25,
                AttackBonus = true
            };

            Character monster = new Character()
            {
                Name = "Polyphemus",
                Health = 125,
                MaxAttackForce = 45,
                AttackBonus = false
            };

            Dice dice = new Dice();

            showPlayerInfo(hero);
            showPlayerInfo(monster);

            applyBonus(hero, monster, dice);

            while (hero.Health > 0 && monster.Health > 0)
            {
                doBattle(hero, monster, dice);
                doBattle(monster, hero, dice);
            }

            showFinalScore(hero, monster);
        }


        private void showPlayerInfo(Character character)
        {
            LabelGameIntro.Text += String.Format("Player: {0}  | Starting Health: {1} | Damage Max: {2} | Attack Bonus: {3}<br />",
                character.Name,
                character.Health,
                character.MaxAttackForce.ToString(),
                character.AttackBonus.ToString());
        }


        private void doBattle (Character attacker, Character defender, Dice dice)
        {
            int attackForce = 0;
            attackForce = attacker.Attack(dice);
            defender.Defend(attackForce);
            showAttack(attacker, attackForce);
            showDamage(defender);
        }


        private void applyBonus(Character player1, Character player2, Dice dice)
        {
            if (player1.AttackBonus)
            {
                LabelBattleResults.Text = "BONUS ATTACK: ";
                doBattle(player1, player2, dice);
            }
            if (player2.AttackBonus)
            {
                LabelBattleResults.Text += "BONUS ATTACK: ";
                doBattle(player2, player1, dice);
            }
        }


        private void showAttack(Character character, int attackForce)
        {
            LabelBattleResults.Text += String.Format("{0} attacks with damage of {1}<br />",
            character.Name,
            attackForce);
        }


        private void showDamage(Character character)
        {
            LabelBattleResults.Text += String.Format("&nbsp&nbsp&nbsp&nbsp&nbsp{0} health =  {1}<br />",
                character.Name,
                character.Health);            
        }


        private void showFinalScore(Character player1, Character player2)
        {
            if (player1.Health <= 0 && player2.Health <= 0)
                LabelBattleResults.Text += String.Format("<p>Both {0} and {1} died.", player1.Name, player2.Name);
            else if (player1.Health <= 0)
                LabelBattleResults.Text += String.Format("<p>{0} defeats {1}</p>", player2.Name, player1.Name);
            else
                LabelBattleResults.Text += String.Format("<p>{0} defeats {1}</p>", player1.Name, player2.Name);
        }


        class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int MaxAttackForce { get; set; }
            public bool AttackBonus { get; set; }
            
            public int Attack(Dice dice)
            {
                dice.Sides = this.MaxAttackForce;
                return dice.Roll();
            }

            public void Defend(int damageTaken)
            {
                this.Health -= damageTaken;   
            }
        }

        class Dice
        { 
            public int Sides { get; set; }
            Random rndm = new Random();

            public int Roll()
            {
                return rndm.Next(this.Sides);
            }
        }
    }
}