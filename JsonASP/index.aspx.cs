using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace JsonASP
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona person = new Persona
            {
                nombre = txtNombre.Text,
                edad = Convert.ToInt32(txtEdad.Text),
                email = txtEmail.Text
            };
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtEmail.Text = "";
            if (Session["ARCHIVOJSON"].ToString() == string.Empty)
                Session["ARCHIVOJSON"] = JsonConvert.SerializeObject(person);
            else
                Session["ARCHIVOJSON"] = Session["ARCHIVOJSON"].ToString() + "," + JsonConvert.SerializeObject(person);
            ListBox1.Items.Add("Nombre: " + person.nombre + " Edad: "+ person.edad + " Email: " + person.email);
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\Jesus Ramirez Ayala\Desktop\aspnetJSON.json","["+Session["ARCHIVOJSON"].ToString()+"]");
            Response.Write("<script>alert('JSON listo !!');</script>");
        }
    }
}