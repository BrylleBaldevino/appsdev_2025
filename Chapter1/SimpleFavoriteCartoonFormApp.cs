namespace picturepicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String[] characters = { "Spongebob", "Patrick", "Mr. Krabs", "Sandy", "Bugart" };
            comboBox1.Items.AddRange(characters);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            string selectedCharacter = comboBox1.SelectedItem.ToString();
            switch (selectedCharacter)
            {
                case "Spongebob":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\mm306\Downloads\spongbob.png");
                    break;
                case "Patrick":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\mm306\Downloads\patrick.png");
                    break;
                case "Mr. Krabs":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\mm306\Downloads\mrkrabs.png");
                    break;
                case "Sandy":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\mm306\Downloads\sandy.png");
                    break;
                case "Bugart":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\mm306\Downloads\fat-boy-cartoon-posing-vector-1804828.jpg");
                    break;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
