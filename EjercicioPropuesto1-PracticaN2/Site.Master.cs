using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPropuesto1_PracticaN2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Productos.Items.Add(new ListItem("Cafetera", "1"));
                Productos.Items.Add(new ListItem("Freidora", "2"));
                Productos.Items.Add(new ListItem("Waflera", "3"));
                Productos.Items.Add(new ListItem("Aspiradora", "4"));
                Productos.Items.Add(new ListItem("Horno Electrico", "5"));
            }
            Grafico.Visible = false;
        }
        protected void Descripcion_ServerClick(Object sender, EventArgs e)
        {
            ListItem elemento = Productos.Items[Productos.SelectedIndex];
            if (elemento.Value == "1")
            {
                Codigex.InnerText = " Codigo : 15779594 ";
                Nombre.InnerText = "Nombre: Cafetera  Dedica Metal Rojo";
                Descripcion.InnerText = "Descripcion : Cafe de Molido"; 
                Marca.InnerText = "Marca: DELONGHI";
                Precio.InnerText = "Precio : 499";
            }
            if (elemento.Value == "2")
            {
                Codigex.InnerText = " Codigo : 881658646 ";
                Nombre.InnerText = "Nombre: Freidora Eléctrica";
                Descripcion.InnerText = "Descripcion : Freidora Eléctrica 1.5 L RFA-LEGGER";
                Marca.InnerText = "Marca: RECCO";
                Precio.InnerText = "Precio : 109";

            }
            if (elemento.Value == "3")
            {
                Codigex.InnerText = " Codigo : 881985227 ";
                Nombre.InnerText = "Nombre: Waflera";
                Descripcion.InnerText = "Descripcion : Waflera Redonda RCE-WAFFLE100R";
                Marca.InnerText = "Marca: RECCO";
                Precio.InnerText = "Precio : 60";

            }
            if (elemento.Value == "4")
            {
                Codigex.InnerText = " Codigo : 881971604 ";
                Nombre.InnerText = "Nombre: Aspiradora";
                Descripcion.InnerText = "Descripcion : Aspiradora Robot Wrb-Smartklean";
                Marca.InnerText = "Marca: WURDEN";
                Precio.InnerText = "Precio : 349.90";
            }
            if (elemento.Value == "5")
            {
                Codigex.InnerText = " Codigo : 16332461 ";
                Nombre.InnerText = "Nombre: Horno ";
                Descripcion.InnerText = "Descripcion : Horno Eléctrico French Door Silver 42 Lt";
                Marca.InnerText = "Marca: OSTER";
                Precio.InnerText = "Precio : 509.90";
            }
        }

            protected void MostrarGrafico_ServerClick(Object sender, EventArgs e)
        {
            Grafico.Src = "producto" + Productos.SelectedIndex.ToString() + ".jpg";
            Grafico.Alt = "Grafico producto";
            Grafico.Visible = true;
        }
    }
}