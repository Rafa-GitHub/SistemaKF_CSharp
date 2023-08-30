using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaKF
{
    internal static class CadastroUsuario
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){ nome = "Rafael", senha = "2023"},
        };

        private static Usuario _userLogado = null;

        public static Usuario usuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nome == nome && usuario.senha == senha)
                {
                    usuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }

    }

}

