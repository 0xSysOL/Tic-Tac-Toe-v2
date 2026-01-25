using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe.Program.Logic;
using Tic_Tac_Toe.Program.Main;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    internal class TTT_Logic
    {



        // row 1: tags 1,2,3
        // row 2: tags 4,5,6
        // row 3: tags 7,8,9
        private enum Rows { Row_1 = 1, Row_2 = 2, Row_3 = 3 }
        private enum Row_1_coordinates { First_Row = 1, Last_Row = 3 };
        private enum Row_2_coordinates { First_Row = 4, Last_Row = 6 };
        private enum Row_3_coordinates { First_Row = 6, Last_Row = 9 };
        static public byte IsMatrixFull  { get; set; }

        private TTT_Logic()
        {
            IsMatrixFull = 0;

        }

        static public void ChangeBackColorCell(object sender, bool IsEnterCell = true)
        {

            if (IsEnterCell)
            {
                PictureBox Cell = (PictureBox)sender;
                Cell.BackColor = Color.DarkGreen;
            }
            else
            {

                PictureBox Cell = (PictureBox)sender;
                Cell.BackColor = Color.Transparent;


            }

        }


        static private void ChangePicture(PictureBox GetPitureCell, char Noughts_OR_Crosses)
        {

            if (Noughts_OR_Crosses == 'X')
                GetPitureCell.Image = Resources.X;
            else
                GetPitureCell.Image = Resources.O;


        }


        static private short CheckTheTag(PictureBox Picture_Cell)
        {

            short Number = Convert.ToInt16(Picture_Cell.Tag);

          

                return Number;
        }

        static private void Sub_FillMatrixBy_X_OR_O(ref char[,] Char_Matrix, int CellNumber, char Mark_XO,short Row_number) 
        {


                    Char_Matrix[Row_number, CellNumber -1] = Mark_XO;
           
        }

        static private void FillMatrixBy_X_OR_O(ref char[,] Char_Matrix, int CellNumber, char Mark_XO)
        {

            if (CellNumber == -1)
                return;


            if (CellNumber >= (short)Row_1_coordinates.First_Row && CellNumber <= (short)Row_1_coordinates.Last_Row)
                
                Sub_FillMatrixBy_X_OR_O(ref Char_Matrix, CellNumber, Mark_XO, 0);

            
            
            else if (CellNumber >= (short)Row_2_coordinates.First_Row && CellNumber <= (short)Row_2_coordinates.Last_Row)
            
                Sub_FillMatrixBy_X_OR_O(ref Char_Matrix, CellNumber-3, Mark_XO, 1);



            else if (CellNumber >= (short)Row_3_coordinates.First_Row && CellNumber <= (short)Row_3_coordinates.Last_Row)
                Sub_FillMatrixBy_X_OR_O(ref Char_Matrix, CellNumber -6, Mark_XO, 2);



        }
        static private bool CheckAllColumnsAndRows_X(char[,] Char_Matrix, byte Rows_1, byte Columns_1, byte Rows_2, byte Columns_2, byte Rows_3, byte Columns_3)
        {

            if (Char_Matrix[Rows_1, Columns_1] == 'X' && Char_Matrix[Rows_2, Columns_2] == 'X' && Char_Matrix[Rows_3, Columns_3] == 'X')
                return true;

            return false;
        }
        static private bool CheckAllColumnsAndRows_O(char[,] Char_Matrix,byte Rows_1,byte Columns_1, byte Rows_2, byte Columns_2, byte Rows_3, byte Columns_3) 
        {

            if (Char_Matrix[Rows_1, Columns_1] == 'O' && Char_Matrix[Rows_2, Columns_2] == 'O' && Char_Matrix[Rows_3, Columns_3] == 'O')
                return true;

            return false;
        }
        static public bool IsColumnsAndRows_Valid(char[,] Char_Matrix) 
        {
            //Check Like this condition
            /* 
            1  0  0 
            0  1  0
            0  0  1
             */ 
            if (CheckAllColumnsAndRows_X(Char_Matrix,0,0,1,1,2,2) || CheckAllColumnsAndRows_O(Char_Matrix, 0, 0, 1, 1, 2, 2))
                return true;





            //Check Like this condition
            /* 
            0  0  1 
            0  1  0
            1  0  0
             */
            if (CheckAllColumnsAndRows_X(Char_Matrix, 0, 2, 1, 1, 2, 0) || CheckAllColumnsAndRows_O(Char_Matrix, 0, 2, 1, 1, 2, 0))
                return true;





            //Check Like this condition
            /* 
            1  0  0
            1  0  0
            1  0  0
             */
            if (CheckAllColumnsAndRows_X(Char_Matrix, 0, 0, 1, 0, 2, 0) || CheckAllColumnsAndRows_O(Char_Matrix, 0, 0, 1, 0, 2, 0))
                return true;





            //Check Like this condition
            /* 
            0  1  0
            0  1  0
            0  1  0
             */
            if (CheckAllColumnsAndRows_X(Char_Matrix, 0, 1, 1, 1, 2, 1) || CheckAllColumnsAndRows_O(Char_Matrix, 0, 1, 1, 1, 2, 1))
                return true;





            //Check Like this condition
            /* 
            0  0  1
            0  0  1
            0  0  1
             */
            if (CheckAllColumnsAndRows_X(Char_Matrix, 0, 2, 1, 2, 2, 2) || CheckAllColumnsAndRows_O(Char_Matrix, 0, 2, 1, 2, 2, 2))
                return true;






            //Check Like this condition
            /* 
            0  0  0
            0  0  0
            1  1  1
             */
            if (CheckAllColumnsAndRows_X(Char_Matrix, 2, 0, 2, 1, 2, 2) || CheckAllColumnsAndRows_O(Char_Matrix, 2, 0, 2, 1, 2, 2))
                return true;


            //Check Like this condition
            /* 
            0  0  0
            1  1  1
            0  0  0
             */
            if (CheckAllColumnsAndRows_X(Char_Matrix, 1, 0, 1, 1, 1, 2) || CheckAllColumnsAndRows_O(Char_Matrix, 1, 0, 1, 1, 1, 2))
                return true;


            //Check Like this condition
            /* 
            1  1  1
            0  0  0
            0  0  0
             */
            if (CheckAllColumnsAndRows_X(Char_Matrix, 0, 0, 0, 1, 0, 2) || CheckAllColumnsAndRows_O(Char_Matrix, 0, 0, 0, 1, 0, 2))
                return true;








            return false;

        }



        static public bool Start_AndGetResultGame(PictureBox picture_Cell, PictureBox[,] PicBox_Matrix, ref char[,] Char_Matrix, Player CurrentPlayer)
        {


            if (IsMatrixFull == 9) return true;




            if (CurrentPlayer.IsFirstPlayer)
            {


                ChangePicture(picture_Cell, 'X');
                FillMatrixBy_X_OR_O(ref Char_Matrix, CheckTheTag(picture_Cell), 'X');
                
            }
            else
            {

                ChangePicture(picture_Cell, 'O');
                FillMatrixBy_X_OR_O(ref Char_Matrix, CheckTheTag(picture_Cell), 'O');
            

            }
            IsMatrixFull++;
            if (IsColumnsAndRows_Valid(Char_Matrix))
            {

                CurrentPlayer.IsWinner = true;
                return true;

            };


            if (IsMatrixFull == 9)
            {
                CurrentPlayer.Name = "No Winner";
                SoundFunctions.PlayDrawSound();
                return true;
            }
            
            
            return false;


        }


    }
}
