using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventoryMgmtSystem;

namespace InventoryMgmtSystem_Tests
{
    [TestClass]
    public class InventoryChecksumTests
    {
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the response of the inventoryChecksum is not null
        /// </summary>
        [TestMethod]
        public void IsChecksumNotNull()
        {
            //Arrange
            InventoryChecksum inventoryChecksum = new InventoryChecksum();

            //Act
            String[] boxIDs = new string[7] { "abcdef", "bababc", "abbcde", "abcccd", "aabcdd", "abcdee", "ababab" };
            var ChecksumResponse = inventoryChecksum.Checksum(boxIDs.ToList());

            //Assert
            Assert.IsNotNull(ChecksumResponse);
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the response of the inventoryChecksum is equals to 12
        /// </summary>
        [TestMethod]
        public void IsChecksumEqualsTo12()
        {
            //Arrange
            InventoryChecksum inventoryChecksum = new InventoryChecksum();

            //Act
            String[] boxIDs = new string[7] { "abcdef", "bababc", "abbcde", "abcccd", "aabcdd", "abcdee", "ababab" };
            //var idRep = inventoryChecksum.Checksum(boxIDs.ToList());
            int checksum = inventoryChecksum.Checksum(boxIDs.ToList());

            //Assert
            Assert.AreEqual(12, checksum);
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the response of the inventoryChecksum is equals to 6
        /// </summary>
        [TestMethod]
        public void IsChecksumEqualsTo6()
        {
            //Arrange
            InventoryChecksum inventoryChecksum = new InventoryChecksum();

            //Act
            String[] boxIDs = new string[6] { "abcdef", "abbcde", "abcccd", "aabcdd", "abcdee", "ababab" };
            var checksum = inventoryChecksum.Checksum(boxIDs.ToList());
            //int checksum = idRep.idWithTwo * idRep.idWithThree;
            
            //Assert
            Assert.AreEqual(6, checksum);
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the response of the inventoryChecksum is equals to 4
        /// </summary>
        [TestMethod]
        public void IsChecksumEqualsTo4()
        {
            //Arrange
            InventoryChecksum inventoryChecksum = new InventoryChecksum();

            //Act
            String[] boxIDs = new string[4] { "abcccd", "aabcdd", "abcdee", "ababab" };
            var checksum = inventoryChecksum.Checksum(boxIDs.ToList());
            //int checksum = idRep.idWithTwo * idRep.idWithThree;
            
            //Assert
            Assert.AreEqual(4, checksum);
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the response of the inventoryChecksum is equals to 16
        /// </summary>
        [TestMethod]
        public void IsChecksumEqualsTo16()
        {
            //Arrange
            InventoryChecksum inventoryChecksum = new InventoryChecksum();

            //Act
            String[] boxIDs = new string[6] { "aaabbb", "abbccc", "abbbcc", "abcdee", "abccdd", "abcccd" };
            var checksum = inventoryChecksum.Checksum(boxIDs.ToList());
            //int checksum = idRep.idWithTwo * idRep.idWithThree;

            //Assert
            Assert.AreEqual(16, checksum);
        }
    }
}

