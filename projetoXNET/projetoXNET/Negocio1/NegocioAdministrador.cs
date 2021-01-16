using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using projetoXNET.basica;
using projetoXNET.repositorio;

namespace projetoXNET.Negocio1
{
    public class NegocioAdministrador
    {
        RepositorioAdministrador repositorioAdministrador = new RepositorioAdministrador();
        public void validarloginAdministrador(Administrador administrador)
        {


            if (administrador.Login == null || administrador.Login.Trim().Equals(""))
            {
                throw new Exception("Campo Login de  Administrador Inválido para Login");
            }
            if (administrador.Senha == null || administrador.Senha.Trim().Equals(""))
            {
                throw new Exception("Campo Senha de  Administrador Inválido para Login");
            }
            this.repositorioAdministrador.loginAdministrador(administrador);

        }
    }
}
