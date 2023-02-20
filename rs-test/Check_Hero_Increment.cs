﻿
using RsDuplicate;
using RsDuplicate.Hero;

namespace rs_test
{
    public class Check_Hero_Increment
    {

        [Fact]
        public void Mage_LevelUp()
        {
            HeroTemplate hero = new Mage("Gandalf");
            hero.LevelUp();

            HeroAttributes heroAttributes_AfterLeveLup = new HeroAttributes(2,2,13);

            Assert.Equivalent(hero.heroAttributes, heroAttributes_AfterLeveLup);
        }

        [Fact]
        public void Ranger_LevelUp()
        {
            HeroTemplate hero = new Ranger("Gandalf");
            hero.LevelUp();

            HeroAttributes heroAttributes_AfterLeveLup = new HeroAttributes(2, 12, 2);

            Assert.Equivalent(hero.heroAttributes, heroAttributes_AfterLeveLup);
        }

        [Fact]
        public void Rogue_LevelUp()
        {
            HeroTemplate hero = new Rogue("Gandalf");
            hero.LevelUp();

            HeroAttributes heroAttributes_AfterLeveLup = new HeroAttributes(3,10,2);

            Assert.Equivalent(hero.heroAttributes, heroAttributes_AfterLeveLup);
        }

        [Fact]
        public void Warrior_LevelUp()
        {
            HeroTemplate hero = new Warrior("Gandalf");
            hero.LevelUp();

            HeroAttributes heroAttributes_AfterLeveLup = new HeroAttributes(8,4,2);

            Assert.Equivalent(hero.heroAttributes, heroAttributes_AfterLeveLup);
        }

    }
}
