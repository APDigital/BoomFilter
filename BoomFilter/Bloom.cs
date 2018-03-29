using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    public class Bloom
    {
        //number of hash functions to use
        const int m = 1000;
        const int k = 5;

        BitArray bloom = new BitArray(m);

        //gets hash code and returns a int array 
        private int[] hashk(string s, int k)
        {
            int[] hashes = new int[k];
            hashes[0] = Math.Abs(s.GetHashCode());
            Random R = new Random(hashes[0]);
            for (int i = 1; i < k; i++)
            {
                hashes[i] = R.Next();
            }
            return hashes;
        }
        // adds data, returns all locations indicated by the hash array set to 1
        public string AddData(string s)
        {
            string testresult = string.Empty;
            int[] hashes = hashk(s, k);
            for (int i = 0; i < k; i++)
            {
                bloom.Set(hashes[i] % m, true);
                testresult = "success";
            }
            return testresult;
        }
        // look up , looks up value to see if its already in the filter
        public Boolean LookUp(string s)
        {
            int[] hashes = hashk(s, k);
            for (int i = 0; i < k; i++)
            {
                if (bloom[hashes[i] % m] == false) return false;
            }
            return true;
        }
    }
}
