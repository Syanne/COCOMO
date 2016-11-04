using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using cocomo.Models.GroupModels;
using cocomo;

namespace cocomoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeserializationTest()
        {
            //arrange
            BasicLevelGroupModel model = new BasicLevelGroupModel();
            
            //act
            model.Indexes = Deserializer.Deserialize(model.Indexes);

            //assert
            Assert.AreEqual(model.Indexes.Length, 3);
        }
    }
}
