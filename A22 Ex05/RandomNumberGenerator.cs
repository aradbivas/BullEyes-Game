using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22_Ex05
{
    public class RandomNumberGenerator
    {
        private readonly List<int> r_NumberList = new List<int>();
        private readonly Random r_Rnd = new Random();
        private readonly int r_Max;
        private readonly int r_Min;

        public RandomNumberGenerator(int i_Max, int i_Min)
        {
            this.r_Max = i_Max;
            this.r_Min = i_Min;
        }

        public List<int> CreateFourRandomNumbers()
        {
            for(int i = 0; i < 4; i++)
            {
                int randomNumber = r_Rnd.Next(r_Min, r_Max);

                while(r_NumberList.Contains(randomNumber))
                {
                    randomNumber = r_Rnd.Next(r_Min, r_Max);
                }

                r_NumberList.Add(randomNumber);
            }

            return r_NumberList;
        }
    }
}
