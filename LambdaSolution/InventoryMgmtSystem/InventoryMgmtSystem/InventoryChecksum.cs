using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryMgmtSystem
{
    public class InventoryChecksum
    {
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This program was created to solve the "Day 2: Inventory Management System" challenge.
        /// </summary>
        /// <param name="boxIDs"></param>
        /// <returns>Repetitions</returns>
        public int Checksum(List<String> boxIDs)
        {
            return boxIDs.Count(id => id.GroupBy(c => c).Any(group => group.Count() == 2))*
                          boxIDs.Count(id => id.GroupBy(c => c).Any(group=> group.Count()==3 ));
        }
    }
}
