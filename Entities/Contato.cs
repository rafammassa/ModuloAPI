using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rafae.OneDrive.Área de Trabalho.workspace.ModuloAPI.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}