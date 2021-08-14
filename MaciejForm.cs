using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trening
{
    public partial class MaciejForm : Form
    {
        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlConnection conn;

        string connString = @"Data Source=MACIEJ-KOMPUTER\SQLSERVER2017;Initial Catalog=trening;Integrated Security=True";

        string wyswietl = "Select * from Maciej";

        public MaciejForm()
        {
            InitializeComponent();
        }

        private void MaciejForm_Load(object sender, EventArgs e)
        {
            dataGridViewMaciej.DataSource = bindingSourceMaciej;
            GetData(wyswietl);
            dateTimePickerData.Text = DateTime.Now.ToString();
            zmianaStatystyki("Całość");
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString); //pass in the select command and the connection string
                table = new System.Data.DataTable(); //make a new data table objectr
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table); //fill the data table
                bindingSourceMaciej.DataSource = table; // set the data source on the binding source to the table
                dataGridViewMaciej.Columns[0].ReadOnly = true; //this helps prevent the id field from being changed
                // testest
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            btnPrzelicz_Click(sender, e);

            SqlCommand command;

            string insert = @"insert into Maciej(Data, Okrążenia, Czas, Dystans, Srednie_Tempo, Srednia_Predkosc, Sredni_Czas_Okrazenia) values(@Data, @okrazenia, @Czas, @Dystans, @Srednie_Tempo, @Srednia_Predkosc, @Sredni_Czas_Okrazenia)";

            using (conn = new SqlConnection(connString)) //using allows disposing of low level resources
                if (float.Parse(txtSrednieTempo.Text) > 0 && float.Parse(txtSredniaPredkosc.Text) > 0){
                    {
                        try
                        {
                            conn.Open(); // open the connection
                            command = new SqlCommand(insert, conn); //create the new sql commant objact
                            command.Parameters.AddWithValue(@"Data", dateTimePickerData.Value.ToString()); //read value from form and save to table
                            command.Parameters.AddWithValue(@"okrazenia", int.Parse(txtIloscOkrazen.Text));
                            command.Parameters.AddWithValue(@"Czas", txtCzas.Text);
                            command.Parameters.AddWithValue(@"Dystans", Math.Round(float.Parse(txtDystans.Text), 2));
                            command.Parameters.AddWithValue(@"Srednie_Tempo", Math.Round(float.Parse(txtSrednieTempo.Text), 2));
                            command.Parameters.AddWithValue(@"Srednia_Predkosc", Math.Round(float.Parse(txtSredniaPredkosc.Text), 2));
                            command.Parameters.AddWithValue(@"Sredni_Czas_Okrazenia", txtSredniCzasOkrazenia.Text);

                            command.ExecuteNonQuery(); //push stuff into the table
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    GetData(wyswietl);
                    btnSzukaj_Click(sender, e);
                    dataGridViewMaciej.Update();
                }
                else
                {
                    MessageBox.Show("Wpisz poprawne wartości", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btnPrzelicz_Click(object sender, EventArgs e)
        {
            if (txtDystans.Text != "" && txtIloscOkrazen.Text != "" && txtGodzina.Text != "" && txtMinuta.Text != "" && txtSekunda.Text != "")
            {
                try
                {
                    float czas = int.Parse(txtGodzina.Text) * 3600 + int.Parse(txtMinuta.Text) * 60 + int.Parse(txtSekunda.Text);
                    float sredniaPredkosc = (float.Parse(txtDystans.Text) / czas) * 3600f;
                    int srednieTempoMin = (int)Math.Floor(czas / 60 / float.Parse(txtDystans.Text));
                    float srednieTempoSek = (((czas / 60) % float.Parse(txtDystans.Text)) / float.Parse(txtDystans.Text) / 100) * 60;
                    int sredniCzasOkrazeniaMin = (int)Math.Floor(czas / 60 / float.Parse(txtIloscOkrazen.Text));
                    float sredniCzasOkrazeniaSek = ((czas / 60 % float.Parse(txtIloscOkrazen.Text)) / float.Parse(txtIloscOkrazen.Text)) * 60;

                    txtCzas.Text = txtGodzina.Text + ":" + txtMinuta.Text + ":" + txtSekunda.Text;
                    txtSrednieTempo.Text = Math.Round((srednieTempoMin + srednieTempoSek), 2).ToString();
                    txtSredniaPredkosc.Text = Math.Round(sredniaPredkosc, 2).ToString();

                    txtSredniCzasOkrazenia.Text = sredniCzasOkrazeniaMin.ToString() + ":" + Math.Round(sredniCzasOkrazeniaSek).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Brakuje danych", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtGodzina_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtGodzina.Text == "")
                {
                    txtGodzina.Text = "00";
                }

                if (int.TryParse(txtGodzina.Text, out int num))
                {

                    if (num > 24 || num < 0)
                    {
                        MessageBox.Show("Wpisz liczbę między 0 - 24", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGodzina.Text = "00";
                    }
                    if (txtGodzina.Text.Length < 2)
                    {
                        txtGodzina.Text = "0" + txtGodzina.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Wpisz liczbę", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGodzina.Text = "00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMinuta_Leave(object sender, EventArgs e)
        {

            try
            {
                if (txtMinuta.Text == "")
                {
                    txtMinuta.Text = "00";
                }
                if (int.TryParse(txtMinuta.Text, out int num))
                {
                    if (num > 60 || num < 0)
                    {
                        MessageBox.Show("Wpisz liczbę między 0 - 60", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMinuta.Text = "00";
                    }
                    if (txtMinuta.Text.Length < 2)
                    {
                        txtMinuta.Text = "0" + txtMinuta.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Wpisz liczbę", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMinuta.Text = "00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSekunda_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSekunda.Text == "")
                {
                    txtSekunda.Text = "00";
                }
                if (int.TryParse(txtSekunda.Text, out int num))
                {
                    if (num > 60 || num < 0)
                    {
                        MessageBox.Show("Wpisz licznę między 0 - 60", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSekunda.Text = "00";
                    }
                    if (txtSekunda.Text.Length < 2)
                    {
                        txtSekunda.Text = "0" + txtSekunda.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Wpisz liczbę", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSekunda.Text = "00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewMaciej.CurrentCell.OwningRow; //grab a refrence to the current row
            string value = row.Cells["ID"].Value.ToString(); //grab the value from the id field of the selected record
            string data = row.Cells["Data"].Value.ToString(); //grab the value from the first name field of the selected record
            DialogResult result = MessageBox.Show("Czy chcesz usunąć trening z dnia " + data + " rekord " + value, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string deleteStatement = @"Delete from Maciej where id = '" + value + "'"; //this is the sql delete the records from the sql table

            if (result == DialogResult.Yes) //check whether user really wants to delete records
            {
                using (conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open(); //try open connection
                        SqlCommand comm = new SqlCommand(deleteStatement, conn);
                        comm.ExecuteNonQuery(); //this line actually causes the deletion to run
                        btnSzukaj_Click(sender, e);
                        dataGridViewMaciej.Update(); // redraw the data grid view with updated information
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridViewMaciej_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand(); //get the update command
            try
            {
                DataGridViewRow row = dataGridViewMaciej.CurrentCell.OwningRow; //grab a refrence to the current row
                string rekord = row.Cells["ID"].Value.ToString(); //grab the value from the id field of the selected record
                DialogResult result = MessageBox.Show("Czy chcesz zmienić wartość w rekordzie: " + rekord, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bindingSourceMaciej.EndEdit(); // updates the table that is in memory in our program
                    MessageBox.Show("Zmiana udana");
                }
                else
                {
                    bindingSourceMaciej.CancelEdit();
                    MessageBox.Show("Zmiana wycofana");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {

            DataGridViewRow dgvRow = dataGridViewMaciej.Rows[dataGridViewMaciej.CurrentCell.RowIndex];

            SqlCommand command;

            float sr_temp = Convert.ToSingle(txtSrednieTempo.Text);

            string update = @"UPDATE Maciej SET Data = '" + dateTimePickerData.Value.ToString() + "', Okrążenia = @okrazenia, Czas = @Czas, Dystans = @Dystans, Srednie_Tempo = @Srednie_Tempo, Srednia_Predkosc = @Srednia_Predkosc, Sredni_Czas_Okrazenia = @Sredni_Czas_Okrazenia where ID = '" + dgvRow.Cells[0].Value.ToString() + "'";

            using (conn = new SqlConnection(connString)) //using allows disposing of low level resources
            {
                try
                {
                    DataGridViewRow row = dataGridViewMaciej.CurrentCell.OwningRow;
                    string value = row.Cells["ID"].Value.ToString();
                    string data = row.Cells["Data"].Value.ToString();
                    DialogResult result = MessageBox.Show("Czy chcesz edytować trening z dnia " + data + " rekord " + value, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        conn.Open(); // open the connection
                        command = new SqlCommand(update, conn); //create the new sql commant objact

                        command.Parameters.AddWithValue(@"okrazenia", int.Parse(txtIloscOkrazen.Text));
                        command.Parameters.AddWithValue(@"Czas", txtCzas.Text);
                        command.Parameters.AddWithValue(@"Dystans", Math.Round(float.Parse(txtDystans.Text), 2));
                        command.Parameters.AddWithValue(@"Srednie_Tempo", Math.Round(float.Parse(txtSrednieTempo.Text), 2));
                        command.Parameters.AddWithValue(@"Srednia_Predkosc", Math.Round(float.Parse(txtSredniaPredkosc.Text), 2));
                        command.Parameters.AddWithValue(@"Sredni_Czas_Okrazenia", txtSredniCzasOkrazenia.Text);

                        command.ExecuteNonQuery(); //push stuff into the table
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            GetData(wyswietl);
            dataGridViewMaciej.Update();
        }

        private void dataGridViewMaciej_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < dataGridViewMaciej.RowCount)
            {
                DataGridViewRow dgvRow = dataGridViewMaciej.Rows[e.RowIndex];
                dateTimePickerData.Text = dgvRow.Cells[1].Value.ToString();
                txtIloscOkrazen.Text = dgvRow.Cells[2].Value.ToString();
                txtGodzina.Text = dgvRow.Cells[3].Value.ToString().Substring(0, 2);
                txtMinuta.Text = dgvRow.Cells[3].Value.ToString().Substring(3, 2);
                txtSekunda.Text = dgvRow.Cells[3].Value.ToString().Substring(6, 2);
                txtCzas.Text = dgvRow.Cells[3].Value.ToString();
                txtDystans.Text = dgvRow.Cells[4].Value.ToString();
                txtSrednieTempo.Text = dgvRow.Cells[5].Value.ToString();
                txtSredniaPredkosc.Text = dgvRow.Cells[6].Value.ToString();
                txtSredniCzasOkrazenia.Text = dgvRow.Cells[7].Value.ToString();
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            if (cboRok.Text.ToString() != "" && cboMiesiac.Text.ToString() == "")
            {
                switch (cboRok.Text.ToString())
                {
                    case "2019":
                        GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + cboRok.Text.ToString() + ")");
                        zmianaStatystyki(cboRok.Text.ToString());
                        break;
                    case "2020":
                        GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + cboRok.Text.ToString() + ")");
                        zmianaStatystyki(cboRok.Text.ToString());
                        break;
                    case "2021":
                        GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + cboRok.Text.ToString() + ")");
                        zmianaStatystyki(cboRok.Text.ToString());
                        break;
                }
            }
            if (cboRok.Text.ToString() != "" && cboMiesiac.Text.ToString() != "")
            {
                switch (cboRok.Text.ToString())
                {
                    case "2019":
                        szukajMiesiac("2019");
                        zmianaStatystyki(cboMiesiac.Text.ToString() + " " + cboRok.Text.ToString());
                        break;
                    case "2020":
                        szukajMiesiac("2020");
                        zmianaStatystyki(cboMiesiac.Text.ToString() + " " + cboRok.Text.ToString());
                        break;
                    case "2021":
                        szukajMiesiac("2021");
                        zmianaStatystyki(cboMiesiac.Text.ToString() + " " + cboRok.Text.ToString());
                        break;
                }
            }
            if(cboRok.Text.ToString() == "" && cboMiesiac.Text.ToString() != "")
            {
                MessageBox.Show("Podaj rok", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if( cboRok.Text.ToString() == "" && cboMiesiac.Text.ToString() == "") {
                GetData(wyswietl);
                zmianaStatystyki("Całość");
            }
        }

        private void szukajMiesiac(string rok)
        {
            switch (cboMiesiac.Text.ToString())
            {
                case "Styczeń":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 01)");
                    break;
                case "Luty":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 02)");
                    break;
                case "Marzec":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 03)");
                    break;
                case "Kwiecień":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 04)");
                    break;
                case "Maj":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 05)");
                    break;
                case "Czerwiec":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 06)");
                    break;
                case "Lipiec":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 07)");
                    break;
                case "Sierpień":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 08)");
                    break;
                case "Wrzesień":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 09)");
                    break;
                case "Październik":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 10)");
                    break;
                case "Listopad":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 11)");
                    break;
                case "Grudzień":
                    GetData("select * from Maciej where (DATEPART(yyyy, Data) = " + rok + " AND DATEPART(MM, Data) = 12)");
                    break;
            }
        }

        private void txtDystans_Leave(object sender, EventArgs e)
        {
            try
            {
                if (float.TryParse(txtDystans.Text, out float num))
                {
                    if (num > 0)
                    {
                        txtDystans.Text = num.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Wpisz nie mniej niż 1", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDystans.Text = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy format", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDystans.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIloscOkrazen_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtIloscOkrazen.Text, out int num))
                {
                    if (num < 1)
                    {
                        MessageBox.Show("Wpisz nie mniej niż 1", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIloscOkrazen.Text = "1";
                    }
                    else
                    {
                        txtIloscOkrazen.Text = num.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy format", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIloscOkrazen.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboRok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cboMiesiac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void zmianaStatystyki(string okres)
        {
            txtOkres.Text = okres.ToString();
            txtSumaIloscOkrazen.Text = sumowanieKolumn(2);
            txtSumaCzas.Text = "TO DO";
            txtSumaDystans.Text = sumowanieKolumn(4);
            txtSumaSrednieTempo.Text = srednieKolumn(5);
            txtSumaSredniaPredkosc.Text = srednieKolumn(6);
            txtSumaSredniCzasOkrazen.Text = "TO DO";
        }

        private string sumowanieKolumn(int kolumna)
        {
            float[] columnData = new float[dataGridViewMaciej.Rows.Count];
            columnData = (from DataGridViewRow row in dataGridViewMaciej.Rows where row.Cells[kolumna].FormattedValue.ToString() != string.Empty select Convert.ToSingle(row.Cells[kolumna].FormattedValue)).ToArray();
            if (columnData.Length == 0)
            {
                return "Brak danych";
            }
            else
            {
                return columnData.Sum().ToString();
            }
        }

        private string srednieKolumn(int kolumna)
        {
            float[] columnData = new float[dataGridViewMaciej.Rows.Count];
            columnData = (from DataGridViewRow row in dataGridViewMaciej.Rows where row.Cells[kolumna].FormattedValue.ToString() != string.Empty select Convert.ToSingle(row.Cells[kolumna].FormattedValue)).ToArray();
            if (columnData.Length == 0)
            {
                return "Brak danych";
            }
            else
            {
                return Math.Round(columnData.Average(), 2).ToString();
            }
        }
    }
}