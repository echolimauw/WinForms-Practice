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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnake));
            this.GameBoard = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
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
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "bonus1.png");
            this.imgList.Images.SetKeyName(1, "bonus2.png");
            this.imgList.Images.SetKeyName(2, "bonus3.png");
            this.imgList.Images.SetKeyName(3, "bonus4.png");
            this.imgList.Images.SetKeyName(4, "snake_body.png");
            this.imgList.Images.SetKeyName(5, "snake_head.png");
            this.imgList.Images.SetKeyName(6, "wall.png");
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 439);
            this.Controls.Add(this.GameBoard);
            this.Name = "frmSnake";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSnake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameBoard;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList imgList;
    }
}

