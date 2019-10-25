using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class Test8
    {
        [Test]
        public void WhenAddingMagicToACharacterItsDefenseGoesUp()
        {
            Elf elfo = new Elf("Eduardo");
            Magic magia = new Magic();
            elfo.AddItem(magia);
            int expectedDefense = 32;
            Assert.AreEqual(elfo.DefensePower, expectedDefense);
        }
        
    }
}