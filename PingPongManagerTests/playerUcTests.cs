using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongManager.Tests
{
    [TestClass()]
    public class playerUcTests
    {
        [TestMethod()]
        public void addPlayerTest()
        {
            playerUc puc = new playerUc();

            Player p1 = new Player();
            p1.name = "Armando";
            p1.surname = "Fernandez";

            Player p2 = new Player();
            p1.name = "Raimundo";
            p1.surname = "Mas";

            puc.playersList.Add(p1);
            puc.playersList.Add(p2);

            Assert.IsTrue(puc.playersList.Count==2);
        }
    }
}