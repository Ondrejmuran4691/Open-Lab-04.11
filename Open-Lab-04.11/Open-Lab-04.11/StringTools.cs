using System;
using System.Linq;


namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {


            char[] done = str.ToArray();
            Array.Sort(done);
            string n = "";
                foreach (char c in done)
            {
                n += c.ToString();
            }
            return n;



        }
    }
}
