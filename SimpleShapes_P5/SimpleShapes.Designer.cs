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
            this.DrawButton = new System.Windows.Forms.Button();
            this.x_P1 = new System.Windows.Forms.TextBox();
            this.y_P1 = new System.Windows.Forms.TextBox();
            this.x_P2 = new System.Windows.Forms.TextBox();
            this.y_P2 = new System.Windows.Forms.TextBox();
            this.y_P3 = new System.Windows.Forms.TextBox();
            this.x_P3 = new System.Windows.Forms.TextBox();
            this.y_P4 = new System.Windows.Forms.TextBox();
            this.x_P4 = new System.Windows.Forms.TextBox();
            this.P1box.SuspendLayout();
            this.P2box.SuspendLayout();
            this.P3box.SuspendLayout();
            this.P4box.SuspendLayout();
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
            this.ShapeComboBox.SelectedIndexChanged += new System.EventHandler(this.ShapeComboBox_SelectedIndexChanged);
            // 
            // P1box
            // 
            this.P1box.Controls.Add(this.y_P1);
            this.P1box.Controls.Add(this.x_P1);
            this.P1box.Location = new System.Drawing.Point(30, 83);
            this.P1box.Name = "P1box";
            this.P1box.Size = new System.Drawing.Size(144, 62);
            this.P1box.TabIndex = 1;
            this.P1box.TabStop = false;
            this.P1box.Text = "Point 1";
            // 
            // P2box
            // 
            this.P2box.Controls.Add(this.y_P2);
            this.P2box.Controls.Add(this.x_P2);
            this.P2box.Location = new System.Drawing.Point(30, 159);
            this.P2box.Name = "P2box";
            this.P2box.Size = new System.Drawing.Size(144, 62);
            this.P2box.TabIndex = 2;
            this.P2box.TabStop = false;
            this.P2box.Text = "Point 2";
            // 
            // P3box
            // 
            this.P3box.Controls.Add(this.x_P3);
            this.P3box.Controls.Add(this.y_P3);
            this.P3box.Location = new System.Drawing.Point(30, 236);
            this.P3box.Name = "P3box";
            this.P3box.Size = new System.Drawing.Size(144, 70);
            this.P3box.TabIndex = 2;
            this.P3box.TabStop = false;
            this.P3box.Text = "Point 3";
            // 
            // P4box
            // 
            this.P4box.Controls.Add(this.x_P4);
            this.P4box.Controls.Add(this.y_P4);
            this.P4box.Location = new System.Drawing.Point(30, 321);
            this.P4box.Name = "P4box";
            this.P4box.Size = new System.Drawing.Size(144, 59);
            this.P4box.TabIndex = 2;
            this.P4box.TabStop = false;
            this.P4box.Text = "Point 4";
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(30, 401);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(144, 39);
            this.DrawButton.TabIndex = 3;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // x_P1
            // 
            this.x_P1.Location = new System.Drawing.Point(6, 36);
            this.x_P1.Name = "x_P1";
            this.x_P1.Size = new System.Drawing.Size(43, 20);
            this.x_P1.TabIndex = 0;
            // 
            // y_P1
            // 
            this.y_P1.Location = new System.Drawing.Point(75, 36);
            this.y_P1.Name = "y_P1";
            this.y_P1.Size = new System.Drawing.Size(43, 20);
            this.y_P1.TabIndex = 1;
            // 
            // x_P2
            // 
            this.x_P2.Location = new System.Drawing.Point(6, 36);
            this.x_P2.Name = "x_P2";
            this.x_P2.Size = new System.Drawing.Size(43, 20);
            this.x_P2.TabIndex = 1;
            // 
            // y_P2
            // 
            this.y_P2.Location = new System.Drawing.Point(75, 36);
            this.y_P2.Name = "y_P2";
            this.y_P2.Size = new System.Drawing.Size(43, 20);
            this.y_P2.TabIndex = 2;
            // 
            // y_P3
            // 
            this.y_P3.Location = new System.Drawing.Point(75, 44);
            this.y_P3.Name = "y_P3";
            this.y_P3.Size = new System.Drawing.Size(43, 20);
            this.y_P3.TabIndex = 1;
            // 
            // x_P3
            // 
            this.x_P3.Location = new System.Drawing.Point(6, 44);
            this.x_P3.Name = "x_P3";
            this.x_P3.Size = new System.Drawing.Size(43, 20);
            this.x_P3.TabIndex = 2;
            // 
            // y_P4
            // 
            this.y_P4.Location = new System.Drawing.Point(75, 33);
            this.y_P4.Name = "y_P4";
            this.y_P4.Size = new System.Drawing.Size(43, 20);
            this.y_P4.TabIndex = 1;
            // 
            // x_P4
            // 
            this.x_P4.Location = new System.Drawing.Point(6, 33);
            this.x_P4.Name = "x_P4";
            this.x_P4.Size = new System.Drawing.Size(43, 20);
            this.x_P4.TabIndex = 2;
            // 
            // SimpleShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(840, 479);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.P4box);
            this.Controls.Add(this.P3box);
            this.Controls.Add(this.P2box);
            this.Controls.Add(this.P1box);
            this.Controls.Add(this.ShapeComboBox);
            this.Name = "SimpleShapes";
            this.Text = "Form1";
            this.P1box.ResumeLayout(false);
            this.P1box.PerformLayout();
            this.P2box.ResumeLayout(false);
            this.P2box.PerformLayout();
            this.P3box.ResumeLayout(false);
            this.P3box.PerformLayout();
            this.P4box.ResumeLayout(false);
            this.P4box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ShapeComboBox;
        private System.Windows.Forms.GroupBox P1box;
        private System.Windows.Forms.GroupBox P2box;
        private System.Windows.Forms.GroupBox P3box;
        private System.Windows.Forms.GroupBox P4box;
        private System.Windows.Forms.TextBox y_P1;
        private System.Windows.Forms.TextBox x_P1;
        private System.Windows.Forms.TextBox y_P2;
        private System.Windows.Forms.TextBox x_P2;
        private System.Windows.Forms.TextBox x_P3;
        private System.Windows.Forms.TextBox y_P3;
        private System.Windows.Forms.TextBox x_P4;
        private System.Windows.Forms.TextBox y_P4;
        private System.Windows.Forms.Button DrawButton;
    }
}

