using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HeroMonsterClasses1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
                hero.Name = "Acis";
                hero.Health = 200;
                hero.DamageMax = 20;
                hero.AttackBonus = true;

            Character monster = new Character();
                monster.Name = "Polyphemus";
                monster.Health = 125;
                monster.DamageMax = 50;
                monster.AttackBonus = false;

            int damage = hero.Attack();
            //LabelBattleResults.Text += hero.Name + " damage: " + damage + ", ";
            monster.Defend(damage);

            damage = monster.Attack();
            //LabelBattleResults.Text += monster.Name + " damage: " + damage;
            hero.Defend(damage);

            showBattle(hero);
            showBattle(monster);
        }


        private void showBattle(Character character)
        {
            LabelBattleResults.Text += String.Format("<p>Name: {0} <br />Health: {1} <br />Damage Max: {2} <br />Attack Bonus: {3}</p>",
                character.Name,
                character.Health,
                character.DamageMax.ToString(),
                character.AttackBonus.ToString());
        }


        class Character 
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMax { get; set; }
            public bool AttackBonus { get; set; }

            public int Attack()
            {
                Random rnd = new Random();
                int damage = rnd.Next(this.DamageMax);
                return damage;
            }

            public void Defend(int damage)
            {
                this.Health -= damage;
            }
        }


        



    }
}