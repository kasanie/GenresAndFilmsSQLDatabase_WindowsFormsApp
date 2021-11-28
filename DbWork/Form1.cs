using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DbWork
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable dataTable1 = null;
        private DataTable dataTable2 = null;
        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\user\source\repos\DbWork\DbWork\Database.mdf; Integrated Security = True;");
            dataTable1 = new DataTable();
            dataTable2 = new DataTable();
        }
        private void InsertDB()
        {
            if (filmNameTextBox.Text != "" & genreNameComboBox.Text != "" & totalDiskUpDown.Value != 0)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"INSERT INTO [Film] (genreKey, genreName, filmName, totalDisk, takeDisk, leftDisk) VALUES ('{genreNumericUpDown.Text}', '{genreNameComboBox.Text}', '{filmNameTextBox.Text}', '{totalDiskUpDown.Text}', '{0}', '{totalDiskUpDown.Text}')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                RestartBox();
            }
        }
        private void addFilm_Click(object sender, EventArgs e)
        {
            InsertDB();
            LoadDB();
        }
        private void LoadDB()
        {
            dataTable1.Clear();
            dataTable2.Clear();
            sqlConnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Genre", sqlConnection);
            adapter.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
            dataGridView1.Columns["genreKey"].HeaderText = "Genre ID";
            dataGridView1.Columns["genreName"].HeaderText = "Genre";
            dataGridView1.Columns["popularity"].HeaderText = "Popularity";
            dataGridView1.Columns["averageRating"].HeaderText = "Average rating of films";
            adapter = new SqlDataAdapter("SELECT * FROM Film", sqlConnection);
            adapter.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["genreKey"].HeaderText = "Genre ID";
            dataGridView2.Columns["genreName"].HeaderText = "Genre";
            dataGridView2.Columns["filmName"].HeaderText = "Name";
            dataGridView2.Columns["totalDisk"].HeaderText = "Total disks";
            dataGridView2.Columns["takeDisk"].HeaderText = "Disks taken";
            dataGridView2.Columns["leftDisk"].HeaderText = "Disks left";
            genreNumericUpDown.Enabled = false;
            sqlConnection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDB();
        }
        private void RestartBox()
        {
            filmNameTextBox.Text = "";
            totalDiskUpDown.Value = 0;
            genreNameComboBox.Items.Clear();
            genreNumericUpDown.Value = 1;

            filmNameComboBox.Items.Clear();
            genreNameComboBox2.Items.Clear();
            genreNumericUpDown2.Value = 1;
            totalDiskUpDown2.Value = 0;
            takenDiskUpDown.Value = 0;
            leftDiskUpDown.Value = 0;
        }
        private void filmNameComboBox_DropDown(object sender, EventArgs e)
        {
            filmNameComboBox.Items.Clear();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT filmName FROM Film", sqlConnection);
            IDataReader reader = sqlCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string filmName = (string)reader["filmName"];
                    filmNameComboBox.Items.Add(filmName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }
            sqlConnection.Close();
        }
        private void filmNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Film WHERE filmName = N'{filmNameComboBox.Text}'", sqlConnection);
            IDataReader reader = sqlCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    genreNameComboBox2.Text = (string)reader["genreName"];
                    genreNumericUpDown2.Value = (int)reader["genreKey"];
                    totalDiskUpDown2.Value = (int)reader["totalDisk"];
                    takenDiskUpDown.Value = (int)reader["takeDisk"];
                    leftDiskUpDown.Value = (int)reader["leftDisk"];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при попытке прочитать базу данных!");
            }
            sqlConnection.Close();
        }
        private void genreNameComboBox_DropDown(object sender, EventArgs e)
        {
            genreNameComboBox.Items.Clear();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT genreName FROM Genre", sqlConnection);
            IDataReader reader = sqlCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string genreName = (string)reader["genreName"];
                    genreNameComboBox.Items.Add(genreName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }
            sqlConnection.Close();
        }
        private void genreNameComboBox2_DropDown(object sender, EventArgs e)
        {
            genreNameComboBox2.Items.Clear();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT genreName FROM Genre", sqlConnection);
            IDataReader reader = sqlCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string genreName = (string)reader["genreName"];
                    genreNameComboBox2.Items.Add(genreName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }
            sqlConnection.Close();
        }
        private void genreNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            genreNumericUpDown.Enabled = true;
            string genre = genreNameComboBox.Text;
            switch (genre)
            {
                case "Comedy":
                    genreNumericUpDown.Value = 1;
                    break;
                case "Cartoon":
                    genreNumericUpDown.Value = 2;
                    break;
                case "Horror":
                    genreNumericUpDown.Value = 3;
                    break;
                case "Fantasy":
                    genreNumericUpDown.Value = 4;
                    break;
                case "Thriller":
                    genreNumericUpDown.Value = 5;
                    break;
                case "Action":
                    genreNumericUpDown.Value = 6;
                    break;
                case "Detective":
                    genreNumericUpDown.Value = 7;
                    break;
                case "Melodrama":
                    genreNumericUpDown.Value = 8;
                    break;
                case "Documentary":
                    genreNumericUpDown.Value = 9;
                    break;
            }
        }
        private void genreNameComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genre = genreNameComboBox2.Text;
            switch (genre)
            {
                case "Comedy":
                    genreNumericUpDown2.Value = 1;
                    break;
                case "Cartoon":
                    genreNumericUpDown2.Value = 2;
                    break;
                case "Horror":
                    genreNumericUpDown2.Value = 3;
                    break;
                case "Fantasy":
                    genreNumericUpDown2.Value = 4;
                    break;
                case "Thriller":
                    genreNumericUpDown2.Value = 5;
                    break;
                case "Action":
                    genreNumericUpDown2.Value = 6;
                    break;
                case "Detective":
                    genreNumericUpDown2.Value = 7;
                    break;
                case "Melodrama":
                    genreNumericUpDown2.Value = 8;
                    break;
                case "Documentary":
                    genreNumericUpDown2.Value = 9;
                    break;
            }
        }
        private void genreNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int value = ((int)genreNumericUpDown.Value);
            switch (value)
            {
                case 1:
                    genreNameComboBox.SelectedIndex = 0;
                    break;
                case 2:
                    genreNameComboBox.SelectedIndex = 1;
                    break;
                case 3:
                    genreNameComboBox.SelectedIndex = 2;
                    break;
                case 4:
                    genreNameComboBox.SelectedIndex = 3;
                    break;
                case 5:
                    genreNameComboBox.SelectedIndex = 4;
                    break;
                case 6:
                    genreNameComboBox.SelectedIndex = 5;
                    break;
                case 7:
                    genreNameComboBox.SelectedIndex = 6;
                    break;
                case 8:
                    genreNameComboBox.SelectedIndex = 7;
                    break;
                case 9:
                    genreNameComboBox.SelectedIndex = 8;
                    break;
            }
        }
        private void genreNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int value = ((int)genreNumericUpDown2.Value);
            switch (value)
            {
                case 1:
                    genreNameComboBox2.Text = "Comedy";
                    break;
                case 2:
                    genreNameComboBox2.Text = "Cartoon";
                    break;
                case 3:
                    genreNameComboBox2.Text = "Horror";
                    break;
                case 4:
                    genreNameComboBox2.Text = "Fantasy";
                    break;
                case 5:
                    genreNameComboBox2.Text = "Thriller";
                    break;
                case 6:
                    genreNameComboBox2.Text = "Action";
                    break;
                case 7:
                    genreNameComboBox2.Text = "Detective";
                    break;
                case 8:
                    genreNameComboBox2.Text = "Melodrama";
                    break;
                case 9:
                    genreNameComboBox2.Text = "Documentary";
                    break;
            }
        }
        private void deleteFilm_Click(object sender, EventArgs e)
        {
            if (filmNameComboBox.Text != "")
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand($"DELETE FROM Film WHERE filmName = N'{filmNameComboBox.Text}'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    RestartBox();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в удалении из БД");
                }
            }
            LoadDB();
        }
        private void editFilm_Click(object sender, EventArgs e)
        {
            if (filmNameComboBox.Text != "")
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand($"UPDATE Film SET genreKey = '{genreNumericUpDown2.Value}', genreName = '{genreNameComboBox2.Text}', totalDisk = '{totalDiskUpDown2.Text}', takeDisk = '{takenDiskUpDown.Text}', leftDisk = '{leftDiskUpDown.Text}' WHERE filmName = '{filmNameComboBox.Text}'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    RestartBox();
                    MessageBox.Show("Данные изменены.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в изменении данных!");
                }
            }
            LoadDB();
        }
        private void searchFilmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchFilmComboBox.Text == "Название фильма")
            {
                textBox1.Visible = true;
                comboBox1.Visible = false;
                numericUpDown1.Visible = false;
            }
            if (searchFilmComboBox.Text == "Жанр")
            {
                comboBox1.Visible = true;
                comboBox1.Text = "Comedy";
                textBox1.Visible = false;
                numericUpDown1.Visible = false;
            }
            if (searchFilmComboBox.Text == "Ключ жанра")
            {
                numericUpDown1.Visible = true;
                textBox1.Visible = false;
                comboBox1.Visible = false;
            }
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT genreName FROM Genre", sqlConnection);
            IDataReader reader = sqlCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string genreName = (string)reader["genreName"];
                    comboBox1.Items.Add(genreName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }
            sqlConnection.Close();
        }
        private void searchFilm_Click(object sender, EventArgs e)
        {
            dataTable2.Clear();
            try
            {
                sqlConnection.Open();
                if (searchFilmComboBox.Text == "Название фильма")
                {
                    adapter = new SqlDataAdapter($"SELECT * FROM Film where filmName =N'{textBox1.Text}'", sqlConnection);
                    adapter.Fill(dataTable2);
                    dataGridView2.DataSource = dataTable2;
                    dataGridView2.Columns["Id"].Visible = false;
                    tabControl1.SelectedTab = tabPage2;
                }
                else
                    if (searchFilmComboBox.Text == "Жанр")
                {
                    adapter = new SqlDataAdapter($"SELECT * FROM Film where genreName =N'{comboBox1.Text}'", sqlConnection);
                    adapter.Fill(dataTable2);
                    dataGridView2.DataSource = dataTable2;
                    dataGridView2.Columns["Id"].Visible = false;
                    tabControl1.SelectedTab = tabPage2;
                }
                else
                    if (searchFilmComboBox.Text == "Ключ жанра")
                {
                    adapter = new SqlDataAdapter($"SELECT * FROM Film where genreKey =N'{numericUpDown1.Value}'", sqlConnection);
                    adapter.Fill(dataTable2);
                    dataGridView2.DataSource = dataTable2;
                    dataGridView2.Columns["Id"].Visible = false;
                    tabControl1.SelectedTab = tabPage2;
                }
                sqlConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в поиске!");
            }
        }
        private void diskLeftRB_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns["leftDisk"], ListSortDirection.Descending);
            tabControl1.SelectedTab = tabPage2;
        }
        private void diskTakenRB_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns["takeDisk"], ListSortDirection.Descending);
            tabControl1.SelectedTab = tabPage2;
        }
        private void diskTotal_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns["totalDisk"], ListSortDirection.Descending);
            tabControl1.SelectedTab = tabPage2;
        }
        private void genreKeyRB_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["genreKey"], ListSortDirection.Ascending);
            tabControl1.SelectedTab = tabPage1;
        }
        private void genreRB_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["genreName"], ListSortDirection.Ascending);
            tabControl1.SelectedTab = tabPage1;
        }
        private void popularityRB_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["popularity"], ListSortDirection.Ascending);
            tabControl1.SelectedTab = tabPage1;
        }
        private void ratingRB_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["averageRating"], ListSortDirection.Descending);
            tabControl1.SelectedTab = tabPage1;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            diskTotal.Checked = false;
            diskTakenRB.Checked = false;
            diskLeftRB.Checked = false;
            genreKeyRB.Checked = false;
            genreRB.Checked = false;
            popularityRB.Checked = false;
            ratingRB.Checked = false;
            searchFilmComboBox.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
            numericUpDown1.Value = 1;
            LoadDB();
        }
        private void totalDiskUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (totalDiskUpDown2.Value >= takenDiskUpDown.Value) leftDiskUpDown.Value = totalDiskUpDown2.Value - takenDiskUpDown.Value;
        }
        private void takenDiskUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (takenDiskUpDown.Value <= totalDiskUpDown2.Value) leftDiskUpDown.Value = totalDiskUpDown2.Value - takenDiskUpDown.Value;
        }
        private void leftDiskUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (leftDiskUpDown.Value <= totalDiskUpDown2.Value) takenDiskUpDown.Value = totalDiskUpDown2.Value - leftDiskUpDown.Value;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                    string search = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString();
                    string columnName = dataGridView1.Columns[columnIndex].Name;
                    dataTable2.Clear();
                    sqlConnection.Open();
                    adapter = new SqlDataAdapter($"SELECT Genre.genreKey, Genre.genreName, Film.filmName, Film.totalDisk, Film.takeDisk, Film.leftDisk FROM Genre, Film WHERE Genre.genreKey = Film.genreKey AND Genre.{columnName} = '{search}'", sqlConnection);
                    adapter.Fill(dataTable2);
                    dataGridView2.DataSource = dataTable2;
                    sqlConnection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Нельзя выбрать!");
                }
                sqlConnection.Close();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadDB();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
