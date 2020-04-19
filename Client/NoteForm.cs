using System;
using System.Data;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace Client
{
    public partial class NoteForm : MaterialForm
    {
        DataTable table;
        SqlCommand command;
        SqlConnection conn;
        SqlDataAdapter adap;
        string username;
        public NoteForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            deleteNote.Enabled = true; // shouldn't be here
            readNote.Enabled = true; // shouldn't be here 
            this.Text = "Welcome, " + username;

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["NotesDb"].ConnectionString;
            conn = new SqlConnection(connectionString);
            table = new DataTable("Notes");
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Body", typeof(string));
            storedNotes.DataSource = table;

            string selectqry = "select * from Notes where Username = '" + this.username + "'";
            command = new SqlCommand(selectqry, conn);
            adap = new SqlDataAdapter(command);
            adap.Fill(table);
        }

        private void newNote_Click(object sender, EventArgs e)
        {
            noteTitle.Clear();
            noteBody.Clear();
            noteTitle.Enabled = true;
            noteBody.Enabled = true;
        }

        private void saveNote_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["NotesDb"].ConnectionString;
            table.Rows.Add(username, noteTitle.Text, noteBody.Text);
            Console.WriteLine("outside the loop");
            conn = new SqlConnection(connectionString);
            conn.Open();
            int i = storedNotes.Rows.Count - 1;
            Console.WriteLine("1");
            command = new SqlCommand("insert into Notes(Username, Title, Body) values ('" + storedNotes.Rows[i].Cells[0].Value + "','" + storedNotes.Rows[i].Cells[1].Value + "','" + storedNotes.Rows[i].Cells[2].Value + "')", conn);
            command.ExecuteNonQuery();
            Console.WriteLine("inserted successfully");
            conn.Close();
            noteTitle.Clear();
            noteBody.Clear();
            noteTitle.Enabled = false;
            noteBody.Enabled = false;
        }

        private void readNote_Click(object sender, EventArgs e)
        {
            int index = storedNotes.CurrentCell.RowIndex;
            if (index > -1)
            {
                noteTitle.Text = table.Rows[index].ItemArray[1].ToString();
                noteBody.Text = table.Rows[index].ItemArray[2].ToString();
                noteTitle.Enabled = true;
                noteBody.Enabled = true;
            }
        }

        private void deleteNote_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["NotesDb"].ConnectionString;

            int index = storedNotes.CurrentCell.RowIndex;
            conn = new SqlConnection(connectionString);
            conn.Open();
            while (storedNotes.CurrentCell.Selected == true)
            {
                deleteNote.Enabled = true;
                table.Rows[index].Delete(); // deletes from the table in the DB
                string delquery = "delete from Notes where Id = '" + index + "'";
                command = new SqlCommand(delquery, conn);
                Console.WriteLine("index " + index);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}
