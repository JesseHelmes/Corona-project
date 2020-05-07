namespace Corona_project.TOPO
{
    partial class frmTopo
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
            this.pcbMap = new System.Windows.Forms.PictureBox();
            this.lbxAnswer = new System.Windows.Forms.ListBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCurrentPoints = new System.Windows.Forms.Label();
            this.lblMaxPoints = new System.Windows.Forms.Label();
            this.lblClickOp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMap
            // 
            this.pcbMap.BackColor = System.Drawing.Color.Transparent;
            this.pcbMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbMap.Image = global::Corona_project.Properties.Resources.knp;
            this.pcbMap.Location = new System.Drawing.Point(109, 12);
            this.pcbMap.Name = "pcbMap";
            this.pcbMap.Size = new System.Drawing.Size(667, 788);
            this.pcbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMap.TabIndex = 0;
            this.pcbMap.TabStop = false;
            this.pcbMap.Click += new System.EventHandler(this.pcbMap_Click);
            // 
            // lbxAnswer
            // 
            this.lbxAnswer.FormattingEnabled = true;
            this.lbxAnswer.Location = new System.Drawing.Point(706, 334);
            this.lbxAnswer.Name = "lbxAnswer";
            this.lbxAnswer.Size = new System.Drawing.Size(55, 17);
            this.lbxAnswer.TabIndex = 999;
            this.lbxAnswer.TabStop = false;
            this.lbxAnswer.Visible = false;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(42, 114);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(37, 13);
            this.lblProvince.TabIndex = 1000;
            this.lblProvince.Text = "lblFind";
            // 
            // lblCurrentPoints
            // 
            this.lblCurrentPoints.AutoSize = true;
            this.lblCurrentPoints.Location = new System.Drawing.Point(26, 12);
            this.lblCurrentPoints.Name = "lblCurrentPoints";
            this.lblCurrentPoints.Size = new System.Drawing.Size(19, 13);
            this.lblCurrentPoints.TabIndex = 1001;
            this.lblCurrentPoints.Text = "12";
            // 
            // lblMaxPoints
            // 
            this.lblMaxPoints.AutoSize = true;
            this.lblMaxPoints.Location = new System.Drawing.Point(42, 12);
            this.lblMaxPoints.Name = "lblMaxPoints";
            this.lblMaxPoints.Size = new System.Drawing.Size(27, 13);
            this.lblMaxPoints.TabIndex = 1002;
            this.lblMaxPoints.Text = "/ 12";
            // 
            // lblClickOp
            // 
            this.lblClickOp.AutoSize = true;
            this.lblClickOp.Location = new System.Drawing.Point(21, 95);
            this.lblClickOp.Name = "lblClickOp";
            this.lblClickOp.Size = new System.Drawing.Size(48, 13);
            this.lblClickOp.TabIndex = 1003;
            this.lblClickOp.Text = "Click op:";
            // 
            // frmTopo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(843, 812);
            this.Controls.Add(this.lblClickOp);
            this.Controls.Add(this.lblMaxPoints);
            this.Controls.Add(this.lblCurrentPoints);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.pcbMap);
            this.Controls.Add(this.lbxAnswer);
            this.DoubleBuffered = true;
            this.Name = "frmTopo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Topo";
            this.Load += new System.EventHandler(this.frmTopo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMap;
        private System.Windows.Forms.ListBox lbxAnswer;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCurrentPoints;
        private System.Windows.Forms.Label lblMaxPoints;
        private System.Windows.Forms.Label lblClickOp;
    }
}