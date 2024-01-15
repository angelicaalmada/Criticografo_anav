using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Criticografo_anav
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string genero = Hombre.IsChecked ? "Hombre" : "Mujer";
            string opcion = "";
   
            if (Hombre.IsChecked)
            {
                if (alto.IsChecked)
                {
                    opcion += " ALTO,";
                }

                if (feo.IsChecked)
                {
                    opcion += " FEO,";
                }

                if (listo.IsChecked)
                {
                    opcion += " LISTO,";
                }

                if (raro.IsChecked)
                {
                    opcion += " RARO,";
                }

                if (extravagante.IsChecked)
                {
                    opcion += " EXTRAVAGANTE,";
                }

                if (grande.IsChecked)
                {
                    opcion += " GRANDE,";
                }
            }
           
            else
            {
                if (alto.IsChecked)
                {
                    opcion += " ALTA,";
                }

                if (feo.IsChecked)
                {
                    opcion += " FEA,";
                }

                if (listo.IsChecked)
                {
                    opcion += " LISTA,";
                }

                if (raro.IsChecked)
                {
                    opcion += " RARA,";
                }

                if (extravagante.IsChecked)
                {
                    opcion += " EXTRAVAGANTE,";
                }

                if (grande.IsChecked)
                {
                    opcion += " GRANDE,";
                }
            }
            string mensaje = $"{nombre} es {genero}";
            if (!string.IsNullOrWhiteSpace(opcion))
            {
                opcion = opcion.TrimEnd(',');
                int coma=opcion.LastIndexOf(",");
                if (coma>0)
                {
                    mensaje += $" y es {opcion.Substring(0, coma)} y {opcion.Substring(coma+1)}.";
                }
            }
             
            Criticar.Text = mensaje;
        }

       
    }
}
