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
    public class FilmUlkeDTOController
    {
        FilmManagement fm = new FilmManagement();
        List<FilmUlkeDTO> ulkeListesi = new List<FilmUlkeDTO>();
        public List<FilmUlkeDTO> FilmUlkeBilgisi(int FilmID)
        {
            Film film = fm.Get(FilmID);

            foreach (var item in film.Ulkeler)
            {
                FilmUlkeDTO fuDTO = new FilmUlkeDTO();
                fuDTO.UlkeAdi = item.UlkeAdi;
                ulkeListesi.Add(fuDTO);
            }
            return ulkeListesi;
        }
    }
}
