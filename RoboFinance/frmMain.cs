using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Data.SqlClient;

namespace RoboFinance
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Banco
        public class Meta
        {
            public string symbol { get; set; }
            public double regularMarketPrice { get; set; }
            public DateTime dateTime { get; set; }
        }
        #endregion region

        #region Json Api Response
        public class YahooFinanceResponse
        {
            public Chart chart { get; set; }
        }

        public class Chart
        {
            public List<Result> result { get; set; }
        }

        public class Result
        {
            public Meta meta { get; set; }
        }
        #endregion 

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "START")
            {
                button1.Text = "STOP";
                timer1.Enabled = true;
            }
            else
            {
                button1.Text = "START";
                timer1.Enabled = false;
            }
        }

        private async void ConsultaApiFinace()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetFromJsonAsync<YahooFinanceResponse>("https://query2.finance.yahoo.com/v8/finance/chart/PETR4.SA");

                    if (response != null && response.chart != null && response.chart.result != null && response.chart.result.Count > 0)
                    {
                        var metadados = new Meta
                        {
                            symbol = response.chart.result[0].meta.symbol,
                            regularMarketPrice = response.chart.result[0].meta.regularMarketPrice,
                            dateTime = DateTime.Now
                        };
                        txtResponse.Text = "symbol = " + metadados.symbol + Environment.NewLine + "regularMarketPrice = " + metadados.regularMarketPrice + Environment.NewLine + "dateTime = " + metadados.dateTime;

                        var connectionString = "workstation id=the-specialist;packet size=4096;user id=sa;data source=1.1.1.1;persist security info=True;initial catalog=Finance;password=*sql*123_";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string sql = "INSERT INTO Meta (Symbol, RegularMarketPrice, DateTime) VALUES (@Symbol, @RegularMarketPrice, @DateTime)";

                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@Symbol", metadados.symbol);
                                command.Parameters.AddWithValue("@RegularMarketPrice", metadados.regularMarketPrice);
                                command.Parameters.AddWithValue("@DateTime", metadados.dateTime);

                                int rowsAffected = command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Text == "STOP")
            {
                timer1.Enabled = false;
                ConsultaApiFinace();
                lbCount.Text = Convert.ToString(Convert.ToInt32(lbCount.Text) + 1);
                timer1.Enabled = true;
            }
        }

        private void cboTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(cboTimer.SelectedItem);            
        }
    }
}