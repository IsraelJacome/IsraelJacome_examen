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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string monto)
        {
            InitializeComponent();
            string usuari = lblUsuario.Text;
            lblUsuario.Text = usuari + usuario;
            txtNombre.Text = nombre;
            txtMonto.Text = monto;
        }
    }
}