// <copyright file="PositionTest.cs" company="P.fm">Copyright ©  2018</copyright>
using System;
using CyberPushkin.model;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CyberPushkin.model.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для Position</summary>
    [PexClass(typeof(Position))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    public partial class PositionTest
    {
        public void IndexTest()
        {
            if (Assert.Equals(model.Position.addPossibleValue(1), null))
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void AboutTest()
        {
            Mock<model.Position> mPosition = new Mock<model.Position>();
            Assert.AreEqual(Position.getPossibleValues(), 1);
        }
    }
}
