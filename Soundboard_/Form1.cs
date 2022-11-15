using System.Media;

namespace Soundboard_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            new Touch(flowLayoutPanel1);
            

     
        }

        private void button1_Click(object sender, EventArgs e)

        {
            Button BTN = new Button();
            BTN.Height= 90;
            BTN.Width = 188;
            BTN.Text = "Test";
            BTN.BackColor = Color.LightGray;
            flowLayoutPanel1.Controls.Add(BTN);
        }
        private void playSimpleSound(string path)
        {

            SoundPlayer simpleSound = new SoundPlayer(path);
            simpleSound.Play();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}