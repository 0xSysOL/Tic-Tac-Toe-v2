namespace Tic_Tac_Toe
{
    partial class Form_TTT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lable_Turn = new System.Windows.Forms.Label();
            this.Lable_PlayerName = new System.Windows.Forms.Label();
            this.Lable_Result = new System.Windows.Forms.Label();
            this.Lable_ShowResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pic_cell_1 = new System.Windows.Forms.PictureBox();
            this.Pic_cell_3 = new System.Windows.Forms.PictureBox();
            this.Pic_cell_2 = new System.Windows.Forms.PictureBox();
            this.Pic_cell_6 = new System.Windows.Forms.PictureBox();
            this.Pic_cell_5 = new System.Windows.Forms.PictureBox();
            this.Pic_cell_8 = new System.Windows.Forms.PictureBox();
            this.Pic_cell_9 = new System.Windows.Forms.PictureBox();
            this.Pic_cell_4 = new System.Windows.Forms.PictureBox();
            this.Pic_cell_7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_7)).BeginInit();
            this.SuspendLayout();
            // 
            // Lable_Turn
            // 
            this.Lable_Turn.AutoSize = true;
            this.Lable_Turn.BackColor = System.Drawing.SystemColors.ControlText;
            this.Lable_Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Turn.ForeColor = System.Drawing.Color.Yellow;
            this.Lable_Turn.Location = new System.Drawing.Point(51, 111);
            this.Lable_Turn.Name = "Lable_Turn";
            this.Lable_Turn.Size = new System.Drawing.Size(88, 38);
            this.Lable_Turn.TabIndex = 1;
            this.Lable_Turn.Text = "Turn";
            // 
            // Lable_PlayerName
            // 
            this.Lable_PlayerName.AutoSize = true;
            this.Lable_PlayerName.BackColor = System.Drawing.SystemColors.ControlText;
            this.Lable_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_PlayerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lable_PlayerName.Location = new System.Drawing.Point(51, 162);
            this.Lable_PlayerName.Name = "Lable_PlayerName";
            this.Lable_PlayerName.Size = new System.Drawing.Size(145, 38);
            this.Lable_PlayerName.TabIndex = 2;
            this.Lable_PlayerName.Text = "Player 1";
            // 
            // Lable_Result
            // 
            this.Lable_Result.AutoSize = true;
            this.Lable_Result.BackColor = System.Drawing.SystemColors.ControlText;
            this.Lable_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Result.ForeColor = System.Drawing.Color.Yellow;
            this.Lable_Result.Location = new System.Drawing.Point(51, 220);
            this.Lable_Result.Name = "Lable_Result";
            this.Lable_Result.Size = new System.Drawing.Size(126, 38);
            this.Lable_Result.TabIndex = 3;
            this.Lable_Result.Text = "Winner";
            // 
            // Lable_ShowResult
            // 
            this.Lable_ShowResult.AutoSize = true;
            this.Lable_ShowResult.BackColor = System.Drawing.SystemColors.ControlText;
            this.Lable_ShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_ShowResult.ForeColor = System.Drawing.Color.Lime;
            this.Lable_ShowResult.Location = new System.Drawing.Point(51, 291);
            this.Lable_ShowResult.Name = "Lable_ShowResult";
            this.Lable_ShowResult.Size = new System.Drawing.Size(105, 38);
            this.Lable_ShowResult.TabIndex = 4;
            this.Lable_ShowResult.Text = "NULL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(51, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Restart Game";
            this.label5.Click += new System.EventHandler(this.Restart);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Tic_Tac_Toe.Properties.Resources.Tic_Tac_Toe1;
            this.pictureBox1.Location = new System.Drawing.Point(454, -144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 698);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(119, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 42);
            this.label6.TabIndex = 6;
            this.label6.Text = "Welcom to Game";
            // 
            // Pic_cell_1
            // 
            this.Pic_cell_1.BackColor = System.Drawing.Color.Transparent;
            this.Pic_cell_1.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Pic_cell_1.Location = new System.Drawing.Point(512, 33);
            this.Pic_cell_1.Name = "Pic_cell_1";
            this.Pic_cell_1.Size = new System.Drawing.Size(123, 116);
            this.Pic_cell_1.TabIndex = 13;
            this.Pic_cell_1.TabStop = false;
            this.Pic_cell_1.Tag = "1";
            this.Pic_cell_1.Click += new System.EventHandler(this.Clicked_On_Cell);
            this.Pic_cell_1.MouseEnter += new System.EventHandler(this.MouseEnterCell);
            this.Pic_cell_1.MouseLeave += new System.EventHandler(this.MouseLeaveCell);
            // 
            // Pic_cell_3
            // 
            this.Pic_cell_3.BackColor = System.Drawing.Color.Transparent;
            this.Pic_cell_3.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Pic_cell_3.Location = new System.Drawing.Point(820, 33);
            this.Pic_cell_3.Name = "Pic_cell_3";
            this.Pic_cell_3.Size = new System.Drawing.Size(123, 116);
            this.Pic_cell_3.TabIndex = 14;
            this.Pic_cell_3.TabStop = false;
            this.Pic_cell_3.Tag = "3";
            this.Pic_cell_3.Click += new System.EventHandler(this.Clicked_On_Cell);
            this.Pic_cell_3.MouseEnter += new System.EventHandler(this.MouseEnterCell);
            this.Pic_cell_3.MouseLeave += new System.EventHandler(this.MouseLeaveCell);
            // 
            // Pic_cell_2
            // 
            this.Pic_cell_2.BackColor = System.Drawing.Color.Transparent;
            this.Pic_cell_2.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Pic_cell_2.Location = new System.Drawing.Point(668, 33);
            this.Pic_cell_2.Name = "Pic_cell_2";
            this.Pic_cell_2.Size = new System.Drawing.Size(123, 116);
            this.Pic_cell_2.TabIndex = 15;
            this.Pic_cell_2.TabStop = false;
            this.Pic_cell_2.Tag = "2";
            this.Pic_cell_2.Click += new System.EventHandler(this.Clicked_On_Cell);
            this.Pic_cell_2.MouseEnter += new System.EventHandler(this.MouseEnterCell);
            this.Pic_cell_2.MouseLeave += new System.EventHandler(this.MouseLeaveCell);
            // 
            // Pic_cell_6
            // 
            this.Pic_cell_6.BackColor = System.Drawing.Color.Transparent;
            this.Pic_cell_6.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Pic_cell_6.Location = new System.Drawing.Point(820, 188);
            this.Pic_cell_6.Name = "Pic_cell_6";
            this.Pic_cell_6.Size = new System.Drawing.Size(123, 116);
            this.Pic_cell_6.TabIndex = 16;
            this.Pic_cell_6.TabStop = false;
            this.Pic_cell_6.Tag = "6";
            this.Pic_cell_6.Click += new System.EventHandler(this.Clicked_On_Cell);
            this.Pic_cell_6.MouseEnter += new System.EventHandler(this.MouseEnterCell);
            this.Pic_cell_6.MouseLeave += new System.EventHandler(this.MouseLeaveCell);
            // 
            // Pic_cell_5
            // 
            this.Pic_cell_5.BackColor = System.Drawing.Color.Transparent;
            this.Pic_cell_5.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Pic_cell_5.Location = new System.Drawing.Point(668, 188);
            this.Pic_cell_5.Name = "Pic_cell_5";
            this.Pic_cell_5.Size = new System.Drawing.Size(123, 116);
            this.Pic_cell_5.TabIndex = 17;
            this.Pic_cell_5.TabStop = false;
            this.Pic_cell_5.Tag = "5";
            this.Pic_cell_5.Click += new System.EventHandler(this.Clicked_On_Cell);
            this.Pic_cell_5.MouseEnter += new System.EventHandler(this.MouseEnterCell);
            this.Pic_cell_5.MouseLeave += new System.EventHandler(this.MouseLeaveCell);
            // 
            // Pic_cell_8
            // 
            this.Pic_cell_8.BackColor = System.Drawing.Color.Transparent;
            this.Pic_cell_8.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Pic_cell_8.Location = new System.Drawing.Point(668, 341);
            this.Pic_cell_8.Name = "Pic_cell_8";
            this.Pic_cell_8.Size = new System.Drawing.Size(123, 116);
            this.Pic_cell_8.TabIndex = 18;
            this.Pic_cell_8.TabStop = false;
            this.Pic_cell_8.Tag = "8";
            this.Pic_cell_8.Click += new System.EventHandler(this.Clicked_On_Cell);
            this.Pic_cell_8.MouseEnter += new System.EventHandler(this.MouseEnterCell);
            this.Pic_cell_8.MouseLeave += new System.EventHandler(this.MouseLeaveCell);
            // 
            // Pic_cell_9
            // 
            this.Pic_cell_9.BackColor = System.Drawing.Color.Transparent;
            this.Pic_cell_9.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Pic_cell_9.Location = new System.Drawing.Point(820, 341);
            this.Pic_cell_9.Name = "Pic_cell_9";
            this.Pic_cell_9.Size = new System.Drawing.Size(123, 116);
            this.Pic_cell_9.TabIndex = 19;
            this.Pic_cell_9.TabStop = false;
            this.Pic_cell_9.Tag = "9";
            this.Pic_cell_9.Click += new System.EventHandler(this.Clicked_On_Cell);
            this.Pic_cell_9.MouseEnter += new System.EventHandler(this.MouseEnterCell);
            this.Pic_cell_9.MouseLeave += new System.EventHandler(this.MouseLeaveCell);
            // 
            // Pic_cell_4
            // 
            this.Pic_cell_4.BackColor = System.Drawing.Color.Transparent;
            this.Pic_cell_4.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Pic_cell_4.Location = new System.Drawing.Point(512, 188);
            this.Pic_cell_4.Name = "Pic_cell_4";
            this.Pic_cell_4.Size = new System.Drawing.Size(123, 116);
            this.Pic_cell_4.TabIndex = 20;
            this.Pic_cell_4.TabStop = false;
            this.Pic_cell_4.Tag = "4";
            this.Pic_cell_4.Click += new System.EventHandler(this.Clicked_On_Cell);
            this.Pic_cell_4.MouseEnter += new System.EventHandler(this.MouseEnterCell);
            this.Pic_cell_4.MouseLeave += new System.EventHandler(this.MouseLeaveCell);
            // 
            // Pic_cell_7
            // 
            this.Pic_cell_7.BackColor = System.Drawing.Color.Transparent;
            this.Pic_cell_7.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Pic_cell_7.Location = new System.Drawing.Point(512, 341);
            this.Pic_cell_7.Name = "Pic_cell_7";
            this.Pic_cell_7.Size = new System.Drawing.Size(123, 116);
            this.Pic_cell_7.TabIndex = 21;
            this.Pic_cell_7.TabStop = false;
            this.Pic_cell_7.Tag = "7";
            this.Pic_cell_7.Click += new System.EventHandler(this.Clicked_On_Cell);
            this.Pic_cell_7.MouseEnter += new System.EventHandler(this.MouseEnterCell);
            this.Pic_cell_7.MouseLeave += new System.EventHandler(this.MouseLeaveCell);
            // 
            // Form_TTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1007, 492);
            this.Controls.Add(this.Pic_cell_7);
            this.Controls.Add(this.Pic_cell_4);
            this.Controls.Add(this.Pic_cell_9);
            this.Controls.Add(this.Pic_cell_8);
            this.Controls.Add(this.Pic_cell_5);
            this.Controls.Add(this.Pic_cell_6);
            this.Controls.Add(this.Pic_cell_2);
            this.Controls.Add(this.Pic_cell_3);
            this.Controls.Add(this.Pic_cell_1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lable_ShowResult);
            this.Controls.Add(this.Lable_Result);
            this.Controls.Add(this.Lable_PlayerName);
            this.Controls.Add(this.Lable_Turn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_TTT";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form_TTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cell_7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lable_Turn;
        private System.Windows.Forms.Label Lable_PlayerName;
        private System.Windows.Forms.Label Lable_Result;
        private System.Windows.Forms.Label Lable_ShowResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Pic_cell_1;
        private System.Windows.Forms.PictureBox Pic_cell_3;
        private System.Windows.Forms.PictureBox Pic_cell_2;
        private System.Windows.Forms.PictureBox Pic_cell_6;
        private System.Windows.Forms.PictureBox Pic_cell_5;
        private System.Windows.Forms.PictureBox Pic_cell_9;
        private System.Windows.Forms.PictureBox Pic_cell_4;
        private System.Windows.Forms.PictureBox Pic_cell_7;
        private System.Windows.Forms.PictureBox Pic_cell_8;
    }
}

