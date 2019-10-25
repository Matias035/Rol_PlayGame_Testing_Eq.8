using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;
using System.Collections.Generic;

namespace RoleplayGame.Library.Test
{
    public class Test9
    {
        [Test]
        public void TestQuitItemToWizard()
        {
            // Creamos un Troll y un elemento Magic
            Troll troll = new Troll("name");
            Magic magic = new Magic();
            troll.AddItem(magic);
            int expected = troll.AttackPower;
            //Quitamos el objeto Magic en Troll
            troll.RemoveItem(magic);
            int actual = troll.AttackPower;
            Assert.AreNotEqual(expected - magic.AttackPower, actual);
            
        }
    }
}