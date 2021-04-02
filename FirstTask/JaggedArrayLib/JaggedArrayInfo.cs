using System;

namespace JaggedArrayLib
{
    public class JaggedArrayInfo
    {
        public int Ravnie { get; private set; }
        public int Uppers { get; private set; }
        public int Lowers { get; private set; }
        public int Lost { get; private set; }
        public JaggedArrayInfo(int[][] intarray)
        {
            Uppers = UpperStrings(intarray);
            Ravnie = RavnieStrings(intarray);
            Lowers = LowerStrings(intarray);
            Lost = intarray.Length - Uppers - Ravnie - Lowers;
        }


        int UpperStrings(int[][] intarray)
        {
            int result = 0;
            for (int i = 0; i < intarray.Length; i++)
            {
                bool status = true;
                for (int i2 = 1; i2 < intarray[i].Length; i2++)
                {

                    if (intarray[i][i2] > intarray[i][i2 - 1])
                    {
                        status = false;
                        break;
                    }
                }
                if (status)
                    result++;
            }
            return result;
        }
        int LowerStrings(int[][] intarray)
        {
            int result = 0;
            for (int i = 0; i < intarray.Length; i++)
            {
                bool status = true;
                for (int i2 = 1; i2 < intarray[i].Length; i2++)
                {
                    if (intarray[i][i2] < intarray[i][i2 - 1])
                    {
                        status = false;
                        break;
                    }
                }
                if (status)
                    result++;
            }
            return result;
        }
        int RavnieStrings(int[][] intarray)
        {
            int result = 0;
            for (int i = 0; i < intarray.Length; i++)
            {
                bool status = true;
                for (int i2 = 1; i2 < intarray[i].Length; i2++)
                {
                    if (intarray[i][i2] != intarray[i][i2 - 1])
                    {
                        status = false;
                        break;
                    }
                }
                if (status)
                    result++;
            }
            return result;
        }
    }
}
