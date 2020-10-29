using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEMANAS3_SANTIAGOE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vista2 : ContentPage
    {
        public vista2(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;

        }

        private void btnNP1_Clicked(object sender, EventArgs e)
{

    try
    {
        //asignacion de valores desde xaml 
        double nota1 = Convert.ToDouble(txtNota1.Text);
        double nota2 = Convert.ToDouble(txtNota2.Text);
        double examen = Convert.ToDouble(txtExamen.Text);


        // accion 
        double promedio = (nota1 + nota2) / 2;
        double seguimiento = promedio * 0.3;
        double rExamen = examen * 0.2;
        double calcular = seguimiento + rExamen;
        txtRNP1.Text = calcular.ToString();

    }
    catch (Exception ex)
    {
        DisplayAlert("Mensaje de Alerta ", "Error" + ex.Message, "ok");

    }
}

private void btnNP2_Clicked(object sender, EventArgs e)
{
    try
    {
        //asignacion de valores desde xaml 
        double nota3 = Convert.ToDouble(txtNota3.Text);
        double nota4 = Convert.ToDouble(txtNota4.Text);
        double examen2 = Convert.ToDouble(txtExamen2.Text);


        // accion 
        double promedioSegundo = (nota3 + nota4) / 2;
        double seguimientoSegundo = promedioSegundo * 0.3;
        double rExamenSegundo = examen2 * 0.2;
        double calcular2 = seguimientoSegundo + rExamenSegundo;
        txtRNP2.Text = calcular2.ToString();

    }
    catch (Exception ex)
    {
        DisplayAlert("Mensaje de Alerta ", "Error" + ex.Message, "ok");

    }
}



private void btnFinal_Clicked(object sender, EventArgs e)
{
    try
    {
        double parcial1 = Convert.ToDouble(txtRNP1.Text);
        double parcial2 = Convert.ToDouble(txtRNP2.Text);


        double notaFinal = parcial1 + parcial2;
        txtNF.Text = notaFinal.ToString();
    }
    catch (Exception ex)
    {
        DisplayAlert("Mensaje de Alerta ", "Error" + ex.Message, "ok");

    }

}

private void btnResultado_Clicked(object sender, EventArgs e)
{
    /*
    double resultado = Convert.ToDouble(txtNF);

    if (resultado >= 7)
    {
        DisplayAlert("Mensaje", "APROBADO", "Cancelar");
    }
    else
    {
        DisplayAlert("Mensaje", "REPROBADO", "Cancelar");
    } */
}

private void btnAbrir_v2_Clicked(object sender, EventArgs e)
{

}

private void btn_Abrir_Vista2_Clicked(object sender, EventArgs e)
{

}
    }
}
