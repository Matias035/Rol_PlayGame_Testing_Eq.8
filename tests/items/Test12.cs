using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;
using System.Collections.Generic;

namespace RoleplayGame.Library.Test
{
    public class Test12
    {
        [Test]
        public void TestAddTwoItemToWizard()
        {
            // Creamos un Troll y un elemento Magic
            Troll troll = new Troll("name");
            Magic magic = new Magic();
            Magic magic1 = new Magic();
            troll.AddItem(magic);
            troll.AddItem(magic1);
            int expected = magic.AttackPower+magic1.AttackPower;
            int actual = troll.DefensePower;
            Assert.AreNotEqual(expected - magic.AttackPower, actual);
        }
    }
}