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

            // this is to show money and current bet before playing
            lblCurrent.Text = machine.currentBet.ToString();
            lblMoney.Text = machine.money.ToString();
            



        }
        // this is your spin button action
        private void btnSpin_Click(object sender, EventArgs e)
        {
             lblResult.Text = "Good Luck!";

            // this is where we accept the bet placed
            machine.money -= machine.currentBet;

            //this is where the spin happens
            // your slots show 3 different reults
            int[] result = machine.SpinSlots();

            lblSlot1.Text = result[0].ToString();
            lblSlot2.Text = result[1].ToString();
            lblSlot3.Text = result[2].ToString();
            //this is where you get your results win or lose or JACKPOT!
            string outcome = machine.EvaluateSpin(result);

            

            // your money will update based on the reults shown
            // you have mul
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
        // these PVs are not needed per say - but app will crash without them
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
        // these methods are the only ones being used - your bet buttons and spin button
        // minBet button
        private void btnMin_Click(object sender, EventArgs e)
        {
            machine.currentBet += machine.minBet;

            lblCurrent.Text = machine.currentBet.ToString();

        }

        //maxBet button
        // each button either increases bet by 5 or 15
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

        // another method not used - more so for a label
        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        
    } // this is the end of the form
} // this is the end of the name space
