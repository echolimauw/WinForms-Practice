using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class frmSnake : Form
    {
        Random rand;
        enum GameBoardFields
        {
            Free,
            Snake,
            Bonus
        };

        enum Directions
        {
            Up,
            Down,
            Left,
            Right
        };

        struct SnakeCoordinates
        {
            public int x;
            public int y;
        }

        GameBoardFields[,] gameBoardField;
        SnakeCoordinates[] snakeXY;
        int snakeLength;
        Directions direction;
        Graphics g;   

        public frmSnake()
        {
            InitializeComponent();
        }

        private void frmSnake_Load(object sender, EventArgs e)
        {

        }
    }
}
