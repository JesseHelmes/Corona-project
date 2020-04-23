namespace Corona_project.Teken_canvas
{
    partial class tekenCanvasFrm
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
            this.canvasPicBox = new System.Windows.Forms.PictureBox();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.btnWissen = new System.Windows.Forms.Button();
            this.brushSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSize)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasPicBox
            // 
            this.canvasPicBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.canvasPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPicBox.BackColor = System.Drawing.Color.White;
            this.canvasPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPicBox.Location = new System.Drawing.Point(118, 6);
            this.canvasPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.canvasPicBox.Name = "canvasPicBox";
            this.canvasPicBox.Size = new System.Drawing.Size(473, 355);
            this.canvasPicBox.TabIndex = 0;
            this.canvasPicBox.TabStop = false;
            this.canvasPicBox.SizeChanged += new System.EventHandler(this.canvasPicBox_SizeChanged);
            this.canvasPicBox.Click += new System.EventHandler(this.canvasPicBox_Click);
            this.canvasPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPicBox_Paint);
            this.canvasPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPicBox_MouseDown);
            this.canvasPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPicBox_MouseMove);
            this.canvasPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPicBox_MouseUp);
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(11, 11);
            this.btnPickColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(79, 24);
            this.btnPickColor.TabIndex = 22;
            this.btnPickColor.Text = "Kies kleur";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(11, 40);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(75, 23);
            this.btnWissen.TabIndex = 23;
            this.btnWissen.Text = "wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // brushSize
            // 
            this.brushSize.Location = new System.Drawing.Point(11, 69);
            this.brushSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brushSize.Name = "brushSize";
            this.brushSize.Size = new System.Drawing.Size(64, 20);
            this.brushSize.TabIndex = 24;
            this.brushSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tekenCanvasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.brushSize);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.btnPickColor);
            this.Controls.Add(this.canvasPicBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "tekenCanvasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tekenCanvasFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvasPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvasPicBox;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.NumericUpDown brushSize;
    }
}