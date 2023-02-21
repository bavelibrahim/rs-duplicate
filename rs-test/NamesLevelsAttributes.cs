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

            string expected_Results = "Gandalf the Purple";

            Assert.Equal(expected_Results, mage.Name);

        }

        [Fact]
        public void CreateMage_CorrectStartLevel()
        {

            Mage mage = new Mage("Gandalf the Purple");

            int expected_Results = 1;

            Assert.Equal(expected_Results, mage.Level);

        }

        [Fact]
        public void CreateRanger_CorrectName()
        {


            Ranger ranger = new Ranger("Robin Hood");

            string expected_Results = "Robin Hood";

            Assert.Equal(expected_Results, ranger.Name);

        }

        [Fact]
        public void CreateRanger_CorrectStartLevel()
        {

            Ranger ranger = new Ranger("Robin Hood");

            int expected_Results = 1;

            Assert.Equal(expected_Results, ranger.Level);
        }

        [Fact]
        public void CreateRogue_CorrectName()
        {

            Rogue rogue = new Rogue("Rogie");

            string expected_Results = "Rogie";

            Assert.Equal(expected_Results, rogue.Name);

        }

        [Fact]
        public void CreateRogue_CorrectStartLevel()
        {

            Rogue rogue = new Rogue("Rogie");

            int expected_Results = 1;

            Assert.Equal(expected_Results, rogue.Level);

        }

        [Fact]
        public void CreateWarrior_CorrectName()
        {

            Warrior warrior = new Warrior("Geralt");

            string expected_Results = "Geralt";

            Assert.Equal(expected_Results, warrior.Name);

        }

        [Fact]
        public void CreateWarrior_CorrectStartLevel()
        {

            Warrior warrior = new Warrior("Geralt");

            int expected_Results = 1;

            Assert.Equal(expected_Results, warrior.Level);

        }

        [Fact]
        public void CreateMage_CorrectStartAttributes()
        {
            Mage mage = new Mage("Gandalf");
            HeroAttributes heroAttributes = new(1, 1, 8);
            Assert.Equivalent(heroAttributes, mage.heroAttributes);
        }

        [Fact]
        public void CreateRanger_CorrectStartAttributes()
        {
            Ranger ranger = new Ranger("Gandalf");
            HeroAttributes heroAttributes = new(1, 7, 1);
            Assert.Equivalent(heroAttributes, ranger.heroAttributes);
        }
        [Fact]
        public void CreateRogue_CorrectStartAttributes()
        {
            Rogue rogue = new Rogue("Gandalf");
            HeroAttributes heroAttributes = new(2, 6, 1);
            Assert.Equivalent(heroAttributes, rogue.heroAttributes);
        }

        [Fact]
        public void CreateWarrior_CorrectStartAttributes()
        {
            Warrior warrior = new Warrior("Gandalf");
            HeroAttributes heroAttributes = new(5, 2, 1);
            Assert.Equivalent(heroAttributes, warrior.heroAttributes);
        }

    }
}