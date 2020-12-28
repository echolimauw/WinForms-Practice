namespace SnakeGame
{
    partial class frmSnake
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // GameBoard
            // 
            this.GameBoard.Location = new System.Drawing.Point(12, 12);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(420, 420);
            this.GameBoard.TabIndex = 0;
            this.GameBoard.TabStop = false;
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 439);
            this.Controls.Add(this.GameBoard);
            this.Name = "frmSnake";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameBoard;
    }
}

