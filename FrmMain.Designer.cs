namespace GUI26101402
{
    partial class FrmMain
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
            txt1stOp = new TextBox();
            txt2ndOp = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            txtResult = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt1stOp
            // 
            txt1stOp.Location = new Point(14, 88);
            txt1stOp.Margin = new Padding(5, 6, 5, 6);
            txt1stOp.Name = "txt1stOp";
            txt1stOp.Size = new Size(112, 36);
            txt1stOp.TabIndex = 0;
            // 
            // txt2ndOp
            // 
            txt2ndOp.Location = new Point(171, 88);
            txt2ndOp.Margin = new Padding(5, 6, 5, 6);
            txt2ndOp.Name = "txt2ndOp";
            txt2ndOp.Size = new Size(112, 36);
            txt2ndOp.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(171, 53);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 29);
            label2.TabIndex = 1;
            label2.Text = "2nd op:";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(14, 53);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 29);
            label3.TabIndex = 1;
            label3.Text = "1st op:";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 50);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(160, 168);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(125, 50);
            btnSub.TabIndex = 2;
            btnSub.Text = "sub";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(14, 238);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(125, 50);
            btnMult.TabIndex = 2;
            btnMult.Text = "mult";
            btnMult.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(162, 238);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(125, 50);
            btnDiv.TabIndex = 2;
            btnDiv.Text = "div";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(92, 358);
            txtResult.Margin = new Padding(5, 6, 5, 6);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(112, 36);
            txtResult.TabIndex = 0;
            txtResult.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(92, 323);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 29);
            label1.TabIndex = 1;
            label1.Text = "result:";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 427);
            Controls.Add(btnDiv);
            Controls.Add(btnSub);
            Controls.Add(btnMult);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtResult);
            Controls.Add(txt2ndOp);
            Controls.Add(txt1stOp);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmMain";
            Text = "basic operations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1stOp;
        private TextBox txt2ndOp;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private TextBox txtResult;
        private Label label1;
    }
}
