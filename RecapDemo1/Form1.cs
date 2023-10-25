namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                int left = 0;
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Brown;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    left += 50;
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
            }
        }
    }
}