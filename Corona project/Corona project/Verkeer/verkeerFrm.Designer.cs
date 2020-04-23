namespace Corona_project.Verkeer
{
    partial class verkeerFrm
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
            this.antwoordenFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.antwoordBtn1 = new System.Windows.Forms.Button();
            this.antwoordBtn2 = new System.Windows.Forms.Button();
            this.antwoordBtn3 = new System.Windows.Forms.Button();
            this.antwoordBtn4 = new System.Windows.Forms.Button();
            this.vraagLbl = new System.Windows.Forms.Label();
            this.signPicBox = new System.Windows.Forms.PictureBox();
            this.antwoordenFlowPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // antwoordenFlowPnl
            // 
            this.antwoordenFlowPnl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.antwoordenFlowPnl.Controls.Add(this.antwoordBtn1);
            this.antwoordenFlowPnl.Controls.Add(this.antwoordBtn2);
            this.antwoordenFlowPnl.Controls.Add(this.antwoordBtn3);
            this.antwoordenFlowPnl.Controls.Add(this.antwoordBtn4);
            this.antwoordenFlowPnl.Location = new System.Drawing.Point(12, 322);
            this.antwoordenFlowPnl.Name = "antwoordenFlowPnl";
            this.antwoordenFlowPnl.Size = new System.Drawing.Size(776, 162);
            this.antwoordenFlowPnl.TabIndex = 2;
            // 
            // antwoordBtn1
            // 
            this.antwoordBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwoordBtn1.Location = new System.Drawing.Point(3, 3);
            this.antwoordBtn1.Name = "antwoordBtn1";
            this.antwoordBtn1.Size = new System.Drawing.Size(381, 75);
            this.antwoordBtn1.TabIndex = 0;
            this.antwoordBtn1.TabStop = false;
            this.antwoordBtn1.Text = "antwoord1";
            this.antwoordBtn1.UseVisualStyleBackColor = true;
            this.antwoordBtn1.Click += new System.EventHandler(this.controlleerAntwoord);
            // 
            // antwoordBtn2
            // 
            this.antwoordBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwoordBtn2.Location = new System.Drawing.Point(390, 3);
            this.antwoordBtn2.Name = "antwoordBtn2";
            this.antwoordBtn2.Size = new System.Drawing.Size(381, 75);
            this.antwoordBtn2.TabIndex = 1;
            this.antwoordBtn2.TabStop = false;
            this.antwoordBtn2.Text = "antwoord2";
            this.antwoordBtn2.UseVisualStyleBackColor = true;
            this.antwoordBtn2.Click += new System.EventHandler(this.controlleerAntwoord);
            // 
            // antwoordBtn3
            // 
            this.antwoordBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwoordBtn3.Location = new System.Drawing.Point(3, 84);
            this.antwoordBtn3.Name = "antwoordBtn3";
            this.antwoordBtn3.Size = new System.Drawing.Size(381, 75);
            this.antwoordBtn3.TabIndex = 2;
            this.antwoordBtn3.TabStop = false;
            this.antwoordBtn3.Text = "antwoord3";
            this.antwoordBtn3.UseVisualStyleBackColor = true;
            this.antwoordBtn3.Click += new System.EventHandler(this.controlleerAntwoord);
            // 
            // antwoordBtn4
            // 
            this.antwoordBtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwoordBtn4.Location = new System.Drawing.Point(390, 84);
            this.antwoordBtn4.Name = "antwoordBtn4";
            this.antwoordBtn4.Size = new System.Drawing.Size(381, 75);
            this.antwoordBtn4.TabIndex = 3;
            this.antwoordBtn4.TabStop = false;
            this.antwoordBtn4.Text = "antwoord4";
            this.antwoordBtn4.UseVisualStyleBackColor = true;
            this.antwoordBtn4.Click += new System.EventHandler(this.controlleerAntwoord);
            // 
            // vraagLbl
            // 
            this.vraagLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.vraagLbl.AutoSize = true;
            this.vraagLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vraagLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vraagLbl.Location = new System.Drawing.Point(356, 264);
            this.vraagLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vraagLbl.MaximumSize = new System.Drawing.Size(410, 0);
            this.vraagLbl.Name = "vraagLbl";
            this.vraagLbl.Size = new System.Drawing.Size(88, 13);
            this.vraagLbl.TabIndex = 3;
            this.vraagLbl.Text = "dit is de vraag";
            this.vraagLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signPicBox
            // 
            this.signPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signPicBox.BackColor = System.Drawing.Color.White;
            this.signPicBox.Location = new System.Drawing.Point(191, 12);
            this.signPicBox.Name = "signPicBox";
            this.signPicBox.Size = new System.Drawing.Size(418, 242);
            this.signPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signPicBox.TabIndex = 0;
            this.signPicBox.TabStop = false;
            // 
            // verkeerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.vraagLbl);
            this.Controls.Add(this.antwoordenFlowPnl);
            this.Controls.Add(this.signPicBox);
            this.MinimumSize = new System.Drawing.Size(816, 535);
            this.Name = "verkeerFrm";
            this.Text = "verkeerFrm";
            this.Load += new System.EventHandler(this.verkeerFrm_Load);
            this.antwoordenFlowPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox signPicBox;
        private System.Windows.Forms.FlowLayoutPanel antwoordenFlowPnl;
        private System.Windows.Forms.Button antwoordBtn1;
        private System.Windows.Forms.Button antwoordBtn2;
        private System.Windows.Forms.Button antwoordBtn3;
        private System.Windows.Forms.Button antwoordBtn4;
        private System.Windows.Forms.Label vraagLbl;
    }
}