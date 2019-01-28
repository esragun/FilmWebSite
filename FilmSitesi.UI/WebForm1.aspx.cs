using FilmSitesi.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmSitesi.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fragmanLink;
            FilmController fc = new FilmController();
            fragmanLink = fc.FilmAnaFragmanGetir(1);
            ifVideo.Attributes.Add("src", fragmanLink);
        }
    }
}