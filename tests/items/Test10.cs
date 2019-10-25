using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class Test10
    {
        [Test]
        public void RemoveMagicItem()
        {
            Elf Elfo = new Elf("Elfito");
            Magic Magia = new Magic();
            Elfo.AddItem(Magia);
            int DefensaConMagia = Elfo.DefensePower;
            Elfo.RemoveItem(Magia);
            int DefensaSinMagia = Elfo.DefensePower;
            Assert.AreEqual(DefensaConMagia - Magia.DefensePower, DefensaSinMagia);
        }
    }
}