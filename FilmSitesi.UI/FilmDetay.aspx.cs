using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FilmSitesi.BLL;
using System.Web.UI.HtmlControls;

namespace FilmSitesi.UI
{
    public partial class FilmDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int filmID = Convert.ToInt32(Request.QueryString["fid"]);
            string fragmanLink;

            FilmDetayDTOController fdDTO = new FilmDetayDTOController();
            FilmOyuncuDTOController foDTO = new FilmOyuncuDTOController();
            FilmTurDTOController ftDTO = new FilmTurDTOController();
            FilmUlkeDTOController fuDTO = new FilmUlkeDTOController();
            FilmYonetmenDTOController fyDTO = new FilmYonetmenDTOController();
            FilmController fc = new FilmController();

            fragmanLink = fc.FilmAnaFragmanGetir(filmID);
            rptFilmBilgi.DataSource = fdDTO.FilmBilgileriGetir(filmID);
            rptOyuncular.DataSource = foDTO.FilmOyuncuBilgisi(filmID);
            rptTur.DataSource = ftDTO.FilmTurBilgisi(filmID);
            rptUlke.DataSource = fuDTO.FilmUlkeBilgisi(filmID);
            rptYonetmen.DataSource = fyDTO.FilmYonetmenBilgisi(filmID);
            ifVideo.Attributes.Add("src", fragmanLink);


            rptFilmBilgi.DataBind();
            rptOyuncular.DataBind();
            rptTur.DataBind();
            rptUlke.DataBind();
            rptYonetmen.DataBind();



        }
    }
}