namespace SimpleShapes_P5
{
    partial class SimpleShapes
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
            this.ShapeComboBox = new System.Windows.Forms.ComboBox();
            this.P1box = new System.Windows.Forms.GroupBox();
            this.P2box = new System.Windows.Forms.GroupBox();
            this.P3box = new System.Windows.Forms.GroupBox();
            this.P4box = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // ShapeComboBox
            // 
            this.ShapeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Rectangle",
            "Square",
            "Parallelogram",
            "Trapezoid"});
            this.ShapeComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ShapeComboBox.FormattingEnabled = true;
            this.ShapeComboBox.Items.AddRange(new object[] {
            "Rectangle",
            "Square",
            "Parallelogram",
            "Trapezoid"});
            this.ShapeComboBox.Location = new System.Drawing.Point(30, 31);
            this.ShapeComboBox.Name = "ShapeComboBox";
            this.ShapeComboBox.Size = new System.Drawing.Size(144, 21);
            this.ShapeComboBox.TabIndex = 0;
            // 
            // P1box
            // 
            this.P1box.Location = new System.Drawing.Point(30, 83);
            this.P1box.Name = "P1box";
            this.P1box.Size = new System.Drawing.Size(144, 46);
            this.P1box.TabIndex = 1;
            this.P1box.TabStop = false;
            this.P1box.Text = "Point 1";
            // 
            // P2box
            // 
            this.P2box.Location = new System.Drawing.Point(30, 146);
            this.P2box.Name = "P2box";
            this.P2box.Size = new System.Drawing.Size(144, 46);
            this.P2box.TabIndex = 2;
            this.P2box.TabStop = false;
            this.P2box.Text = "Point 2";
            // 
            // P3box
            // 
            this.P3box.Location = new System.Drawing.Point(30, 198);
            this.P3box.Name = "P3box";
            this.P3box.Size = new System.Drawing.Size(144, 46);
            this.P3box.TabIndex = 2;
            this.P3box.TabStop = false;
            this.P3box.Text = "Point 3";
            // 
            // P4box
            // 
            this.P4box.Location = new System.Drawing.Point(30, 250);
            this.P4box.Name = "P4box";
            this.P4box.Size = new System.Drawing.Size(144, 46);
            this.P4box.TabIndex = 2;
            this.P4box.TabStop = false;
            this.P4box.Text = "Point 4";
            // 
            // SimpleShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(840, 479);
            this.Controls.Add(this.P4box);
            this.Controls.Add(this.P3box);
            this.Controls.Add(this.P2box);
            this.Controls.Add(this.P1box);
            this.Controls.Add(this.ShapeComboBox);
            this.Name = "SimpleShapes";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ShapeComboBox;
        private System.Windows.Forms.GroupBox P1box;
        private System.Windows.Forms.GroupBox P2box;
        private System.Windows.Forms.GroupBox P3box;
        private System.Windows.Forms.GroupBox P4box;
    }
}

