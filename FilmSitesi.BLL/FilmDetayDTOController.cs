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
    public class FilmDetayDTOController
    {
        FilmManagement fm = new FilmManagement();
        List<FilmDetayDTO> filmDetayListesi = new List<FilmDetayDTO>();
        List<Film> filmListesi = new List<Film>();
        public List<FilmDetayDTO> FilmBilgileriGetir(int FilmID)
        {
            Film film = fm.Get(FilmID);
            filmListesi.Add(film);

            foreach (var item in filmListesi)
            {
                FilmDetayDTO fdDTO = new FilmDetayDTO();
                fdDTO.FilmAdi = item.FilmAdi;
                fdDTO.Aciklama = item.Aciklama;
                fdDTO.Dil = item.Dil.DilAdi;
                fdDTO.Sure = item.FilmSure;
                fdDTO.Yil = item.YapimYili.Year.ToString();
                fdDTO.PosterURL = item.Posterler.FirstOrDefault().PosterURL;
                filmDetayListesi.Add(fdDTO);
            }

            return filmDetayListesi;
        }
    }
}
