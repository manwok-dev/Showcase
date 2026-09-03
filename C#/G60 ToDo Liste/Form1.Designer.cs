namespace G60_ToDo_Liste
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
            txtBxInput = new TextBox();
            btnAdd = new Button();
            checkedLBToDos = new CheckedListBox();
            btnRmv = new Button();
            SuspendLayout();
            // 
            // txtBxInput
            // 
            txtBxInput.Location = new Point(208, 39);
            txtBxInput.Name = "txtBxInput";
            txtBxInput.Size = new Size(227, 23);
            txtBxInput.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(89, 36);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 26);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // checkedLBToDos
            // 
            checkedLBToDos.FormattingEnabled = true;
            checkedLBToDos.Location = new Point(89, 87);
            checkedLBToDos.Name = "checkedLBToDos";
            checkedLBToDos.Size = new Size(346, 328);
            checkedLBToDos.TabIndex = 2;
            checkedLBToDos.SelectedIndexChanged += checkedLBToDos_SelectedIndexChanged;
            // 
            // btnRmv
            // 
            btnRmv.Location = new Point(470, 36);
            btnRmv.Name = "btnRmv";
            btnRmv.Size = new Size(132, 27);
            btnRmv.TabIndex = 3;
            btnRmv.Text = "Remove";
            btnRmv.UseVisualStyleBackColor = true;
            btnRmv.Click += btnRmv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 427);
            Controls.Add(btnRmv);
            Controls.Add(checkedLBToDos);
            Controls.Add(btnAdd);
            Controls.Add(txtBxInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBxInput;
        private Button btnAdd;
        private CheckedListBox checkedLBToDos;
        private Button btnRmv;
    }
}
