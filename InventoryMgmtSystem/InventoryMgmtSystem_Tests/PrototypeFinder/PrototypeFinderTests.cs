using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InventoryMgmtSystem_Tests.PrototypeFinder
{
    /// <summary>
    /// Summary description for PrototypeFinderTests
    /// </summary>
    [TestClass]
    public class PrototypeFinderTests
    {
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the response of the PrototypeFinder is not null
        /// </summary>
        [TestMethod]
        public void IsPrototypeFinderResponseNotNull()
        {
            //Arrange
            InventoryMgmtSystem.PrototypeFinder prototypeFinder = new InventoryMgmtSystem.PrototypeFinder();

            //Act
            String[] boxIDs = new string[7] { "abcdef", "bababc", "abbcde", "abcccd", "aabcdd", "abcdee", "ababab" };
            var PrototypeFinderResponse = prototypeFinder.GetBoxesWithSimilarId(boxIDs);

            //Assert
            Assert.IsNotNull(PrototypeFinderResponse);
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the response of the PrototypeFinder
        /// is equals to the expected value, which is 'fgij'
        /// </summary>
        [TestMethod]
        public void ResponseEqualToExpectedValue()
        {
            //Arrange
            InventoryMgmtSystem.PrototypeFinder prototypeFinder = new InventoryMgmtSystem.PrototypeFinder();

            //Act
            String[] boxIDs = new string[7] { "abcde", "fghij", "klmno", "pqrst", "fguij", "axcye", "wvxyz" };
            var PrototypeFinderResponse = prototypeFinder.GetBoxesWithSimilarId(boxIDs);

            //Assert
            Assert.AreEqual("fgij", PrototypeFinderResponse);
        }
    }
}
