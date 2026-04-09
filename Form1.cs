namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnlnit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false; 
            rdoBulgogiBurger.Checked = false; 
            rdoChickenBurger.Checked = false; 
            chkPotato.Checked = false; 
            chkCola.Checked = false; 
            chkCheese.Checked = false; 
            chkSauce.Checked = false; 
            lstOrder.Items.Clear(); 
            lblTotalCost.Text = "총 금액: 0원";
        }
    }
}
