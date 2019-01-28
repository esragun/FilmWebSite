using FilmSitesi.BLL;
using FilmSitesi.DTO;
using FilmSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmSitesi.UI
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FilmPosterDTOController fpDTO = new FilmPosterDTOController();   
            List<AnasayfaFilmPosterDTO> filmListesi = fpDTO.FilmListele();
            rptFilmler.DataSource = filmListesi;
            rptFilmler.DataBind();
        }
    }
}