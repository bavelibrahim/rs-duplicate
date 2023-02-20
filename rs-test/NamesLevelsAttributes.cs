using RsDuplicate.Hero;
using RsDuplicate.Equipment;
using RsDuplicate.Utilities;
using RsDuplicate;

namespace rs_test
{
    public class NamesLevelsAttributes
    {

        [Fact]
        public void CreateMage_CorrectName()
        {

            Mage mage = new Mage("Gandalf the Purple");
            Assert.Equal("Gandalf the Purple", mage.Name);

        }

        [Fact]
        public void CreateMage_CorrectStartLevel()
        {

            Mage mage = new Mage("Gandalf the Purple");
            Assert.Equal(1 , mage.Level);

        }

        [Fact]
        public void CreateRanger_CorrectName()
        {


            Ranger ranger = new Ranger("Robin Hood");
            Assert.Equal("Robin Hood", ranger.Name);

        }

        [Fact]
        public void CreateRanger_CorrectStartLevel()
        {

            Ranger ranger = new Ranger("Robin Hood");
            Assert.Equal(1, ranger.Level);
        }

        [Fact]
        public void CreateRogue_CorrectName()
        {

            Rogue rogue = new Rogue("Rogie");
            Assert.Equal("Rogie", rogue.Name);

        }

        [Fact]
        public void CreateRogue_CorrectStartLevel()
        {

            Rogue rogue = new Rogue("Rogie");
            Assert.Equal( 1, rogue.Level);

        }

        [Fact]
        public void CreateWarrior_CorrectName()
        {

            Warrior warrior = new Warrior("Geralt");
            Assert.Equal("Geralt", warrior.Name);

        }

        [Fact]
        public void CreateWarrior_CorrectStartLevel()
        {

            Warrior warrior = new Warrior("Geralt");
            Assert.Equal(1, warrior.Level);

        }

        [Fact]
        public void CreateMage_CorrectStartAttributes()
        {
            Mage mage = new Mage("Gandalf");
            HeroAttributes heroAttributes = new(1, 1, 8);
            Assert.Equivalent(mage.heroAttributes, heroAttributes);
        }

        [Fact]
        public void CreateRanger_CorrectStartAttributes()
        {
            Ranger ranger = new Ranger("Gandalf");
            HeroAttributes heroAttributes = new(1, 7, 1);
            Assert.Equivalent(ranger.heroAttributes, heroAttributes);
        }
        [Fact]
        public void CreateRogue_CorrectStartAttributes()
        {
            Rogue rogue = new Rogue("Gandalf");
            HeroAttributes heroAttributes = new(2, 6, 1);
            Assert.Equivalent(rogue.heroAttributes, heroAttributes);
        }

        [Fact]
        public void CreateWarrior_CorrectStartAttributes()
        {
            Warrior warrior = new Warrior("Gandalf");
            HeroAttributes heroAttributes = new(5, 2, 1);
            Assert.Equivalent(warrior.heroAttributes, heroAttributes);
        }

    }
}