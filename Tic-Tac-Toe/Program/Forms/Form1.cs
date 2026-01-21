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
using Tic_Tac_Toe.Program.Main;
using Tic_Tac_Toe.Properties;


namespace Tic_Tac_Toe
{
    public partial class Form_TTT : Form
    {
        
        
       private Player Player_1 = new Player();
       private Player Player_2 = new Player();
       private Player Current_Player = new Player();
       private PictureBox [,]PicBox_Matrix = new PictureBox[3, 3];
       private char[,] Char_Matrix = new char[3, 3];
       private bool Player_Role;
       private bool IsGameOver;


        public void FillMatrix_PicBox(ref PictureBox[,] matrix)
        {

            matrix[0, 0] = Pic_cell_1;
            matrix[0, 1] = Pic_cell_2;
            matrix[0, 2] = Pic_cell_3;
            matrix[1, 0] = Pic_cell_4;
            matrix[1, 1] = Pic_cell_5;
            matrix[1, 2] = Pic_cell_6;
            matrix[2, 0] = Pic_cell_7;
            matrix[2, 1] = Pic_cell_8;
            matrix[2, 2] = Pic_cell_9;


        }
        public void FillMatrix_char(char[,] matrix) 
        {

            matrix[0, 0] = '?';
            matrix[0, 1] = '?';
            matrix[0, 2] = '?';
            matrix[1, 0] = '?';
            matrix[1, 1] = '?';
            matrix[1, 2] = '?';
            matrix[2, 0] = '?';
            matrix[2, 1] = '?';
            matrix[2, 2] = '?';


        }

        public Form_TTT()
        {
            InitializeComponent();
            FillMatrix_PicBox(ref PicBox_Matrix);
            FillMatrix_char(Char_Matrix);
            Player_1.IsFirstPlayer = true;
            Player_1.Name = "Player_1";
            Player_2.IsFirstPlayer = false;
            Player_2.Name = "Player_2";

            Player_Role = true;
            IsGameOver = false;
        }


        private void Form_TTT_Load(object sender, EventArgs e)
        {
             
        }

        private void Restart(object sender, EventArgs e)
        {



        }

        private void Clicked_On_Cell(object sender, EventArgs e)
        {

            PictureBox picture_Cell = (PictureBox)sender;

            if (picture_Cell.Tag.ToString() == "") return;



            if (IsGameOver) return;


            if (Player_Role)
            {
                Current_Player = Player_1;
                Lable_PlayerName.Text = Current_Player.Name;
                IsGameOver = TTT_Logic.Start_AndGetResultGame(picture_Cell, PicBox_Matrix,ref Char_Matrix, Current_Player);
                Player_Role = false;
                picture_Cell.Tag = "";
            }
            else 
            {
                Current_Player = Player_2;
                Lable_PlayerName.Text = Current_Player.Name;
                IsGameOver =  TTT_Logic.Start_AndGetResultGame(picture_Cell, PicBox_Matrix,ref Char_Matrix, Current_Player);
                Player_Role = true;
                picture_Cell.Tag = "";


            }


            if (IsGameOver)
            {
                Lable_ShowResult.Text = Current_Player.Name;
                return;
            }
            







        }

        private void MouseEnterCell(object sender, EventArgs e)
        {

            TTT_Logic.ChangeBackColorCell(sender);
            

        }

        private void MouseLeaveCell(object sender, EventArgs e)
        {



            TTT_Logic.ChangeBackColorCell(sender,false);


        }
    }
}
