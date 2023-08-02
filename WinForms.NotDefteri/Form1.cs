namespace WinForms.NotDefteri
{
    public partial class Form1 : Form
    {
        private Note selectedNote = null;
        public Form1()
        {
            InitializeComponent();
            List();

        }
        public void List()
        {

            listBox1.DataSource = null;
            listBox1.DataSource = DataStore.Notes;
            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNote.Text))
            {
                var addedNotes = new Note();
                addedNotes.Description = txtNote.Text;
                var lastNote = DataStore.Notes[DataStore.Notes.Count - 1];
                addedNotes.Id = lastNote.Id + 1;

                DataStore.Notes.Add(addedNotes);
                List();
                txtNote.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Lütfen not kýsmýný boþ býrakmayýnýz.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedNote = (Note)listBox1.SelectedItem;
                txtNote.Text = selectedNote.Description;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataStore.Notes.Remove(selectedNote);
            selectedNote = null;
            txtNote.Text = string.Empty;
            List();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNote.Text))
            {
                selectedNote.Description = txtNote.Text;
                List();
            }
        }
    }
}