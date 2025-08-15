using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioLib
{
    internal record FormularioDTO( string Cpf, string Cargo, int Idade)
    {
        public string Name { get; set; }

        public void updateNome(string name)
        {
            Name = name;
        }
    }
}
