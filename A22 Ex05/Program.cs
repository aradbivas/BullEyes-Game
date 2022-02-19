using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22_Ex05
{
    public class Program
    {
        public static void Main()
        {
            runGame();
        }

        private static void runGame()
        {
            ChooseSizeForm chooseSizeForm = new ChooseSizeForm();

            chooseSizeForm.ShowDialog();
            BullEyesBoardForm board = new BullEyesBoardForm(chooseSizeForm.NumberOfChances);

            board.ShowDialog();
        }
    }
}