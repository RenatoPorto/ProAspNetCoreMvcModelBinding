using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcModelBinding
{
    public class Pessoa : Controller
    {
        public int PessoaId { get; internal set; }
    }
}
