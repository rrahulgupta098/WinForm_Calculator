namespace WinForm
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
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textnum1 = new TextBox();
            textnum2 = new TextBox();
            textresult = new TextBox();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(185, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 68);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "First number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 115);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 2;
            label2.Text = "Second number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 173);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 3;
            label3.Text = "Third number";
            // 
            // textnum1
            // 
            textnum1.Location = new Point(334, 68);
            textnum1.Name = "textnum1";
            textnum1.Size = new Size(125, 27);
            textnum1.TabIndex = 4;
            // 
            // textnum2
            // 
            textnum2.Location = new Point(334, 119);
            textnum2.Name = "textnum2";
            textnum2.Size = new Size(125, 27);
            textnum2.TabIndex = 5;
            // 
            // textresult
            // 
            textresult.Location = new Point(334, 173);
            textresult.Name = "textresult";
            textresult.Size = new Size(125, 27);
            textresult.TabIndex = 6;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(365, 247);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(94, 29);
            btnSub.TabIndex = 7;
            btnSub.Text = "Sub";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(185, 324);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(94, 29);
            btnMul.TabIndex = 8;
            btnMul.Text = "Mul";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(365, 336);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(94, 29);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "Div";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(textresult);
            Controls.Add(textnum2);
            Controls.Add(textnum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textnum1;
        private TextBox textnum2;
        private TextBox textresult;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
    }
}