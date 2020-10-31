using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IsraelJacome_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string user)
        {
            InitializeComponent();
            string usuar = lbluser.Text;
            lbluser.Text = usuar + user;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            int montos = int.Parse(txtMontoInicial.Text);

            if (montos != 1800)
            {
                var pagomensual = 1800 - montos;
                var restocu = pagomensual / 3;
                var porcentaje = restocu * 0.05;
                var total = restocu + porcentaje;
                txtMensual.Text = (total).ToString();
                txtPagoR.Text = (total * 3).ToString();

            }
            else
                txtPagoR.Text = "0";
        }


        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {

                await DisplayAlert("Ingreso", "Ingreso Iconrrecto", "ok");
            }

            else
            {
                await DisplayAlert("Guardar", "Elemento Guardado con exito", "ok");
                string usuario = lbluser.Text;
                string nombre = txtNombre.Text;
                string monto = txtPagoR.Text;
                await Navigation.PushAsync(new Resumen(usuario, nombre, monto));

            }

        }

    }

       
}