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

            // Creating Mage type and giving the hero a name

            Mage mage = new Mage("Gandalf the Purple");
            Assert.Equal("Gandalf the Purple", mage.Name);

        }

        [Fact]
        public void CreateRanger_CorrectName()
        {

            // Creating Mage type and giving the hero a name

            Ranger ranger = new Ranger("Robin Hood");
            Assert.Equal("Robin Hood", ranger.Name);

        }

        [Fact]
        public void CreateRogue_CorrectName()
        {

            // Creating Mage type and giving the hero a name

            Rogue rogue = new Rogue("Rogie");
            Assert.Equal("Rogie", rogue.Name);

        }

        [Fact]
        public void CreateWarrior_CorrectName()
        {

            // Creating Mage type and giving the hero a name

            Warrior warrior = new Warrior("Geralt");
            Assert.Equal("Geralt", warrior.Name);

        }



    }
}