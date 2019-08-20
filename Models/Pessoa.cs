using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProAspNetCoreMvcModelBinding.Models.Permitir;

namespace ProAspNetCoreMvcModelBinding.Models
{
    public class Pessoa : Controller
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Aprovado { get; set; }
        public Permissao Permissao { get; set; }
    }
}

    
