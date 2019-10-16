using BattleShipStateTracker.Services;
using BattleShipStateTracker.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using BattleShipStateTracker.Domain;
using BattleShipStateTracker.Domain.Boards;

namespace BattleShipStateTracker.Tests
{
    [TestClass]
    public class StateTrackerServiceTest
    {

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameBoardAndProcessShots_Test_Zero_Cordinates_Throws_Exception()
        {
            var mockGameBoardHelper = new Mock<IGameBoardHelper>();
            var panel = new List<Panel>();
            panel.Add(new Panel(0, 0, Domain.Enums.AttackerType.Battleship));
            var game = new Game
            {
                Player1 = new Player("Player1")
                {
                    GameBoard = new Domain.Boards.GameBoard { Panels = panel }
                }
            };
            mockGameBoardHelper.Setup(c => c.PlaceShipsForGame()).Returns(game);
            var service = new StateTrackerService(mockGameBoardHelper.Object);
            var result = service.CreateGameBoardAndProcessShots(10, 10);

        }

        [TestMethod]
        public void CreateGameBoardAndProcessShots_Test_Returns_Miss()
        {
            var mockGameBoardHelper = new Mock<IGameBoardHelper>();
            var panel = new List<Panel>();
            panel.Add(new Panel(10, 10));
            var game = new Game
            {
                Player1 = new Player("Player1")
                {
                    GameBoard = new Domain.Boards.GameBoard { Panels = panel }
                }
            };
            mockGameBoardHelper.Setup(c => c.PlaceShipsForGame()).Returns(game);
            var service = new StateTrackerService(mockGameBoardHelper.Object);
            var result = service.CreateGameBoardAndProcessShots(10, 10);
            Assert.AreEqual(result, Domain.Enums.ShotResult.Miss);
        }

        [TestMethod]
        public void CreateGameBoardAndProcessShots_Test_Returns_Hit()
        {
            var mockGameBoardHelper = new Mock<IGameBoardHelper>();
            var panel = new List<Panel>();
            panel.Add(new Panel(10, 10, Domain.Enums.AttackerType.Battleship));
            var game = new Game
            {
                Player1 = new Player("Player1")
                {
                    GameBoard = new Domain.Boards.GameBoard { Panels = panel }
                }
            };
            mockGameBoardHelper.Setup(c => c.PlaceShipsForGame()).Returns(game);
            var service = new StateTrackerService(mockGameBoardHelper.Object);
            var result = service.CreateGameBoardAndProcessShots(10, 10);
            Assert.AreEqual(result, Domain.Enums.ShotResult.Hit);
        }      
    }
}
