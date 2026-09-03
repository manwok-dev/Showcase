namespace GUIbruch
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
            textBruch1 = new TextBox();
            textBruch2 = new TextBox();
            btnAdd = new Button();
            btnSubtr = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            textAusgabe = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBruch1
            // 
            textBruch1.Location = new Point(68, 69);
            textBruch1.Name = "textBruch1";
            textBruch1.Size = new Size(100, 23);
            textBruch1.TabIndex = 0;
            textBruch1.TextChanged += textBruch1_TextChanged;
            // 
            // textBruch2
            // 
            textBruch2.Location = new Point(371, 69);
            textBruch2.Name = "textBruch2";
            textBruch2.Size = new Size(100, 23);
            textBruch2.TabIndex = 1;
            textBruch2.TextChanged += textBruch2_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(251, 70);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(35, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtr
            // 
            btnSubtr.Location = new Point(251, 99);
            btnSubtr.Name = "btnSubtr";
            btnSubtr.Size = new Size(35, 23);
            btnSubtr.TabIndex = 3;
            btnSubtr.Text = "-";
            btnSubtr.UseVisualStyleBackColor = true;
            btnSubtr.Click += btnSubtr_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(251, 128);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(35, 23);
            btnMult.TabIndex = 4;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(251, 157);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(35, 23);
            btnDiv.TabIndex = 5;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // textAusgabe
            // 
            textAusgabe.Location = new Point(71, 247);
            textAusgabe.Multiline = true;
            textAusgabe.Name = "textAusgabe";
            textAusgabe.Size = new Size(406, 173);
            textAusgabe.TabIndex = 6;
            textAusgabe.TextChanged += textAusgabe_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 51);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "Bruch 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 51);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 8;
            label2.Text = "Bruch 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 446);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textAusgabe);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSubtr);
            Controls.Add(btnAdd);
            Controls.Add(textBruch2);
            Controls.Add(textBruch1);
            Name = "Form1";
            Text = "Mega super toller eins a Bruchrechner";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBruch1;
        private TextBox textBruch2;
        private Button btnAdd;
        private Button btnSubtr;
        private Button btnMult;
        private Button btnDiv;
        private TextBox textAusgabe;
        private Label label1;
        private Label label2;
    }
}
