namespace Iteraator
{
    partial class PointDrawer
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(556, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // tbLevel
            // 
            this.tbLevel.Location = new System.Drawing.Point(450, 15);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(100, 20);
            this.tbLevel.TabIndex = 1;
            this.tbLevel.Text = "7";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(12, 41);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(619, 399);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // PointDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 452);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.btnDraw);
            this.Name = "PointDrawer";
            this.Text = "PointDrawer";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.PictureBox picBox;
    }
}