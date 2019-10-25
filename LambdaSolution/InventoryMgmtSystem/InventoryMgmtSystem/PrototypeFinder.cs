using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryMgmtSystem
{
    public class PrototypeFinder
    {
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This method is in charge of get the boxes that contains similar IDs
        /// </summary>
        /// <param name="boxIDs"></param>
        /// <returns></returns>
        public string GetBoxesWithSimilarId(List<String> boxIDs)
        {
            for (int i = 0; i < boxIDs[0].Length; i++)
            {
                var commonIds = boxIDs.Select(id => id.Remove(i, 1)).GroupBy(id => id).FirstOrDefault(group => group.Count() > 1);
                if (commonIds != null)
                {
                    return commonIds.First();
                }
            }

            return null;
        }
    }
}
