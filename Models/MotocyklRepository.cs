using System.Collections.Generic;
using System.Linq;

namespace TheShop.Models
{
    public class MotocyklRepository : IMotocyklRepository
    {
        public readonly AppDbContext _appDbContext;

        public MotocyklRepository(AppDbContext appDbConext)
        {
            _appDbContext = appDbConext;
        }

        public IEnumerable<Motocykl> GetModels(int mId)
        {
            return _appDbContext.Motocykle;
        }

        public IEnumerable<Motocykl> GetSpecificModels(string Marka)
        {
            return _appDbContext.Motocykle;
        }

        public Motocykl PobierzMotocykl(int motocyklId)
        {
           return _appDbContext.Motocykle.FirstOrDefault(s => s.Id == motocyklId );
        }

        public IEnumerable<Motocykl> PobierzWszystkieMotocykle()
        {
            return _appDbContext.Motocykle;
        }
    }
}
