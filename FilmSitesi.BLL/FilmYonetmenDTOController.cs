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
    public class FilmYonetmenDTOController
    {
        FilmManagement fm = new FilmManagement();
        List<FilmYonetmenDTO> yonetmenListesi = new List<FilmYonetmenDTO>();
        public List<FilmYonetmenDTO> FilmYonetmenBilgisi(int FilmID)
        {
            Film film = fm.Get(FilmID);

            foreach (var item in film.Yonetmenler)
            {
                FilmYonetmenDTO fyDTO = new FilmYonetmenDTO();
                fyDTO.YonetmenAdSoyad = item.YonetmenAd + " " + item.YonetmenSoyad;
                yonetmenListesi.Add(fyDTO);
            }
            return yonetmenListesi;
        }
    }
}
