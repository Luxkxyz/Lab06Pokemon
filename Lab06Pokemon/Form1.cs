using Lab06Pokemon.Resources;

namespace Lab06Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            label1.Text = pikachu.Name();
            pictureBox1.Image = Lab06Pokemon.Properties.Resources.pikachu;
            pictureBox2.Image = Lab06Pokemon.Properties.Resources.Arceus;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bulbasor Bulbasor = new Bulbasor();
            label1.Text = Bulbasor.Name();
            pictureBox1.Image = Lab06Pokemon.Properties.Resources.Bulbasor;
            pictureBox2.Image = Lab06Pokemon.Properties.Resources.Arceus;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Charmander Charmander = new Charmander();
            label1.Text = Charmander.Name();
            pictureBox1.Image = Lab06Pokemon.Properties.Resources.Charmander;
            pictureBox2.Image = Lab06Pokemon.Properties.Resources.Arceus;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Squirtle Squirtle = new Squirtle();
            label1.Text = Squirtle.Name();
            pictureBox1.Image = Lab06Pokemon.Properties.Resources.Squirtle;
            pictureBox2.Image = Lab06Pokemon.Properties.Resources.Arceus;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zubat Zubat = new Zubat();
            label1.Text = Zubat.Name();
            pictureBox1.Image = Lab06Pokemon.Properties.Resources.Zubat;
            pictureBox2.Image = Lab06Pokemon.Properties.Resources.Arceus;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bagon Bagon = new Bagon();
            label1.Text = Bagon.Name();
            pictureBox1.Image = Lab06Pokemon.Properties.Resources.Bagon;

            pictureBox2.Image = Lab06Pokemon.Properties.Resources.Arceus;
        }
    }
}
