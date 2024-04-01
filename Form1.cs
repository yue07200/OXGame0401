using System.Windows.Forms;

namespace OXGame
{
    public partial class Form1 : Form
    {
        //
        String playerMarker = "X";

        //
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Casting sender to be a Button
            Button button = (Button)sender;
            // 避免下第二次!
            if (button.Text != "")
                return;
            //
            button.Text = playerMarker;
            
            playerMarker = playerMarker == "X" ? "O" : "X";
            label2.Text = playerMarker;
            //
            checkWinner();
        }

        private void checkWinner()
        {
            // 
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text !=" " )
            {
                MessageBox.Show(button1.Text, "Winner is...");
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != " ")
            {
                MessageBox.Show(button4.Text, "Winner is...");
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != " ")
            {
                MessageBox.Show(button7.Text, "Winner is...");
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != " ")
            {
                MessageBox.Show(button1.Text, "Winner is...");
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != " ")
            {
                MessageBox.Show(button2.Text, "Winner is...");
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != " ")
            {
                MessageBox.Show(button3.Text, "Winner is...");
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != " ")
            {
                MessageBox.Show(button1.Text, "Winner is...");
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != " ")
            {
                MessageBox.Show(button3.Text, "Winner is...");
            }
            else
            {
                // check if TIE ?
            }
        }
    }
}