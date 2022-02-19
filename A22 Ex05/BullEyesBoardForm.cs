using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A22_Ex05
{
    public partial class BullEyesBoardForm : Form
    {
        private const int k_Space = 42;
        private const int k_ResultDownSpace = 18;
        private const int k_ResultTopSpace = 42;
        private const int k_ResultWidth = 24;
        private const int k_ResultHeight = 18;
        private const int k_ArrowWidth = 55;
        private const int k_ArrowHeight = 25;
        private const int k_SelectWidth = 36;
        private const int k_SelectHeight = 36;
        private readonly Point r_ArrowPointLocation = new Point(180, 85);
        private readonly Point r_SelectPointLocation = new Point(12, 74);
        private readonly Point r_ResultTopLeft = new Point(260, 74);
        private readonly Point r_ResultTopRight = new Point(290, 74);
        private readonly List<Button> r_ArrowButtonList = new List<Button>();
        private readonly Button[,] r_ResultButtonMatrix;
        private readonly BullEyesGame r_BullEyesGame;
        private readonly Button[,] r_SelectColorButtonMatrix;
        private readonly int r_NumberOfRows;
        private int m_ButtonSelectColorNumber = 0;
        private int m_ArrowRowNumber = 0;
        private int m_ButtonResultNumber = 0;

        public BullEyesBoardForm(int i_NumberOfRows)
        {
            InitializeComponent();
            r_ResultButtonMatrix = new Button[i_NumberOfRows, 4];
            r_SelectColorButtonMatrix = new Button[i_NumberOfRows, 4];
            r_BullEyesGame = new BullEyesGame();
            createNumberOfRow(i_NumberOfRows);
            r_NumberOfRows = i_NumberOfRows;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void createNumberOfRow(int i_NumberOfRows)
        {
            for(int i = 0; i < i_NumberOfRows; i++)
            {
                createSelectColorRow(i);
                createArrowButton(i);
                createResultButton(i);
            }
        }

        private void createArrowButton(int i_Space)
        {
            Button arrow = new Button();

            arrow.Name = m_ArrowRowNumber++.ToString();
            arrow.Size = new Size(k_ArrowWidth, k_ArrowHeight);
            arrow.Text = "-->>";
            arrow.Location = r_ArrowPointLocation;
            arrow.Top = arrow.Top + (k_Space * i_Space);
            arrow.Enabled = false;
            arrow.Click += buttonArrow_Click;
            this.Controls.Add(arrow);
            r_ArrowButtonList.Add(arrow);
        }

        private void createSelectColorRow(int i_SpaceRow)
        {
            int rowsNumber;
            int columnsNumber;

            for(int i = 0; i < 4; i++)
            {
                Button selectColor = new Button();

                selectColor.Size = new Size(k_SelectWidth, k_SelectHeight);
                selectColor.Name = "button" + m_ButtonSelectColorNumber.ToString();
                selectColor.Location = r_SelectPointLocation;
                selectColor.Top = selectColor.Top + (k_Space * i_SpaceRow);
                selectColor.Left = selectColor.Left + (k_Space * i);
                selectColor.Click += SelectColor_Click;
                if(i_SpaceRow != 0)
                {
                    selectColor.Enabled = false;
                }

                rowsNumber = findButtonLocationRows(m_ButtonSelectColorNumber);
                columnsNumber = findButtonLocationColumns(m_ButtonSelectColorNumber++);
                r_SelectColorButtonMatrix[rowsNumber, columnsNumber] = selectColor;
                this.Controls.Add(selectColor);
            }
        }

        private void SelectColor_Click(object i_Sender, EventArgs i_Event)
        {
            Color buttColor = getColorFromForm();
            Button button = i_Sender as Button;

            button.BackColor = buttColor;
            string name = button.Name;
            string stringNumber = new string(name.Where(char.IsDigit).ToArray());
            int number = int.Parse(stringNumber.ToString());
            int rowsNumber = findButtonLocationRows(number);
            int columnsNumber = findButtonLocationColumns(number);

            r_SelectColorButtonMatrix[rowsNumber, columnsNumber] = button;
            if(checkIfAllButtonInRowAreFilled(rowsNumber))
            {
                if(!checkIfColorDoesNotAppearMoreThenOnce(rowsNumber))
                {
                    arrowButtonEnabler(rowsNumber, true);
                }
                else
                {
                    arrowButtonEnabler(rowsNumber, false);
                }
            }
            else
            {
                arrowButtonEnabler(rowsNumber, false);
            }
        }

        private void arrowButtonEnabler(int i_RowNumber, bool i_IsEnable)
        {
            Button arrowButton = r_ArrowButtonList[i_RowNumber];

            arrowButton.Enabled = i_IsEnable;
        }

        private bool checkIfColorDoesNotAppearMoreThenOnce(int i_RowNumber)
        {
            bool isColorAppearMoreThenOnce = false;

            for (int i = 0; i < r_SelectColorButtonMatrix.GetLength(1) - 1; i++)
            {
                Button button = r_SelectColorButtonMatrix[i_RowNumber, i];

                for(int j = i + 1; j < r_SelectColorButtonMatrix.GetLength(1); j++)
                {
                    Button buttonNext = r_SelectColorButtonMatrix[i_RowNumber, j];

                    if (button.BackColor == buttonNext.BackColor)
                    {
                        isColorAppearMoreThenOnce = true;
                        break;
                    }
                }
            }

            return isColorAppearMoreThenOnce;
        }

        private bool checkIfAllButtonInRowAreFilled(int i_RowNumber)
        {
            bool isAllRowFilled = true;

            for (int i = 0; i < r_SelectColorButtonMatrix.GetLength(1); i++)
            {
                Button button = r_SelectColorButtonMatrix[i_RowNumber, i];

                if(button.BackColor == Button.DefaultBackColor)
                {
                    isAllRowFilled = false;
                    break;
                }
            }

            return isAllRowFilled;
        }

        private int findButtonLocationRows(int i_Number)
        {
            int upLocation = i_Number / 4;

            return upLocation;
        }

        private int findButtonLocationColumns(int i_Number)
        {
            int downLocation = i_Number % 4;

            return downLocation;
        }

        private Color getColorFromForm()
        {
            Color buttonColor;
            ColorPaletteForm colorPaletteUi = new ColorPaletteForm();

            colorPaletteUi.ShowDialog();
            if (colorPaletteUi.IsClosedByColor)
            {
                buttonColor = colorPaletteUi.ButtonColor;
                colorPaletteUi.IsClosedByColor = false;
            }
            else
            {
                buttonColor = Color.Empty;
            }

            return buttonColor;
        }

        private void createResultButton(int i_SpaceSize)
        {
            Point topLeftLocation = createResultButtonTopLeft(i_SpaceSize);
            Point topRightLocation = createResultButtonTopRight(i_SpaceSize);

            createResultButtonDownLeft(topLeftLocation);
            createResultButtonDownRight(topRightLocation);
        }

        private Point createResultButtonTopLeft(int i_SpaceSize)
        {
            Button buttonTopLeft = new Button();

            buttonTopLeft.Location = r_ResultTopLeft;
            buttonTopLeft.Size = new Size(k_ResultWidth, k_ResultHeight);
            buttonTopLeft.Top = buttonTopLeft.Top + (k_ResultTopSpace * i_SpaceSize);
            buttonTopLeft.Enabled = false;
            buttonTopLeft.Name = "button" + m_ButtonResultNumber.ToString();
            int rowsNumber = findButtonLocationRows(m_ButtonResultNumber);
            int columnsNumber = findButtonLocationColumns(m_ButtonResultNumber++);

            r_ResultButtonMatrix[rowsNumber, columnsNumber] = buttonTopLeft;
            this.Controls.Add(buttonTopLeft);

            return buttonTopLeft.Location;
        }

        private Point createResultButtonTopRight(int i_SpaceSize)
        {
            Button buttonTopRight = new Button();

            buttonTopRight.Location = r_ResultTopRight;
            buttonTopRight.Size = new Size(k_ResultWidth, k_ResultHeight);
            buttonTopRight.Top = buttonTopRight.Top + (k_ResultTopSpace * i_SpaceSize);
            buttonTopRight.Enabled = false;
            buttonTopRight.Name = "button" + m_ButtonResultNumber.ToString();
            int rowsNumber = findButtonLocationRows(m_ButtonResultNumber);
            int columnsNumber = findButtonLocationColumns(m_ButtonResultNumber++);

            r_ResultButtonMatrix[rowsNumber, columnsNumber] = buttonTopRight;
            this.Controls.Add(buttonTopRight);

            return buttonTopRight.Location;
        }

        private void createResultButtonDownLeft(Point i_TopLeftLocation)
        {
            Button buttonDownLeft = new Button();

            buttonDownLeft.Location = i_TopLeftLocation;
            buttonDownLeft.Size = new Size(k_ResultWidth, k_ResultHeight);
            buttonDownLeft.Top = buttonDownLeft.Top + k_ResultDownSpace;
            buttonDownLeft.Enabled = false;
            buttonDownLeft.Name = "button" + m_ButtonResultNumber.ToString();
            int rowsNumber = findButtonLocationRows(m_ButtonResultNumber);
            int columnsNumber = findButtonLocationColumns(m_ButtonResultNumber++);

            r_ResultButtonMatrix[rowsNumber, columnsNumber] = buttonDownLeft;
            this.Controls.Add(buttonDownLeft);
        }

        private void createResultButtonDownRight(Point i_TopRightLocation)
        {
            Button buttonDownRight = new Button();

            buttonDownRight.Location = i_TopRightLocation;
            buttonDownRight.Size = new Size(k_ResultWidth, k_ResultHeight);
            buttonDownRight.Top = buttonDownRight.Top + k_ResultDownSpace;
            buttonDownRight.Enabled = false;
            buttonDownRight.Name = "button" + m_ButtonResultNumber.ToString();
            int rowsNumber = findButtonLocationRows(m_ButtonResultNumber);
            int columnsNumber = findButtonLocationColumns(m_ButtonResultNumber++);

            r_ResultButtonMatrix[rowsNumber, columnsNumber] = buttonDownRight;
            this.Controls.Add(buttonDownRight);
        }

        private void buttonArrow_Click(object i_Sender, EventArgs i_Event)
        {
            List<Color> rowColorList = new List<Color>();
            Button buttonArrow = i_Sender as Button;
            string name = buttonArrow.Name;
            string stringNumber = new string(name.Where(char.IsDigit).ToArray());
            int number = int.Parse(stringNumber);

            for (int i = 0; i <= 3; i++)
            {
                Button button = r_SelectColorButtonMatrix[number, i];

                rowColorList.Add(button.BackColor);
            }

            string guessResult = r_BullEyesGame.CheckGuess(rowColorList);

            updateResult(guessResult, number);
            buttonArrow.Enabled = false;
            disableSelectButtonRow(number);
            if(number == r_NumberOfRows - 1)
            {
                gameOver();
            }
            else
            {
                enableSelectButtonNextRow(number + 1);
            }
        }

        private void enableSelectButtonNextRow(int i_RowNumber)
        {
            for(int i = 0; i < 4; i++)
            {
                Button selectButton = r_SelectColorButtonMatrix[i_RowNumber, i];

                selectButton.Enabled = true;
            }
        }

        private void disableSelectButtonRow(int i_RowNumber)
        {
            for(int i = 0; i < 4; i++)
            {
                Button selectButton = r_SelectColorButtonMatrix[i_RowNumber, i];

                selectButton.Enabled = false;
            }
        }

        private void updateResult(string i_Result, int i_Row)
        {
            int bullEyesCounter = 0;

            for(int i = 0; i < i_Result.Length; i++)
            {
                Button button = r_ResultButtonMatrix[i_Row, i];

                if (i_Result[i] == 'V')
                {
                   button.BackColor = Color.Black;
                   bullEyesCounter++;
                }
                else if(i_Result[i] == 'X')
                {
                    button.BackColor = Color.Yellow;
                }
            }

            if(bullEyesCounter == 4)
            {
                gameOver();
            }
        }

        private void gameOver()
        {
            List<Color> randomColors = r_BullEyesGame.FourRandomColors;

            buttonGuess1.BackColor = randomColors[0];
            buttonGuess2.BackColor = randomColors[1];
            buttonGuess3.BackColor = randomColors[2];
            buttonGuess4.BackColor = randomColors[3];
        }
    }
}
