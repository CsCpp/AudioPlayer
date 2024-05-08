using System.Media;
namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        SoundPlayer player = null;
        string fileName=string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                player.SoundLocation = fileName;
                player.Play();
            }
            catch (Exception ex)
            {

              var knOkError=MessageBox.Show($"{ex.Message}", "Œ¯Ë·Í‡!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (knOkError == DialogResult.OK) { OpenMedia(); }
                if (knOkError == DialogResult.Cancel) { OpenMedia(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void ÓÚÍ˚Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         OpenMedia();
        }

        private void OpenMedia()
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "WAV|*.wav",
                Multiselect = false,
                ValidateNames = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                textBox1.Text = fileName;
            }
        }
    }
}
