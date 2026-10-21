namespace GUI26101402
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnAdd.Click += BtnAddClick;

            nudOp1.ValueChanged += NudValueChanged;
            nudOp2.ValueChanged += NudValueChanged;

            //btnSub.Click += BtnSubClick;
            //btnMult.Click += BtnMultClick;
            //btnDiv.Click += BtnDivClick;
        }

        private void NudValueChanged(object? sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }
        #region szemét
        //private void BtnDivClick(object? sender, EventArgs e)
        //{
        //    int op1 = int.Parse(txt1stOp.Text);
        //    int op2 = int.Parse(txt2ndOp.Text);

        //    if (op2 == 0) txtResult.Text = "NaN";
        //    else txtResult.Text = $"{op1 / (double)op2:0.00}";
        //}

        //private void BtnMultClick(object? sender, EventArgs e)
        //{
        //    int op1 = int.Parse(txt1stOp.Text);
        //    int op2 = int.Parse(txt2ndOp.Text);

        //    txtResult.Text = $"{op1 * op2}";
        //}

        //private void BtnSubClick(object? sender, EventArgs e)
        //{
        //    int op1 = int.Parse(txt1stOp.Text);
        //    int op2 = int.Parse(txt2ndOp.Text);

        //    txtResult.Text = $"{op1 - op2}";
        //}
        #endregion

        private void BtnAddClick(object? sender, EventArgs e)
        {
            decimal op1 = nudOp1.Value;
            decimal op2 = nudOp2.Value;

            lblResult.Text = $"{op1 + op2}";
        }
    }
}
