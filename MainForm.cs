// this specifies the logic that comes from the engine class
using SMEngine;
// this is the namespace of the UI form
namespace SlotMachineMaddness2026
{ // this starts the class of the UI form
    public partial class MainForm : Form
    {

        private ClassSMEngine machine = new ClassSMEngine();

        public MainForm()
        {
            InitializeComponent();
        }



        // this is the starting point for the slots
        private void MainForm_Load(object sender, EventArgs e)
        {


            lblCurrent.Text = machine.currentBet.ToString();
            lblMoney.Text = machine.money.ToString();
            



        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
             lblResult.Text = "Good Luck!";

            // this is where we accept the bet placed
            machine.money -= machine.currentBet;

            //this is where the spin happens
            int[] result = machine.SpinSlots();

            lblSlot1.Text = result[0].ToString();
            lblSlot2.Text = result[1].ToString();
            lblSlot3.Text = result[2].ToString();
            //this is where you get your results win or lose or JACKPOT!
            string outcome = machine.EvaluateSpin(result);

            

            // machine.EvaluateSpin(result);
            lblMoney.Text = machine.money.ToString();

            if (outcome == "JACKPOT")
            {
                lblResult.Text = "JACKPOT! YOU WIN!";
            }
            else if (outcome == "WIN")
            {
                lblResult.Text = "YOU WIN!";
            }
            else
            {
                lblResult.Text = "YOU LOSE! TRY AGAIN?";
            }


        }

        private void lblSlot1_Click(object sender, EventArgs e)

        {

        }

        private void lblSlot2_Click(object sender, EventArgs e)
        {

        }

        private void lblSlot3_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrent_Click(object sender, EventArgs e)
        {
            
        }

        private void lblMoney_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            machine.currentBet += machine.minBet;

            lblCurrent.Text = machine.currentBet.ToString();

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            machine.currentBet += machine.maxBet;

            lblCurrent.Text = machine.currentBet.ToString();

            if (machine.currentBet > machine.money)
            {
                machine.currentBet = machine.money;
            }

            lblCurrent.Text = machine.currentBet.ToString();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        
    }
}
