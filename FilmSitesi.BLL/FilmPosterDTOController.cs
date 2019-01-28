using FilmSitesi.DAL.Repositories;
using FilmSitesi.DTO;
using FilmSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.BLL
{
    public class FilmPosterDTOController
    {
        FilmManagement fm = new FilmManagement();
        PosterManagement pm = new PosterManagement();

        public List<AnasayfaFilmPosterDTO> FilmListele()
        {
            List<Film> filmListesi = fm.GetAll();
            List<AnasayfaFilmPosterDTO> dtoAnasayfaFilm = new List<AnasayfaFilmPosterDTO>();

            foreach (Film item in filmListesi)
            {
                AnasayfaFilmPosterDTO dtoFilmPoster = new AnasayfaFilmPosterDTO();
                dtoFilmPoster.FilmID = item.FilmID;
                dtoFilmPoster.FilmAdi = item.FilmAdi;
                dtoFilmPoster.FilmPosterURL = pm.Get(item.FilmID).PosterURL;
                dtoAnasayfaFilm.Add(dtoFilmPoster);
            }

            return dtoAnasayfaFilm;
        }
    }
}
