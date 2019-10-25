using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class Test7
    {
        [Test]
        public void WhenAddingMagicToACharacterItsAttackPowerGoesUp()
        {
            Elf elfo = new Elf("Eduardo");
            Magic magia = new Magic();
            elfo.AddItem(magia);
            int expectedAttackPower = 80;
            Assert.AreEqual(elfo.AttackPower, expectedAttackPower);
        }
    }
}