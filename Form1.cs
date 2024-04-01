using OXGameV1;
using System.Numerics;
using System.Windows.Forms;

namespace OXGame
{
    public partial class Form1 : Form
    {
        //
        OXGameEngine engine = new OXGameEngine();
        private Button[,] buttons;
        private char playerMarker = 'X';

        //
        public Form1()
        {
            InitializeComponent();
            //
            InitializeGame();
            //
            engine.ResetGame();
        }

        private void InitializeGame()
        {
            buttons = new Button[3, 3];
            // construct 3*3 Button with for loop
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Create Button object and initialize the attributes
                    Button button = new Button();
                    button.Font = new Font("Arial", 32F);
                    button.Size = new Size(90, 90);
                    button.Tag = String.Format("{0},{1}", i, j);
                    button.Location = new Point(10 + j * 100, 10 + i * 100);
                    // += : bind the event-handler to button¡¦s Click-event
                    button.Click += new EventHandler(Button_Click);
                    // ¬Ù²¤ new EventHandler(¡K) ¤]OK „» += Button_Click;
                    // Record the button with 2-D Array
                    buttons[i, j] = button;
                    // Add button object to the internal area of Form
                    Controls.Add(button);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Cast the sender to be Button object !
            Button button = (Button)sender;
            //
            String posTag = (String)button.Tag;
            String[] xy = posTag.Split(',');
            int x = int.Parse(xy[0]);
            int y = int.Parse(xy[1]);
            //
            if (engine.GetMarker(x, y) != ' ')
                return;
            //
            engine.SetMarker(x, y, playerMarker);
            button.Text = "" + playerMarker;
            //
            playerMarker = (playerMarker == 'X') ? 'O' : 'X';
            label2.Text = "" + playerMarker;
            //
            checkWinner();

        }


        private void checkWinner()
        {
            char winner = engine.IsWinner();
            if (engine.IsWinner() != ' ')
            {
                MessageBox.Show("Winner is: " + winner);
            }
        }
    }
}