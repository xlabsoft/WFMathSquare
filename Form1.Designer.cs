namespace WFMathSquare
{
    partial class MainForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelPlayerLeft = new System.Windows.Forms.Panel();
            this.lblScoreL = new System.Windows.Forms.Label();
            this.lbldirL = new System.Windows.Forms.Label();
            this.lblNameL = new System.Windows.Forms.Label();
            this.panelPlayerRight = new System.Windows.Forms.Panel();
            this.lblScoreR = new System.Windows.Forms.Label();
            this.lbldirR = new System.Windows.Forms.Label();
            this.lblNameR = new System.Windows.Forms.Label();
            this.panelPlayerLeft.SuspendLayout();
            this.panelPlayerRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(12, 76);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(452, 461);
            this.panelMain.TabIndex = 0;
            // 
            // panelPlayerLeft
            // 
            this.panelPlayerLeft.Controls.Add(this.lblScoreL);
            this.panelPlayerLeft.Controls.Add(this.lbldirL);
            this.panelPlayerLeft.Controls.Add(this.lblNameL);
            this.panelPlayerLeft.Location = new System.Drawing.Point(12, 12);
            this.panelPlayerLeft.Name = "panelPlayerLeft";
            this.panelPlayerLeft.Size = new System.Drawing.Size(195, 58);
            this.panelPlayerLeft.TabIndex = 1;
            // 
            // lblScoreL
            // 
            this.lblScoreL.AutoSize = true;
            this.lblScoreL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.lblScoreL.Location = new System.Drawing.Point(83, 6);
            this.lblScoreL.Name = "lblScoreL";
            this.lblScoreL.Size = new System.Drawing.Size(41, 44);
            this.lblScoreL.TabIndex = 4;
            this.lblScoreL.Text = "0";
            // 
            // lbldirL
            // 
            this.lbldirL.AutoSize = true;
            this.lbldirL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.lbldirL.Location = new System.Drawing.Point(43, 6);
            this.lbldirL.Name = "lbldirL";
            this.lbldirL.Size = new System.Drawing.Size(47, 44);
            this.lbldirL.TabIndex = 1;
            this.lbldirL.Text = "U";
            // 
            // lblNameL
            // 
            this.lblNameL.AutoSize = true;
            this.lblNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.lblNameL.Location = new System.Drawing.Point(8, 6);
            this.lblNameL.Name = "lblNameL";
            this.lblNameL.Size = new System.Drawing.Size(44, 44);
            this.lblNameL.TabIndex = 0;
            this.lblNameL.Text = "Y";
            // 
            // panelPlayerRight
            // 
            this.panelPlayerRight.Controls.Add(this.lblScoreR);
            this.panelPlayerRight.Controls.Add(this.lbldirR);
            this.panelPlayerRight.Controls.Add(this.lblNameR);
            this.panelPlayerRight.Location = new System.Drawing.Point(253, 12);
            this.panelPlayerRight.Name = "panelPlayerRight";
            this.panelPlayerRight.Size = new System.Drawing.Size(211, 58);
            this.panelPlayerRight.TabIndex = 5;
            // 
            // lblScoreR
            // 
            this.lblScoreR.AutoSize = true;
            this.lblScoreR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.lblScoreR.Location = new System.Drawing.Point(86, 8);
            this.lblScoreR.Name = "lblScoreR";
            this.lblScoreR.Size = new System.Drawing.Size(41, 44);
            this.lblScoreR.TabIndex = 4;
            this.lblScoreR.Text = "0";
            // 
            // lbldirR
            // 
            this.lbldirR.AutoSize = true;
            this.lbldirR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.lbldirR.Location = new System.Drawing.Point(46, 8);
            this.lbldirR.Name = "lbldirR";
            this.lbldirR.Size = new System.Drawing.Size(47, 44);
            this.lbldirR.TabIndex = 1;
            this.lbldirR.Text = "U";
            // 
            // lblNameR
            // 
            this.lblNameR.AutoSize = true;
            this.lblNameR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.lblNameR.Location = new System.Drawing.Point(12, 8);
            this.lblNameR.Name = "lblNameR";
            this.lblNameR.Size = new System.Drawing.Size(45, 44);
            this.lblNameR.TabIndex = 0;
            this.lblNameR.Text = "X";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 541);
            this.Controls.Add(this.panelPlayerRight);
            this.Controls.Add(this.panelPlayerLeft);
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPlayerLeft.ResumeLayout(false);
            this.panelPlayerLeft.PerformLayout();
            this.panelPlayerRight.ResumeLayout(false);
            this.panelPlayerRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelPlayerLeft;
        private System.Windows.Forms.Label lblScoreL;
        private System.Windows.Forms.Label lbldirL;
        private System.Windows.Forms.Label lblNameL;
        private System.Windows.Forms.Panel panelPlayerRight;
        private System.Windows.Forms.Label lblScoreR;
        private System.Windows.Forms.Label lbldirR;
        private System.Windows.Forms.Label lblNameR;
    }
}

