namespace habibi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "The Simpsons", "Rick and Morty", "Squid Game", "Venom", "Iron Man", "Guardians of the Galaxy\r\n" };
            checkedListBoxMovies.Items.AddRange(movies);

            checkedListBoxMovies.CheckOnClick = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movie in checkedListBoxMovies.CheckedItems)
            {
                if (!listBoxMovies.Items.Contains(movie))
                {
                    listBoxMovies.Items.Add(movie);
                }
            }
        }

        private void deleteBtm_Click(object sender, EventArgs e)
        {
            if (listBoxMovies.SelectedItem != null)
            {
                listBoxMovies.Items.Remove(listBoxMovies.SelectedItem);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBoxMovies.Items.Clear();
        }
    }
}
