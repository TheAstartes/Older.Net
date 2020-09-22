using System.Collections.Generic;

namespace TheShop.Models
{
    public interface IMotocyklRepository
    {
        IEnumerable<Motocykl> PobierzWszystkieMotocykle();
        Motocykl PobierzMotocykl(int motocyklId);
        IEnumerable<Motocykl> GetSpecificModels(string Marka);
        IEnumerable<Motocykl> GetModels(int mId);
    }
}
