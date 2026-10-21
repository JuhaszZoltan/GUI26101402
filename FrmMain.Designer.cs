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
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            label1 = new Label();
            nudOp1 = new NumericUpDown();
            nudOp2 = new NumericUpDown();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)nudOp1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOp2).BeginInit();
            SuspendLayout();
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
            btnSub.TabStop = false;
            btnSub.Text = "sub";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(14, 238);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(125, 50);
            btnMult.TabIndex = 2;
            btnMult.TabStop = false;
            btnMult.Text = "mult";
            btnMult.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(162, 238);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(125, 50);
            btnDiv.TabIndex = 2;
            btnDiv.TabStop = false;
            btnDiv.Text = "div";
            btnDiv.UseVisualStyleBackColor = true;
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
            // nudOp1
            // 
            nudOp1.DecimalPlaces = 2;
            nudOp1.Location = new Point(14, 102);
            nudOp1.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudOp1.Minimum = new decimal(new int[] { 10000000, 0, 0, int.MinValue });
            nudOp1.Name = "nudOp1";
            nudOp1.Size = new Size(123, 36);
            nudOp1.TabIndex = 0;
            nudOp1.TextAlign = HorizontalAlignment.Right;
            nudOp1.ThousandsSeparator = true;
            // 
            // nudOp2
            // 
            nudOp2.DecimalPlaces = 2;
            nudOp2.Location = new Point(160, 102);
            nudOp2.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudOp2.Minimum = new decimal(new int[] { 10000000, 0, 0, int.MinValue });
            nudOp2.Name = "nudOp2";
            nudOp2.Size = new Size(123, 36);
            nudOp2.TabIndex = 1;
            nudOp2.TextAlign = HorizontalAlignment.Right;
            nudOp2.ThousandsSeparator = true;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.White;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(86, 352);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(125, 44);
            lblResult.TabIndex = 4;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 427);
            Controls.Add(lblResult);
            Controls.Add(nudOp2);
            Controls.Add(nudOp1);
            Controls.Add(btnDiv);
            Controls.Add(btnSub);
            Controls.Add(btnMult);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmMain";
            Text = "basic operations";
            ((System.ComponentModel.ISupportInitialize)nudOp1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOp2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private Label label1;
        private NumericUpDown nudOp1;
        private NumericUpDown nudOp2;
        private Label lblResult;
    }
}
