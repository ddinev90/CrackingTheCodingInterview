using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    internal class IsUnique
    {
        /// <summary>
        /// This would be a O(n^2) solution as toVerify has " n " symbols and 
        /// we have 2 nested loops iterating over the length so we multiply n*n = n^2
        /// </summary>
        /// <param name="toVerify"></param>
        /// <returns>
        /// True if no matches, False if there is a matching simbol
        /// </returns>
        public bool UniqueCheckerBruteForce(string toVerify)
        {
            for (int i = 0; i < toVerify.Length; i++)
            {
                for(int j = 1; j < toVerify.Length-1; j++)
                {
                    if (toVerify[i] == toVerify[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Because the search in a hashset is a constant operation of O(1) and we only iterate once over the whole
        /// string, it means that we have improved the algorithm significantly, reducing it to O(n)
        /// </summary>
        /// <param name="toVerify"></param>
        /// <returns></returns>
        public bool UniqueCheckerWithAdditionalStructure(string toVerify)
        {
            HashSet<int> unique = new HashSet<int>();
            for (int i = 0; i<toVerify.Length; i++)
            {
                if (!unique.Contains(toVerify[i]))
                {
                    unique.Add(toVerify[i]);
                }
                else { return false;}
            }
            return true;
        }

        public bool UniqueCheckWithoutAnyStructures(string toVerify)
        {

            return true;
        }
    }
}
