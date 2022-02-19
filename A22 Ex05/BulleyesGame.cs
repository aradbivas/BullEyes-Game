using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A22_Ex05;

namespace A22_Ex05
{
    public class BullEyesGame
    {
        private readonly RandomNumberGenerator r_LettersGenerator = new RandomNumberGenerator(8, 1);
        private readonly List<Color> r_FourRandomColors = new List<Color>();
        private readonly Dictionary<int, Color> r_ColorsDictionary = new Dictionary<int, Color>();
        private List<int> m_FourRandomNumbers = new List<int>();

        public BullEyesGame()
        {
            createColorsDictionary();
            CreateFourRandomColors();
        }

        private void createColorsDictionary()
        {
            r_ColorsDictionary.Add(1, Color.Brown);
            r_ColorsDictionary.Add(2, Color.White);
            r_ColorsDictionary.Add(3, Color.Yellow);
            r_ColorsDictionary.Add(4, Color.Green);
            r_ColorsDictionary.Add(5, Color.Blue);
            r_ColorsDictionary.Add(6, Color.Aqua);
            r_ColorsDictionary.Add(7, Color.Purple);
            r_ColorsDictionary.Add(8, Color.Red);
        }

        public List<Color> FourRandomColors
        {
            get
            {
                return r_FourRandomColors;
            }
        }

        internal List<Color> CreateFourRandomColors()
        {
            m_FourRandomNumbers = r_LettersGenerator.CreateFourRandomNumbers();
            for(int i = 0; i < m_FourRandomNumbers.Count; i++)
            {
                r_FourRandomColors.Add(r_ColorsDictionary[m_FourRandomNumbers[i]]);
            }

            return r_FourRandomColors;
        }

        internal int CheckIfLettersInRightPlace(List<Color> i_UserColors)
        {
            int vCounter = 0;

            for(int i = 0; i < i_UserColors.Count; i++)
            {
                if(i_UserColors[i] == FourRandomColors[i])
                {
                    vCounter++;
                }
            }

            return vCounter;
        }

        internal int CheckIfLettersAreEqual(List<Color> i_UserColors)
        {
            int xCounter = 0;

            for(int i = 0; i < i_UserColors.Count; i++)
            {
                for(int j = 0; j < m_FourRandomNumbers.Count; j++)
                {
                    if(i_UserColors[i] == FourRandomColors[j] && i != j)
                    {
                        xCounter++;
                        break;
                    }
                }
            }

            return xCounter;
        }

        internal string CheckGuess(List<Color> i_UserColors)
        {
            StringBuilder guessInVx = new StringBuilder();

            int lettersInTheRightPlace = CheckIfLettersInRightPlace(i_UserColors);
            int letterAreEqual = CheckIfLettersAreEqual(i_UserColors);

            guessInVx.Append('V', lettersInTheRightPlace);
            guessInVx.Append('X', letterAreEqual);

            return guessInVx.ToString();
        }
    }
}