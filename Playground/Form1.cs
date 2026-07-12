namespace Playground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
            if(BackColor != Color.Red)
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = Color.Blue;
            }
            string temperatura = textBox1.Text;
            
            switch(temperatura)
            {
                case "cald":
                    {
                        textBox1.BackColor = Color.Orange;
                        break;
                    }
                case "rece":
                    {
                        textBox1.BackColor = Color.DarkBlue;
                        break;
                    }
                default:
                    {
                        textBox1.BackColor = Color.Green;
                        break;
                    }
            }

            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }
    }
}
