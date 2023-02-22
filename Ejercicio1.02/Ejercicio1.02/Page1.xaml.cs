using Ejercicio1._02.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Ejercicio1._02
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnenviar_Clicked(object sender, EventArgs e)
        {
            var emple = new empleado
            {
                nombre = txtnombre.Text,
                apellidos = txtapellidos.Text,
                edad=txtedad.Text,
                correo=txtcorreo.Text,

            };

            var secondpage = new Pageresultado();
            secondpage.BindingContext = emple;
            Navigation.PushAsync(secondpage);
        }
    }
}
