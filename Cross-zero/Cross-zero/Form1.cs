using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cross_zero
{
    public partial class Form1 : Form
    {
        // Field.
        Graphics graphics;
        private List<KeyValuePair<int, int>> field;
        private int delta;
        private int indentW;
        private int indentH;
        private int cellAmount;
        private int cellSize;

        // Elements.
        Symbol symbol;
        private bool[,] crosses;
        private bool[,] zeros;
        private int crossesScore = 0;
        private int zerosScore = 0;
        private bool win = false;

        private enum Symbol
        {
            Cross,
            Zero
        }

        public Form1()
        {
            InitializeComponent();
            labelDrawnGame.Parent = pictureBox1; // For label transparency.
            
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    buttonStart_Click(sender, e);
        //}

        private void timer1_Tick(object sender, EventArgs e)
        { 
            DrawLines();
            DrawCrosses();
            DrawZeros();
            pictureBox1.Invalidate();
            CheckFieldFullness();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (labelDrawnGame.Visible == true)
                labelDrawnGame.Visible = false;

            win = false;
            symbol = Symbol.Cross;
            cellAmount = (int)nudSize.Value;
            nudSize.Enabled = false;

            field = new List<KeyValuePair<int, int>>();
            crosses = new bool[cellAmount, cellAmount];
            zeros = new bool[cellAmount, cellAmount];
            timer1.Start();
        }

        private void DrawLines()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.Clear(Color.Empty);

            delta = Math.Min(pictureBox1.Width, pictureBox1.Height);
            indentW = (pictureBox1.Width - delta) / 2;
            indentH = (pictureBox1.Height - delta) / 2;
            cellSize = delta / cellAmount;

            // Vertical lines.
            for (int x = indentW, i = 0; i < cellAmount - 1; i++, x += cellSize)
            {
                graphics.DrawLine(Pens.Black, x + cellSize, indentH, x + cellSize, pictureBox1.Height - indentH);
            }
            // Horizontal lines.
            for (int y = indentH, i = 0; i < cellAmount - 1; i++, y += cellSize)
            {
                graphics.DrawLine(Pens.Black, indentW, y + cellSize, pictureBox1.Width - indentW, y + cellSize);
            }       
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (win)
                return;
            int cellX, cellY;
            int cursorX = e.Location.X;
            int cursorY = e.Location.Y;
            CalculateCellCoordinates(out cellX, out cellY, cursorX, cursorY);

            if (ClickInField(cellX, cellY) && CellIsEmpty(cellX, cellY))
            {
                AddSymbolToField(cellX, cellY);
                switch (symbol)
                {
                    case Symbol.Cross:
                        {
                            symbol = Symbol.Zero;
                            if (IsWinCombination(cellX, cellY, crosses))
                            {
                                labelScoreUser1.Text = $"{++crossesScore}";
                                win = true;
                                //timer1.Stop();
                                nudSize.Enabled = true;
                                return;
                            }
                            break;
                        }
                    case Symbol.Zero:
                        {
                            symbol = Symbol.Cross;
                            if (IsWinCombination(cellX, cellY, zeros))
                            {
                                labelScoreUser2.Text = $"{++zerosScore}";
                                win = true;
                                //timer1.Stop();
                                nudSize.Enabled = true;
                                return;
                            }
                            break;
                        }
                }
            }
        }

        private bool ClickInField(int cell_x, int cell_y)
        {
            return (cell_x > 0 && cell_x <= cellAmount
                && cell_y > 0 && cell_y <= cellAmount);
        }

        private bool CellIsEmpty(int cell_x, int cell_y)
        {
            foreach (var cell in field)
            {
                if (cell.Key == cell_x && cell.Value == cell_y)
                    return false;
            }
            return true;
        }

        private void CalculateCellCoordinates(out int cell_x, out int cell_y, int cursor_x, int cursor_y)
        {
            int x = indentW, y = indentH;
            cell_x = 0;
            cell_y = 0;
            while (x <= cursor_x)
            {
                x += cellSize;
                cell_x++;
            }
            while (y <= cursor_y)
            {
                y += cellSize;
                cell_y++;
            }
        }

        private void AddSymbolToField(int cell_x, int cell_y)
        {
            field.Add(new KeyValuePair<int, int>(cell_x, cell_y));
            switch (symbol)
            {
                case Symbol.Cross:
                    {
                        crosses[cell_x - 1, cell_y - 1] = true;
                        break;
                    }
                case Symbol.Zero:
                    {
                        zeros[cell_x - 1, cell_y - 1] = true;
                        break;
                    }
            }
        }

        private void DrawCrosses()
        {
            int leftX, rightX, bottomY, upY;
            for(int x = 0; x < cellAmount; x++)
            {
                for (int y = 0; y < cellAmount; y++)
                {
                    if(crosses[x, y])
                    {
                        leftX = indentW + x * cellSize;
                        rightX = indentW + (x + 1) * cellSize;
                        bottomY = indentH + (y + 1) * cellSize;
                        upY = indentH + y * cellSize;
                        graphics.DrawLine(Pens.Black, leftX, upY, rightX, bottomY);
                        graphics.DrawLine(Pens.Black, leftX, bottomY, rightX, upY);
                    }
                }
            }
        }

        private void DrawZeros()
        {
            int centerX, centerY;
            for (int x = 0; x < cellAmount; x++)
            {
                for (int y = 0; y < cellAmount; y++)
                {
                    if (zeros[x, y])
                    {
                        centerX = indentW + x * cellSize;
                        centerY= indentH + y * cellSize;
                        graphics.DrawEllipse(Pens.Black, centerX, centerY, cellSize, cellSize);
                    }
                }
            }
        }

        private bool IsWinCombination(int x, int y, bool[,] array)
        {
            // Vertical check.
            for (int i = 0; i < cellAmount; i++)
            {
                if (i == cellAmount - 1 && array[i, y - 1])
                {
                    DrawWinCombination(1, y, cellAmount, y);
                    return true;
                }
                if (!array[i, y - 1])
                    break;
            }
            // Horizontal check.
            for (int j = 0; j < cellAmount; j++)
            {
                if (j == cellAmount - 1 && array[x - 1, j])
                {
                    DrawWinCombination(x, 1, x, cellAmount);
                    return true;
                }
                if (!array[x - 1, j])
                    break;
            }
            // Check from left top to right botom point
            for (int i = 0, j = 0; i < cellAmount; i++, j++)
            {
                if (i == cellAmount - 1 && array[i, j])
                {
                    DrawWinCombination(1, 1, cellAmount, cellAmount);
                    return true;
                }
                if (!array[i, j])
                    break;
            }
            // Check from left bottom to right top point
            for (int i = 0, j = cellAmount - 1; i < cellAmount; i++, j--)
            {
                if (i == cellAmount - 1 && array[i, j])
                {
                    DrawWinCombination(1, cellAmount, cellAmount, 1);
                    return true;
                }
                if (!array[i, j])
                    break;
            }
            return false;
        }

        private void CheckFieldFullness()
        {
            for(int i = 0; i < cellAmount; i++)
            {
                for(int j = 0; j < cellAmount; j++)
                {
                    if (!crosses[i, j] && !zeros[i, j])
                        return;
                }
            }
            labelDrawnGame.Visible = true;
            nudSize.Enabled = true;
            //timer1.Stop();
        }

        private void DrawWinCombination(int x1, int y1, int x2, int y2)
        {
            int deltaX = (x1 - x2 + 1) / cellAmount;
            int deltaY = (y1 - y2 + 1) / cellAmount;
            for (int i = 0, x = x1, y = y1; i < cellAmount; i++, x += deltaX, y +=deltaY)
            {

            }
        }

        //private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (win)
        //        return;
        //    int cellX, cellY;
        //    int cursorX = e.Location.X;
        //    int cursorY = e.Location.Y;
        //    CalculateCellCoordinates(out cellX, out cellY, cursorX, cursorY);

        //    if (CellIsEmpty(cellX, cellY))
        //    {
        //        switch (symbol)
        //        {
        //            case Symbol.Cross:
        //                {
        //                    DrawCrossUnderMouse(cellX, cellY);
        //                    break;
        //                }
        //            case Symbol.Zero:
        //                {
        //                    DrawZeroUnderMouse(cellX, cellY);
        //                    break;
        //                }
        //        }
        //    }
        //}

        //private void DrawCrossUnderMouse(int cell_x, int cell_y)
        //{
        //    int leftX = indentW + (cell_x - 1) * cellSize;
        //    int rightX = indentW + cell_x * cellSize;
        //    int bottomY = indentH + cell_y * cellSize;
        //    int upY = indentH + (cell_y - 1) * cellSize;
            
        //    graphics.DrawLine(Pens.Gray, leftX, upY, rightX, bottomY);
        //    graphics.DrawLine(Pens.Gray, leftX, bottomY, rightX, upY);
                   
        //    pictureBox1.Refresh();
        //}

        //private void DrawZeroUnderMouse(int cell_x, int cell_y)
        //{
        //    int centerX = indentW + (cell_x - 1) * cellSize;
        //    int centerY = indentH + (cell_y - 1) * cellSize;
            
        //    graphics.DrawEllipse(Pens.Black, centerX, centerY, cellSize, cellSize);
                   
        //    pictureBox1.Refresh();
        //}

        //private void pictureBox1_MouseHover(object sender, EventArgs e)
        //{
        //    if (win)
        //        return;
        //    MouseEventArgs mouseEventArgs;
            
        //    int cellX, cellY;
        //    int cursorX = mouseEventArgs.Location.X; ;
        //    int cursorY = e.Location.Y;
        //    CalculateCellCoordinates(out cellX, out cellY, cursorX, cursorY);

        //    if (CellIsEmpty(cellX, cellY))
        //    {
        //        switch (symbol)
        //        {
        //            case Symbol.Cross:
        //                {
        //                    DrawCrossUnderMouse(cellX, cellY);
        //                    break;
        //                }
        //            case Symbol.Zero:
        //                {
        //                    DrawZeroUnderMouse(cellX, cellY);
        //                    break;
        //                }
        //        }
        //    }
        //}
    }
}