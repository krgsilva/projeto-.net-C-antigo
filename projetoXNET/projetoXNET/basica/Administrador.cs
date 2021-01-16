using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetoXNET.basica
{
    public sealed class Administrador
    {
        private String login;

        public String Login
        {
            get { return login; }
            set { login = value; }
        }
        private String senha;

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
