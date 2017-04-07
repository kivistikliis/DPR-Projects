using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week4FactoryPattern;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateFigure()
        {
            //checks if the created figure and factory match
            GenericGame game = new GenericGame();

            //test if factory creates a new minion
            MinionFactory minionFac = new MinionFactory();
            game.setFactory(minionFac);
            IFigure figMin = game.createFig("test minion");
            Assert.AreEqual(figMin.GetType(), typeof(Minion));

            //test if factory creates a new smurf
            SmurfFactory smurfFac = new SmurfFactory();
            game.setFactory(smurfFac);
            IFigure figSmur = game.createFig("test smurf");
            Assert.AreEqual(figSmur.GetType(), typeof(Smurf));
        }

        [TestMethod]
        public void TestCreateHouse()
        {
            //checks if the factory creates correct house
            GenericGame game = new GenericGame();

            //test if factory creates a new minionhouse
            MinionFactory minionFac = new MinionFactory();
            game.setFactory(minionFac);
            IHouse houseMin = game.createHouse();
            Assert.AreEqual(houseMin.GetType(), typeof(MinionHouse));

            //test if factory creates a new smurfhouse
            SmurfFactory smurfFac = new SmurfFactory();
            game.setFactory(smurfFac);
            IHouse houseSmur = game.createHouse();
            Assert.AreEqual(houseSmur.GetType(), typeof(SmurfHouse));
        }

        [TestMethod]
        public void TestCheckFigureName()
        {
            //checks if the created figures have assigned name
            GenericGame game = new GenericGame();
            MinionFactory minionFac = new MinionFactory();
            game.setFactory(minionFac);

            IFigure figMin1 = game.createFig("test1");
            Assert.AreEqual(((Minion)figMin1).Name, "test1");

            IFigure figMin2 = game.createFig("test2");
            Assert.AreEqual(((Minion)figMin2).Name, "test2");
        }

        [TestMethod]
        public void TestRepairHouse()
        {
            //checks if repairing house works - tested with minionhouse
            GenericGame game = new GenericGame();

            //test if factory creates a new minionhouse
            MinionFactory minionFac = new MinionFactory();
            game.setFactory(minionFac);

            //create a new house and get the house number of it
            IHouse houseMin = game.createHouse();
            int housenr = houseMin.GetHouseNr();
            string result;

            //initially boolean for broken is true, so house should be fixable
            result = game.FixHouse(houseMin);
            Assert.AreEqual(result, "Minion house " + housenr + " is now fixed");

            //now house is already fixed, so with the next try it should not fix it anymore
            result = game.FixHouse(houseMin);
            Assert.AreEqual(result, "Minion house " + housenr + " is already fixed!");
        }

        [TestMethod]
        public void TestMeasureHouse()
        {
            //checks if measuring house works - tested with minionhouse
            GenericGame game = new GenericGame();

            //test if factory creates a new minionhouse
            MinionFactory minionFac = new MinionFactory();
            game.setFactory(minionFac);

            //create a new house and get the house number of it
            IHouse houseMin = game.createHouse();
            int housenr = houseMin.GetHouseNr();

            //size for minionhouse is 100+housenr
            game.GetHouseSize(houseMin);
            Assert.AreEqual(housenr+100, houseMin.GetSize());
        }

        [TestMethod]
        public void TestFigureActions()
        {
            //checks if the created figures sing and dance properly
            GenericGame game = new GenericGame();

            MinionFactory minionFac = new MinionFactory();
            game.setFactory(minionFac);
            IFigure figMin = game.createFig("testMin");
            Assert.AreEqual("testMin is singing for minions", game.sing(figMin));
            Assert.AreEqual("testMin is dancing minion dance, huuulaaa!!!", game.dance(figMin));


            SmurfFactory smurfFac = new SmurfFactory();
            game.setFactory(smurfFac);
            IFigure figSmurf = game.createFig("testSmurf");
            Assert.AreEqual("testSmurf is singing a smurfsong", game.sing(figSmurf));
            Assert.AreEqual("testSmurf is dancing smurf dance!", game.dance(figSmurf));

        }
    }
}
