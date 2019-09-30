using _07_Fiap.WebAspNEt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Fiap.WebAspNEt.Repositories
{
    interface ICelaRepository
    {
        void Create(Cela cela);
        void Update(Cela cela);
        void Delete(int id);
        IList<Cela> List();
        Cela findById(int id);

    }
}
