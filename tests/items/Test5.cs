using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class Test5
    {
        [Test]
        public void TestCreateWizzarAssignItemAndProveHealt()
        {
            // Creamos un Wizzard y un elemento Magic
            Wizard wizard = new Wizard("name");
            Magic magic = new Magic();
            //Miramos si el objeto esperado es igual al objeto actual en Wizard
            object expected = magic.GetType();
            object actual = wizard.Items.GetType();
            Assert.AreEqual(expected, actual);
            //Ahora comprobamos que la vida del personaje es 80
            int expectedHealt =  80;
            int actualHealt = wizard.Health;
            Assert.AreEqual(expectedHealt,actualHealt);
        }
    }
}