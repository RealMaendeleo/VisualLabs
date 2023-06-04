
namespace VisualLab6
{
    partial class Clock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dot1 = new System.Windows.Forms.PictureBox();
            this.dot2 = new System.Windows.Forms.PictureBox();
            this.dot4 = new System.Windows.Forms.PictureBox();
            this.dot3 = new System.Windows.Forms.PictureBox();
            this.sevenSegment6 = new VisualLab6.SevenSegment();
            this.sevenSegment5 = new VisualLab6.SevenSegment();
            this.sevenSegment4 = new VisualLab6.SevenSegment();
            this.sevenSegment3 = new VisualLab6.SevenSegment();
            this.sevenSegment2 = new VisualLab6.SevenSegment();
            this.sevenSegment1 = new VisualLab6.SevenSegment();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot3)).BeginInit();
            this.SuspendLayout();
            // 
            // dot1
            // 
            this.dot1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dot1.Location = new System.Drawing.Point(74, 26);
            this.dot1.Name = "dot1";
            this.dot1.Size = new System.Drawing.Size(5, 5);
            this.dot1.TabIndex = 14;
            this.dot1.TabStop = false;
            // 
            // dot2
            // 
            this.dot2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dot2.Location = new System.Drawing.Point(74, 41);
            this.dot2.Name = "dot2";
            this.dot2.Size = new System.Drawing.Size(5, 5);
            this.dot2.TabIndex = 15;
            this.dot2.TabStop = false;
            // 
            // dot4
            // 
            this.dot4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dot4.Location = new System.Drawing.Point(152, 41);
            this.dot4.Name = "dot4";
            this.dot4.Size = new System.Drawing.Size(5, 5);
            this.dot4.TabIndex = 49;
            this.dot4.TabStop = false;
            // 
            // dot3
            // 
            this.dot3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dot3.Location = new System.Drawing.Point(152, 26);
            this.dot3.Name = "dot3";
            this.dot3.Size = new System.Drawing.Size(5, 5);
            this.dot3.TabIndex = 48;
            this.dot3.TabStop = false;
            // 
            // sevenSegment6
            // 
            this.sevenSegment6.Location = new System.Drawing.Point(195, 6);
            this.sevenSegment6.Name = "sevenSegment6";
            this.sevenSegment6.Size = new System.Drawing.Size(32, 58);
            this.sevenSegment6.TabIndex = 55;
            // 
            // sevenSegment5
            // 
            this.sevenSegment5.Location = new System.Drawing.Point(161, 6);
            this.sevenSegment5.Name = "sevenSegment5";
            this.sevenSegment5.Size = new System.Drawing.Size(32, 58);
            this.sevenSegment5.TabIndex = 54;
            // 
            // sevenSegment4
            // 
            this.sevenSegment4.Location = new System.Drawing.Point(117, 6);
            this.sevenSegment4.Name = "sevenSegment4";
            this.sevenSegment4.Size = new System.Drawing.Size(32, 58);
            this.sevenSegment4.TabIndex = 51;
            // 
            // sevenSegment3
            // 
            this.sevenSegment3.Location = new System.Drawing.Point(83, 6);
            this.sevenSegment3.Name = "sevenSegment3";
            this.sevenSegment3.Size = new System.Drawing.Size(32, 58);
            this.sevenSegment3.TabIndex = 50;
            // 
            // sevenSegment2
            // 
            this.sevenSegment2.Location = new System.Drawing.Point(39, 6);
            this.sevenSegment2.Name = "sevenSegment2";
            this.sevenSegment2.Size = new System.Drawing.Size(32, 58);
            this.sevenSegment2.TabIndex = 47;
            // 
            // sevenSegment1
            // 
            this.sevenSegment1.Location = new System.Drawing.Point(5, 6);
            this.sevenSegment1.Name = "sevenSegment1";
            this.sevenSegment1.Size = new System.Drawing.Size(32, 58);
            this.sevenSegment1.TabIndex = 46;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sevenSegment6);
            this.Controls.Add(this.sevenSegment5);
            this.Controls.Add(this.sevenSegment4);
            this.Controls.Add(this.sevenSegment3);
            this.Controls.Add(this.dot4);
            this.Controls.Add(this.dot3);
            this.Controls.Add(this.sevenSegment2);
            this.Controls.Add(this.sevenSegment1);
            this.Controls.Add(this.dot2);
            this.Controls.Add(this.dot1);
            this.Name = "Clock";
            this.Size = new System.Drawing.Size(235, 69);
            ((System.ComponentModel.ISupportInitialize)(this.dot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox dot1;
        private System.Windows.Forms.PictureBox dot2;
        private SevenSegment sevenSegment1;
        private SevenSegment sevenSegment2;
        private SevenSegment sevenSegment4;
        private SevenSegment sevenSegment3;
        private System.Windows.Forms.PictureBox dot4;
        private System.Windows.Forms.PictureBox dot3;
        private SevenSegment sevenSegment6;
        private SevenSegment sevenSegment5;
        private System.Windows.Forms.Timer timer1;
    }
}
