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
            this.Y1 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.Label();
            this.y_P1 = new System.Windows.Forms.TextBox();
            this.x_P1 = new System.Windows.Forms.TextBox();
            this.P2box = new System.Windows.Forms.GroupBox();
            this.Y2 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.Label();
            this.y_P2 = new System.Windows.Forms.TextBox();
            this.x_P2 = new System.Windows.Forms.TextBox();
            this.P3box = new System.Windows.Forms.GroupBox();
            this.Y3 = new System.Windows.Forms.Label();
            this.X3 = new System.Windows.Forms.Label();
            this.x_P3 = new System.Windows.Forms.TextBox();
            this.y_P3 = new System.Windows.Forms.TextBox();
            this.P4box = new System.Windows.Forms.GroupBox();
            this.Y4 = new System.Windows.Forms.Label();
            this.X4 = new System.Windows.Forms.Label();
            this.x_P4 = new System.Windows.Forms.TextBox();
            this.y_P4 = new System.Windows.Forms.TextBox();
            this.DrawButton = new System.Windows.Forms.Button();
            this.QuadGenerator = new System.Windows.Forms.GroupBox();
            this.p3Label = new System.Windows.Forms.Label();
            this.p4Label = new System.Windows.Forms.Label();
            this.p1Label = new System.Windows.Forms.Label();
            this.p2Label = new System.Windows.Forms.Label();
            this.P3TextBox = new System.Windows.Forms.TextBox();
            this.P4TextBox = new System.Windows.Forms.TextBox();
            this.P1TextBox = new System.Windows.Forms.TextBox();
            this.P2TextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShapeNameLabel = new System.Windows.Forms.Label();
            this.PerimeterLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.PerimeterTextBox = new System.Windows.Forms.TextBox();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.rectCountBox = new System.Windows.Forms.TextBox();
            this.squareCountBox = new System.Windows.Forms.TextBox();
            this.ParaCountBox = new System.Windows.Forms.TextBox();
            this.TrapCountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.P1box.SuspendLayout();
            this.P2box.SuspendLayout();
            this.P3box.SuspendLayout();
            this.P4box.SuspendLayout();
            this.QuadGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.P1box.Controls.Add(this.Y1);
            this.P1box.Controls.Add(this.X1);
            this.P1box.Controls.Add(this.y_P1);
            this.P1box.Controls.Add(this.x_P1);
            this.P1box.Location = new System.Drawing.Point(30, 83);
            this.P1box.Name = "P1box";
            this.P1box.Size = new System.Drawing.Size(144, 62);
            this.P1box.TabIndex = 1;
            this.P1box.TabStop = false;
            this.P1box.Text = "Point 1";
            // 
            // Y1
            // 
            this.Y1.AutoSize = true;
            this.Y1.Location = new System.Drawing.Point(83, 20);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(20, 13);
            this.Y1.TabIndex = 3;
            this.Y1.Text = "Y1";
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Location = new System.Drawing.Point(13, 20);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(20, 13);
            this.X1.TabIndex = 2;
            this.X1.Text = "X1";
            // 
            // y_P1
            // 
            this.y_P1.Location = new System.Drawing.Point(75, 36);
            this.y_P1.Name = "y_P1";
            this.y_P1.Size = new System.Drawing.Size(43, 20);
            this.y_P1.TabIndex = 1;
            // 
            // x_P1
            // 
            this.x_P1.Location = new System.Drawing.Point(6, 36);
            this.x_P1.Name = "x_P1";
            this.x_P1.Size = new System.Drawing.Size(43, 20);
            this.x_P1.TabIndex = 0;
            this.x_P1.TextChanged += new System.EventHandler(this.x_P1_TextChanged);
            // 
            // P2box
            // 
            this.P2box.Controls.Add(this.Y2);
            this.P2box.Controls.Add(this.X2);
            this.P2box.Controls.Add(this.y_P2);
            this.P2box.Controls.Add(this.x_P2);
            this.P2box.Location = new System.Drawing.Point(30, 159);
            this.P2box.Name = "P2box";
            this.P2box.Size = new System.Drawing.Size(144, 62);
            this.P2box.TabIndex = 2;
            this.P2box.TabStop = false;
            this.P2box.Text = "Point 2";
            // 
            // Y2
            // 
            this.Y2.AutoSize = true;
            this.Y2.Location = new System.Drawing.Point(83, 20);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(20, 13);
            this.Y2.TabIndex = 4;
            this.Y2.Text = "Y2";
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Location = new System.Drawing.Point(14, 20);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(20, 13);
            this.X2.TabIndex = 3;
            this.X2.Text = "X2";
            // 
            // y_P2
            // 
            this.y_P2.Location = new System.Drawing.Point(75, 36);
            this.y_P2.Name = "y_P2";
            this.y_P2.Size = new System.Drawing.Size(43, 20);
            this.y_P2.TabIndex = 2;
            // 
            // x_P2
            // 
            this.x_P2.Location = new System.Drawing.Point(6, 36);
            this.x_P2.Name = "x_P2";
            this.x_P2.Size = new System.Drawing.Size(43, 20);
            this.x_P2.TabIndex = 1;
            // 
            // P3box
            // 
            this.P3box.Controls.Add(this.Y3);
            this.P3box.Controls.Add(this.X3);
            this.P3box.Controls.Add(this.x_P3);
            this.P3box.Controls.Add(this.y_P3);
            this.P3box.Location = new System.Drawing.Point(30, 236);
            this.P3box.Name = "P3box";
            this.P3box.Size = new System.Drawing.Size(144, 70);
            this.P3box.TabIndex = 2;
            this.P3box.TabStop = false;
            this.P3box.Text = "Point 3";
            // 
            // Y3
            // 
            this.Y3.AutoSize = true;
            this.Y3.Location = new System.Drawing.Point(83, 28);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(20, 13);
            this.Y3.TabIndex = 4;
            this.Y3.Text = "Y3";
            // 
            // X3
            // 
            this.X3.AutoSize = true;
            this.X3.Location = new System.Drawing.Point(14, 28);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(20, 13);
            this.X3.TabIndex = 3;
            this.X3.Text = "X3";
            // 
            // x_P3
            // 
            this.x_P3.Location = new System.Drawing.Point(6, 44);
            this.x_P3.Name = "x_P3";
            this.x_P3.Size = new System.Drawing.Size(43, 20);
            this.x_P3.TabIndex = 2;
            // 
            // y_P3
            // 
            this.y_P3.Location = new System.Drawing.Point(75, 44);
            this.y_P3.Name = "y_P3";
            this.y_P3.Size = new System.Drawing.Size(43, 20);
            this.y_P3.TabIndex = 1;
            // 
            // P4box
            // 
            this.P4box.Controls.Add(this.Y4);
            this.P4box.Controls.Add(this.X4);
            this.P4box.Controls.Add(this.x_P4);
            this.P4box.Controls.Add(this.y_P4);
            this.P4box.Location = new System.Drawing.Point(30, 321);
            this.P4box.Name = "P4box";
            this.P4box.Size = new System.Drawing.Size(144, 59);
            this.P4box.TabIndex = 2;
            this.P4box.TabStop = false;
            this.P4box.Text = "Point 4";
            // 
            // Y4
            // 
            this.Y4.AutoSize = true;
            this.Y4.Location = new System.Drawing.Point(83, 17);
            this.Y4.Name = "Y4";
            this.Y4.Size = new System.Drawing.Size(20, 13);
            this.Y4.TabIndex = 4;
            this.Y4.Text = "Y4";
            // 
            // X4
            // 
            this.X4.AutoSize = true;
            this.X4.Location = new System.Drawing.Point(14, 16);
            this.X4.Name = "X4";
            this.X4.Size = new System.Drawing.Size(20, 13);
            this.X4.TabIndex = 3;
            this.X4.Text = "X4";
            // 
            // x_P4
            // 
            this.x_P4.Location = new System.Drawing.Point(6, 33);
            this.x_P4.Name = "x_P4";
            this.x_P4.Size = new System.Drawing.Size(43, 20);
            this.x_P4.TabIndex = 2;
            // 
            // y_P4
            // 
            this.y_P4.Location = new System.Drawing.Point(75, 33);
            this.y_P4.Name = "y_P4";
            this.y_P4.Size = new System.Drawing.Size(43, 20);
            this.y_P4.TabIndex = 1;
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
            // QuadGenerator
            // 
            this.QuadGenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.QuadGenerator.Controls.Add(this.p3Label);
            this.QuadGenerator.Controls.Add(this.p4Label);
            this.QuadGenerator.Controls.Add(this.p1Label);
            this.QuadGenerator.Controls.Add(this.p2Label);
            this.QuadGenerator.Controls.Add(this.P3TextBox);
            this.QuadGenerator.Controls.Add(this.P4TextBox);
            this.QuadGenerator.Controls.Add(this.P1TextBox);
            this.QuadGenerator.Controls.Add(this.P2TextBox);
            this.QuadGenerator.Controls.Add(this.pictureBox1);
            this.QuadGenerator.Controls.Add(this.ShapeNameLabel);
            this.QuadGenerator.Controls.Add(this.PerimeterLabel);
            this.QuadGenerator.Controls.Add(this.AreaLabel);
            this.QuadGenerator.Controls.Add(this.PerimeterTextBox);
            this.QuadGenerator.Controls.Add(this.AreaTextBox);
            this.QuadGenerator.Location = new System.Drawing.Point(311, 32);
            this.QuadGenerator.Name = "QuadGenerator";
            this.QuadGenerator.Size = new System.Drawing.Size(467, 275);
            this.QuadGenerator.TabIndex = 4;
            this.QuadGenerator.TabStop = false;
            this.QuadGenerator.Text = "Quadrilateral Generator";
            // 
            // p3Label
            // 
            this.p3Label.AutoSize = true;
            this.p3Label.Location = new System.Drawing.Point(406, 193);
            this.p3Label.Name = "p3Label";
            this.p3Label.Size = new System.Drawing.Size(20, 13);
            this.p3Label.TabIndex = 13;
            this.p3Label.Text = "P3";
            // 
            // p4Label
            // 
            this.p4Label.AutoSize = true;
            this.p4Label.Location = new System.Drawing.Point(406, 56);
            this.p4Label.Name = "p4Label";
            this.p4Label.Size = new System.Drawing.Size(20, 13);
            this.p4Label.TabIndex = 12;
            this.p4Label.Text = "P4";
            // 
            // p1Label
            // 
            this.p1Label.AutoSize = true;
            this.p1Label.Location = new System.Drawing.Point(40, 191);
            this.p1Label.Name = "p1Label";
            this.p1Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.p1Label.Size = new System.Drawing.Size(20, 13);
            this.p1Label.TabIndex = 11;
            this.p1Label.Text = "P1";
            // 
            // p2Label
            // 
            this.p2Label.AutoSize = true;
            this.p2Label.Location = new System.Drawing.Point(40, 54);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(20, 13);
            this.p2Label.TabIndex = 10;
            this.p2Label.Text = "P1";
            // 
            // P3TextBox
            // 
            this.P3TextBox.Location = new System.Drawing.Point(350, 188);
            this.P3TextBox.Name = "P3TextBox";
            this.P3TextBox.Size = new System.Drawing.Size(49, 20);
            this.P3TextBox.TabIndex = 9;
            // 
            // P4TextBox
            // 
            this.P4TextBox.Location = new System.Drawing.Point(350, 51);
            this.P4TextBox.Name = "P4TextBox";
            this.P4TextBox.Size = new System.Drawing.Size(49, 20);
            this.P4TextBox.TabIndex = 8;
            // 
            // P1TextBox
            // 
            this.P1TextBox.Location = new System.Drawing.Point(66, 188);
            this.P1TextBox.Name = "P1TextBox";
            this.P1TextBox.Size = new System.Drawing.Size(49, 20);
            this.P1TextBox.TabIndex = 7;
            // 
            // P2TextBox
            // 
            this.P2TextBox.Location = new System.Drawing.Point(66, 51);
            this.P2TextBox.Name = "P2TextBox";
            this.P2TextBox.Size = new System.Drawing.Size(49, 20);
            this.P2TextBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(121, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ShapeNameLabel
            // 
            this.ShapeNameLabel.AutoSize = true;
            this.ShapeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeNameLabel.Location = new System.Drawing.Point(17, 26);
            this.ShapeNameLabel.Name = "ShapeNameLabel";
            this.ShapeNameLabel.Size = new System.Drawing.Size(0, 13);
            this.ShapeNameLabel.TabIndex = 4;
            // 
            // PerimeterLabel
            // 
            this.PerimeterLabel.AutoSize = true;
            this.PerimeterLabel.Location = new System.Drawing.Point(142, 252);
            this.PerimeterLabel.Name = "PerimeterLabel";
            this.PerimeterLabel.Size = new System.Drawing.Size(51, 13);
            this.PerimeterLabel.TabIndex = 3;
            this.PerimeterLabel.Text = "Perimeter";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(17, 252);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(29, 13);
            this.AreaLabel.TabIndex = 2;
            this.AreaLabel.Text = "Area";
            // 
            // PerimeterTextBox
            // 
            this.PerimeterTextBox.Location = new System.Drawing.Point(199, 249);
            this.PerimeterTextBox.Name = "PerimeterTextBox";
            this.PerimeterTextBox.Size = new System.Drawing.Size(76, 20);
            this.PerimeterTextBox.TabIndex = 1;
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(52, 249);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(76, 20);
            this.AreaTextBox.TabIndex = 0;
            // 
            // rectCountBox
            // 
            this.rectCountBox.Location = new System.Drawing.Point(456, 349);
            this.rectCountBox.Name = "rectCountBox";
            this.rectCountBox.Size = new System.Drawing.Size(100, 20);
            this.rectCountBox.TabIndex = 5;
            // 
            // squareCountBox
            // 
            this.squareCountBox.Location = new System.Drawing.Point(456, 375);
            this.squareCountBox.Name = "squareCountBox";
            this.squareCountBox.Size = new System.Drawing.Size(100, 20);
            this.squareCountBox.TabIndex = 6;
            // 
            // ParaCountBox
            // 
            this.ParaCountBox.Location = new System.Drawing.Point(456, 401);
            this.ParaCountBox.Name = "ParaCountBox";
            this.ParaCountBox.Size = new System.Drawing.Size(100, 20);
            this.ParaCountBox.TabIndex = 7;
            // 
            // TrapCountBox
            // 
            this.TrapCountBox.Location = new System.Drawing.Point(456, 429);
            this.TrapCountBox.Name = "TrapCountBox";
            this.TrapCountBox.Size = new System.Drawing.Size(100, 20);
            this.TrapCountBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "# of Rectangles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "# of Squares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "# of Parallelograms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "# of Trapezoids";
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(722, 313);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(56, 20);
            this.countBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quadrilaterals Generated";
            // 
            // SimpleShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(840, 479);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrapCountBox);
            this.Controls.Add(this.ParaCountBox);
            this.Controls.Add(this.squareCountBox);
            this.Controls.Add(this.rectCountBox);
            this.Controls.Add(this.QuadGenerator);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.P4box);
            this.Controls.Add(this.P3box);
            this.Controls.Add(this.P2box);
            this.Controls.Add(this.P1box);
            this.Controls.Add(this.ShapeComboBox);
            this.Name = "SimpleShapes";
            this.Text = "Quadrilateral Generator-anator";
            this.Load += new System.EventHandler(this.SimpleShapes_Load);
            this.P1box.ResumeLayout(false);
            this.P1box.PerformLayout();
            this.P2box.ResumeLayout(false);
            this.P2box.PerformLayout();
            this.P3box.ResumeLayout(false);
            this.P3box.PerformLayout();
            this.P4box.ResumeLayout(false);
            this.P4box.PerformLayout();
            this.QuadGenerator.ResumeLayout(false);
            this.QuadGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label Y1;
        private System.Windows.Forms.Label X1;
        private System.Windows.Forms.Label Y2;
        private System.Windows.Forms.Label X2;
        private System.Windows.Forms.Label Y3;
        private System.Windows.Forms.Label X3;
        private System.Windows.Forms.Label Y4;
        private System.Windows.Forms.Label X4;
        private System.Windows.Forms.GroupBox QuadGenerator;
        private System.Windows.Forms.Label PerimeterLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.TextBox PerimeterTextBox;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Label ShapeNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label p3Label;
        private System.Windows.Forms.Label p4Label;
        private System.Windows.Forms.Label p1Label;
        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.TextBox P3TextBox;
        private System.Windows.Forms.TextBox P4TextBox;
        private System.Windows.Forms.TextBox P1TextBox;
        private System.Windows.Forms.TextBox P2TextBox;
        private System.Windows.Forms.TextBox rectCountBox;
        private System.Windows.Forms.TextBox squareCountBox;
        private System.Windows.Forms.TextBox ParaCountBox;
        private System.Windows.Forms.TextBox TrapCountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label label5;
    }
}

