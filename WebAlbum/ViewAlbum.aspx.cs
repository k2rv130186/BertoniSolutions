using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAlbum
{
    public partial class ViewAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Entidades.Album> lstAlbunes = new List<Entidades.Album>();
                Datos.DatosAlbum dalbum = new Datos.DatosAlbum();
                lstAlbunes = dalbum.GetAlbunes();
                ddlstAlbun.DataValueField = "Id";
                ddlstAlbun.DataTextField = "Title";
                ddlstAlbun.DataSource = lstAlbunes;
                ddlstAlbun.DataBind();
                //this.Repeater1.DataSource = lstAlbunes;
                //this.Repeater1.DataBind();
            }
        }

        protected void btnVerAlbum_Click(object sender, EventArgs e)
        {
            if (ddlstAlbun.SelectedValue != null)
            {
                List<Entidades.Fotos> lstFotos = new List<Entidades.Fotos>();
                Datos.DatosFoto dFotos = new Datos.DatosFoto();
                lstFotos = dFotos.GetFotos(Convert.ToInt32(ddlstAlbun.SelectedValue));
                gvFotos.DataSource = lstFotos;
                gvFotos.DataBind();
            }
        }

        protected void gvFotos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvFotos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            List<Entidades.Comentario> lstComents = new List<Entidades.Comentario>();
            Datos.DatosComentario dComentarios = new Datos.DatosComentario();
            //Aqui no supe como relacionar el id de las fotos con algun Id de los comentarios ya que solo existen 2 id uno llamado postId y otro ID
            //por esa razón muestro todos los mensajes
            lstComents = dComentarios.GetComentarios();
            gvComentarios.DataSource = lstComents;
            gvComentarios.DataBind();

            //if (e.CommandName=="verComentario")
            //{
            //    lstComents = dComentarios.GetComentarios(Convert.ToInt32(gvFotos.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text));
            //    gvComentarios.DataSource = lstComents;
            //    gvComentarios.DataBind();

            //}
        }
    }
}