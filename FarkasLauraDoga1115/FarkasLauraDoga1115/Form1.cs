using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FarkasLauraDoga1115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Click += Hatterszin;
            label3.Click += Hatterszin;
            label4.Click += Hatterszin;
            button7.Click += Alaphelyzet;
            button8.Click += Kilepes;
        }
        private void Hatterszin(object sender, EventArgs e)
        {
            if(sender is Label clickedLabel) 
            {
                this.BackColor =clickedLabel.BackColor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string koszones = $"Szia!, {textBox1.Text}";
                label5.Text = koszones;
            }
            else
            {
                MessageBox.Show("Kérlek, add meg a nevedet!");
            }
        }

        private void Alaphelyzet(object sender, EventArgs e) 
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void Kilepes(object sender, EventArgs e) 
        {
            Application.Exit();
        }
    }
}