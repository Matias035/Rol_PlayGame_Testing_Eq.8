using NUnit.Framework;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class Test2
    {
        [Test]
        public void TestItemMagicStickDefensePower()
        {
            //Creamos Magia la cual tiene defensa. Y de los dos elementos por lo cuales se forma 
            //Magic Stick es el unico que contiene defensa. Por lo que el resultado deberia ser el mismo.
            Magic magic = new Magic();
            MagicStick magicStick = new MagicStick();
            int expected = magic.DefensePower;
            int actual = magicStick.DefensePower;
            Assert.AreEqual(expected, actual);
        }
    }
}