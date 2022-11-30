namespace MathematicTests
{
    public partial class frmChallenge : Form
    {
        Random random = new Random();
        int numberOne, numberTwo;
        int timeLeft, response;
        int point;
        
        public frmChallenge()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnEndQuiz.Visible = true;
            button1.Enabled = false;

            numberOne = random.Next(100);
            numberTwo = random.Next(100);

            lblFirstNbrAddition.Text = numberOne.ToString();
            lblSecondNbrAdition.Text = numberTwo.ToString();

            numberOne = random.Next(100);
            numberTwo = random.Next(100);

            lblFirstNbrSub.Text = numberOne.ToString();
            lblSecondNbrSub.Text = numberTwo.ToString();

            numberOne = random.Next(100);
            numberTwo = random.Next(100);

            lblFirstNbrDiv.Text = numberOne.ToString();
            lblSecondNbrDiv.Text = numberTwo.ToString();

            numberOne = random.Next(100);
            numberTwo = random.Next(1, 100);

            lblFirstNbrMult.Text = numberOne.ToString();
            lblSecondNbrMult.Text = numberTwo.ToString();

            timeLeft = 60;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            txtTimeLeft.Text = timeLeft + " segundos";

            int pointAnswers = CheckTheAnswer();
        }

        public int CheckTheAnswer()
        {
            numberOne = Convert.ToInt32(lblFirstNbrAddition.Text);
            numberTwo = Convert.ToInt32(lblSecondNbrAdition.Text);
            response = Convert.ToInt32(numericUpDownAdd);

            if ((numberOne + numberTwo) == response)
            {
                point++;
            }
            numberOne = Convert.ToInt32(lblFirstNbrSub.Text);
            numberTwo = Convert.ToInt32(lblSecondNbrSub.Text);
            response = Convert.ToInt32(numericUpDownSub);

            if ((numberOne - numberTwo) == response)
            {
                point++;
            }
            numberOne = Convert.ToInt32(lblFirstNbrDiv.Text);
            numberTwo = Convert.ToInt32(lblSecondNbrDiv.Text);
            response = Convert.ToInt32(numericUpDownDiv);

            if ((numberOne / numberTwo) == response)
            {
                point++;
            }
            numberOne = Convert.ToInt32(lblFirstNbrMult.Text);
            numberTwo = Convert.ToInt32(lblSecondNbrMult.Text);
            response = Convert.ToInt32(numericUpDownMult);

            if ((numberOne * numberTwo) == response)
            {
                point++;
            }
            return point;


        }
    }
}