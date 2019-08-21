using ProAspNetCoreMvcModelBinding.Models;
using System.Collections.Generic;

namespace ProAspNetCoreMvcModelBinding.Repository
{

    public interface IRepository
    {
        IEnumerable<Pessoa> Pessoa { get; }
        Pessoa this[int id] { get; set; }
    }
}

