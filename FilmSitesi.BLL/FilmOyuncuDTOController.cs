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
    public class FilmOyuncuDTOController
    {
        FilmManagement fm = new FilmManagement();
        List<FilmOyuncuDTO> oyuncuListesi = new List<FilmOyuncuDTO>();
        public List<FilmOyuncuDTO> FilmOyuncuBilgisi(int FilmID)
        {
            Film film = fm.Get(FilmID);

            foreach (var item in film.Oyuncular)
            {
                FilmOyuncuDTO foDTO = new FilmOyuncuDTO();
                foDTO.OyuncuAdSoyad = item.OyuncuAd + " " + item.OyuncuSoyad;
                oyuncuListesi.Add(foDTO);
            }
            return oyuncuListesi;
        }
    }
}
