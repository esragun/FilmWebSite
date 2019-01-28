using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSitesi.DAL.Repositories;
using FilmSitesi.DTO;
using FilmSitesi.Entity;

namespace FilmSitesi.BLL
{
    public class FilmTurDTOController
    {
        FilmManagement fm = new FilmManagement();
        List<FilmTurDTO> turListesi = new List<FilmTurDTO>();
        public List<FilmTurDTO> FilmTurBilgisi(int FilmID)
        {
            Film film = fm.Get(FilmID);

            foreach (var item in film.Turler)
            {
                FilmTurDTO ftDTO = new FilmTurDTO();
                ftDTO.FilmTurAdi = item.TurAdi;
                turListesi.Add(ftDTO);
            }
            return turListesi;
        }
    }
}
