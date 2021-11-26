using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Clases;

namespace Web
{
    public partial class formulario2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mostrarPruebas();
            }

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {

            try
            {
                clsClientes objClientes = new clsClientes();
                lblMensaje.Text = objClientes.stInsertarPruebas(txtNombre.Text, Convert.ToInt32(txtAge.Text));
                mostrarPruebas();
                //cargarItemLista();

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }

        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {

            try
            {
                clsClientes objClientes = new clsClientes();
                DataSet dsConsulta = objClientes.stconsultarPruebas(txtID.Text);

                if (dsConsulta.Tables[0].Rows.Count == 0)
                {
                    datos.DataSource = null;
                }
                else
                {
                    datos.DataSource = dsConsulta;
                }
                datos.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }

        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {

            try
            {
                clsClientes objClientes = new clsClientes();
                lblMensaje.Text = objClientes.stModificarPruebas(txtID.Text, txtNombre.Text, Convert.ToInt32(txtAge.Text));
                mostrarPruebas();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clsClientes objClientes = new clsClientes();
                lblMensaje.Text = objClientes.stEliminarPruebas(txtID.Text);
                mostrarPruebas();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btn_global_Click(object sender, EventArgs e)
        {
            mostrarPruebas();
        }

        public void mostrarPruebas()
        {
            try
            {
                clsClientes objPruebas = new clsClientes();
                DataSet dsConsulta = objPruebas.mostrarPruebas();

                if (dsConsulta.Tables[0].Rows.Count == 0)
                {
                    datos.DataSource = null;
                }
                else
                {
                    datos.DataSource = dsConsulta;
                }
                datos.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void datos_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void datos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void datos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void datos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
    }
}