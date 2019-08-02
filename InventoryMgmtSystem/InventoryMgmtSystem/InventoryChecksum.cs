using System;
using System.Collections.Generic;

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
        public Repetitions Checksum(String[] boxIDs)
        {
            Repetitions repetitions = new Repetitions();

            for (int boxId = 0; boxId < boxIDs.Length; boxId++)
            {
                var idSummary = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

                for (int id = 0; id < boxIDs[boxId].Length; id++)
                {
                    var character = boxIDs[boxId][id].ToString();
                    if (idSummary.ContainsKey(character)) //if is duplicate
                    {
                        idSummary[character]++;
                    }
                    else
                    {
                        idSummary.Add(character, 1);
                    }
                }
                if (idSummary.ContainsValue(2))// if appears exactly twice 
                {
                    repetitions.idWithTwo += 1;
                }
                if (idSummary.ContainsValue(3))// if appears exactly three times
                {
                    repetitions.idWithThree += 1;
                }
            }
            return repetitions;
        }
        public struct Repetitions
        {
            public int idWithTwo;
            public int idWithThree;
        }
    }
}
