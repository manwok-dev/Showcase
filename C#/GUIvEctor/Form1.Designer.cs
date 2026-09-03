namespace GUIvEctor
{
    partial class Form1
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
            btn1 = new Button();
            x1inp = new TextBox();
            x1label = new Label();
            y1inp = new TextBox();
            y1label = new Label();
            z1inp = new TextBox();
            z1label = new Label();
            btn2 = new Button();
            y2label = new Label();
            z2label = new Label();
            y2inp = new TextBox();
            z2inp = new TextBox();
            x2label = new Label();
            x2inp = new TextBox();
            outpt = new TextBox();
            label1 = new Label();
            vikAdd = new Button();
            vikSubtr = new Button();
            vikCross = new Button();
            vikSkalar = new Button();
            vikLeng = new Button();
            vikAngel = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(51, 59);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 28);
            btn1.TabIndex = 0;
            btn1.Text = "Submit Vector 1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // x1inp
            // 
            x1inp.Location = new Point(51, 93);
            x1inp.Name = "x1inp";
            x1inp.Size = new Size(100, 23);
            x1inp.TabIndex = 1;
            x1inp.TextChanged += textBox1_TextChanged;
            // 
            // x1label
            // 
            x1label.AutoSize = true;
            x1label.Location = new Point(21, 96);
            x1label.Name = "x1label";
            x1label.Size = new Size(14, 15);
            x1label.TabIndex = 3;
            x1label.Text = "X";
            x1label.Click += Z1_Click;
            // 
            // y1inp
            // 
            y1inp.Location = new Point(51, 122);
            y1inp.Name = "y1inp";
            y1inp.Size = new Size(100, 23);
            y1inp.TabIndex = 4;
            // 
            // y1label
            // 
            y1label.AutoSize = true;
            y1label.Location = new Point(21, 125);
            y1label.Name = "y1label";
            y1label.Size = new Size(14, 15);
            y1label.TabIndex = 5;
            y1label.Text = "Y";
            // 
            // z1inp
            // 
            z1inp.Location = new Point(51, 151);
            z1inp.Name = "z1inp";
            z1inp.Size = new Size(100, 23);
            z1inp.TabIndex = 4;
            // 
            // z1label
            // 
            z1label.AutoSize = true;
            z1label.Location = new Point(21, 154);
            z1label.Name = "z1label";
            z1label.Size = new Size(14, 15);
            z1label.TabIndex = 5;
            z1label.Text = "Z";
            // 
            // btn2
            // 
            btn2.Location = new Point(208, 59);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 28);
            btn2.TabIndex = 7;
            btn2.Text = "Submit Vector 2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // y2label
            // 
            y2label.AutoSize = true;
            y2label.Location = new Point(178, 125);
            y2label.Name = "y2label";
            y2label.Size = new Size(14, 15);
            y2label.TabIndex = 12;
            y2label.Text = "Y";
            // 
            // z2label
            // 
            z2label.AutoSize = true;
            z2label.Location = new Point(178, 154);
            z2label.Name = "z2label";
            z2label.Size = new Size(14, 15);
            z2label.TabIndex = 13;
            z2label.Text = "Z";
            // 
            // y2inp
            // 
            y2inp.Location = new Point(208, 122);
            y2inp.Name = "y2inp";
            y2inp.Size = new Size(100, 23);
            y2inp.TabIndex = 10;
            // 
            // z2inp
            // 
            z2inp.Location = new Point(208, 151);
            z2inp.Name = "z2inp";
            z2inp.Size = new Size(100, 23);
            z2inp.TabIndex = 11;
            // 
            // x2label
            // 
            x2label.AutoSize = true;
            x2label.Location = new Point(178, 96);
            x2label.Name = "x2label";
            x2label.Size = new Size(14, 15);
            x2label.TabIndex = 9;
            x2label.Text = "X";
            // 
            // x2inp
            // 
            x2inp.Location = new Point(208, 93);
            x2inp.Name = "x2inp";
            x2inp.Size = new Size(100, 23);
            x2inp.TabIndex = 8;
            x2inp.TextChanged += textBox6_TextChanged;
            // 
            // outpt
            // 
            outpt.Location = new Point(51, 236);
            outpt.Multiline = true;
            outpt.Name = "outpt";
            outpt.Size = new Size(257, 176);
            outpt.TabIndex = 14;
            outpt.Text = "Output here";
            outpt.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(482, 66);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 15;
            label1.Text = "What would you like to do?";
            label1.Click += label1_Click;
            // 
            // vikAdd
            // 
            vikAdd.Location = new Point(482, 96);
            vikAdd.Name = "vikAdd";
            vikAdd.Size = new Size(151, 23);
            vikAdd.TabIndex = 16;
            vikAdd.Text = "Vectoraddition";
            vikAdd.UseVisualStyleBackColor = true;
            vikAdd.Click += vikAdd_Click;
            // 
            // vikSubtr
            // 
            vikSubtr.Location = new Point(482, 125);
            vikSubtr.Name = "vikSubtr";
            vikSubtr.Size = new Size(151, 23);
            vikSubtr.TabIndex = 17;
            vikSubtr.Text = "Vectorsubtraction";
            vikSubtr.UseVisualStyleBackColor = true;
            vikSubtr.Click += vikSubtr_Click;
            // 
            // vikCross
            // 
            vikCross.Location = new Point(482, 154);
            vikCross.Name = "vikCross";
            vikCross.Size = new Size(151, 23);
            vikCross.TabIndex = 18;
            vikCross.Text = "Cross-Product";
            vikCross.UseVisualStyleBackColor = true;
            vikCross.Click += vikCross_Click;
            // 
            // vikSkalar
            // 
            vikSkalar.Location = new Point(482, 183);
            vikSkalar.Name = "vikSkalar";
            vikSkalar.Size = new Size(151, 23);
            vikSkalar.TabIndex = 19;
            vikSkalar.Text = "Skalar-Product";
            vikSkalar.UseVisualStyleBackColor = true;
            vikSkalar.Click += vikSkalar_Click;
            // 
            // vikLeng
            // 
            vikLeng.Location = new Point(482, 212);
            vikLeng.Name = "vikLeng";
            vikLeng.Size = new Size(151, 23);
            vikLeng.TabIndex = 20;
            vikLeng.Text = "Length";
            vikLeng.UseVisualStyleBackColor = true;
            vikLeng.Click += vikLeng_Click;
            // 
            // vikAngel
            // 
            vikAngel.Location = new Point(482, 241);
            vikAngel.Name = "vikAngel";
            vikAngel.Size = new Size(151, 23);
            vikAngel.TabIndex = 21;
            vikAngel.Text = "Angel";
            vikAngel.UseVisualStyleBackColor = true;
            vikAngel.Click += vikAngel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vikAngel);
            Controls.Add(vikLeng);
            Controls.Add(vikSkalar);
            Controls.Add(vikCross);
            Controls.Add(vikSubtr);
            Controls.Add(vikAdd);
            Controls.Add(label1);
            Controls.Add(outpt);
            Controls.Add(y2label);
            Controls.Add(z2label);
            Controls.Add(y2inp);
            Controls.Add(z2inp);
            Controls.Add(x2label);
            Controls.Add(x2inp);
            Controls.Add(btn2);
            Controls.Add(y1label);
            Controls.Add(z1label);
            Controls.Add(y1inp);
            Controls.Add(z1inp);
            Controls.Add(x1label);
            Controls.Add(x1inp);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private TextBox x1inp;
        private Label x1label;
        private TextBox y1inp;
        private Label y1label;
        private TextBox z1inp;
        private Label z1label;
        private Button btn2;
        private Label y2label;
        private Label z2label;
        private TextBox y2inp;
        private TextBox z2inp;
        private Label x2label;
        private TextBox x2inp;
        private TextBox outpt;
        private Label label1;
        private Button vikSkalar;
        private Button vikCross;
        private Button vikSubtr;
        private Button vikAdd;
        private Button vikLeng;
        private Button vikAngel;
    }
}
