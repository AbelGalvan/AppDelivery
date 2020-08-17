using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace AppSDelivery
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutUser : ContentPage
    {
        public AboutUser()
        {
            InitializeComponent();

            btnIngresar.Clicked += (sender, e) =>
            {
                String error;
                MySQLConn conexion = new MySQLConn(EtyUser.Text, EtyPass.Text);
                if (conexion.TryConnection(out error))
                {
                    lblResult.Text = "Conexion exitosa!";
                }
                else
                {
                    lblResult.Text = "Error!" + error;
                }
            };
        }
    }
}