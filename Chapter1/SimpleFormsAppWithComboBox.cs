namespace sudan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cuisineTypes = { "Filipino", "Japanese", "Chinese", "Korean" };
            comboBox1.Items.AddRange(cuisineTypes);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string[] filipinoFoodList = { "Bulalo", "Kare-Kare", "Bicol Express", "Pinakbet" };
            string[] japaneseFoodList = { "Sushi", "Ramen", "Tempura", "Takoyaki" };
            string[] chineseFoodList = { "Dim Sum", "Peking Duck", "Sweet and Sour Pork", "Chow Mein" };
            string[] koreanFoodList = { "Kimchi", "Bibimbap", "Tteokbokki", "Samgyeopsal" };

            checkedListBox1.Items.Clear();

            string selectedCuisine = comboBox1.SelectedItem.ToString();

            if (selectedCuisine == "Filipino")
            {
                checkedListBox1.Items.AddRange(filipinoFoodList);
            }
            else if (selectedCuisine == "Japanese")
            {
                checkedListBox1.Items.AddRange(japaneseFoodList);
            }
            else if (selectedCuisine == "Chinese")
            {
                checkedListBox1.Items.AddRange(chineseFoodList);
            }
            else if (selectedCuisine == "Korean")
            {
                checkedListBox1.Items.AddRange(koreanFoodList);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (!listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
