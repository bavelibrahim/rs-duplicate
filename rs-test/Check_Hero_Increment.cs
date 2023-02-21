
using RsDuplicate;
using RsDuplicate.Hero;

namespace rs_test
{
    public class Check_Hero_Increment
    {

        // The LevelUp Function which is inside the Hero Class is used to increment the 
        // 3 values which represents the three stats: Strength, Dexterity and Intelligence.
        // The incrementation is different for each Hero Type. 
        
        [Fact]
        public void Mage_LevelUp()
        {
            HeroTemplate hero = new Mage("Gandalf");
            hero.LevelUp();

            HeroAttributes heroAttributes_AfterLeveLup = new HeroAttributes(2,2,13);

            Assert.Equivalent(heroAttributes_AfterLeveLup, hero.heroAttributes);
        }

        [Fact]
        public void Ranger_LevelUp()
        {
            HeroTemplate hero = new Ranger("Gandalf");
            hero.LevelUp();

            HeroAttributes heroAttributes_AfterLeveLup = new HeroAttributes(2, 12, 2);

            Assert.Equivalent(heroAttributes_AfterLeveLup, hero.heroAttributes);
        }

        [Fact]
        public void Rogue_LevelUp()
        {
            HeroTemplate hero = new Rogue("Gandalf");
            hero.LevelUp();

            HeroAttributes heroAttributes_AfterLeveLup = new HeroAttributes(3,10,2);

            Assert.Equivalent(heroAttributes_AfterLeveLup, hero.heroAttributes);
        }

        [Fact]
        public void Warrior_LevelUp()
        {
            HeroTemplate hero = new Warrior("Gandalf");
            hero.LevelUp();

            HeroAttributes heroAttributes_AfterLeveLup = new HeroAttributes(8,4,2);

            Assert.Equivalent(heroAttributes_AfterLeveLup, hero.heroAttributes);
        }

    }
}
