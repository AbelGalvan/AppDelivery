using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MySql.Data.MySqlClient;

namespace AppSDelivery
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Consultar();
        }

        private void Consultar()
        {
            BtnConsulta.Clicked += BtnConsulta_Clicked;
        }

        private void BtnConsulta_Clicked(object sender, EventArgs e)
        {
            string connectionString = "datasource=sql3.freemysqlhosting.net;port=3306;username=sql3360291;password=991004ajgep;database=sql3360291";
            string query = "SELECT * FROM Registros";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            if (databaseConnection != null){
                LblText.Text = "Conexion Exitosa!";
            }
            else
            {
                LblText.Text = "Conexion Fallida!";
            }
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
        }
    }
}
