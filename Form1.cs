using MySql.Data.MySqlClient;
namespace sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string mysqlCon = "server=127.0.0.1;user=root; database=sampleconnecrtion; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection Success");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                mySqlConnection.Close();

            }

            private void Form1(object sender, EventArgs e)
            {

            }

        }
    }
}
