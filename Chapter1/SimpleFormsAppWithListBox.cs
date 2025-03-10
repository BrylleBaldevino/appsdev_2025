namespace dingal
{
    public partial class Form1 : Form
    {
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

        private void button_Click(object sender, EventArgs e)
        {
            {
                // Check if the TextBox is not empty and the item is not already in the ListBox
                if (!string.IsNullOrWhiteSpace(txtBox.Text) && !lstBox.Items.Contains(txtBox.Text))
                {
                    lstBox.Items.Add(txtBox.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (lstBox.SelectedItem != null)
                {
                    lstBox.Items.Remove(lstBox.SelectedItem);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {               
                lstBox.Items.Clear();
            }
        }
    }
}
