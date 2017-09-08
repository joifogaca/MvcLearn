using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLearn.Models
{
    public class Usuarios
    {
        public List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();
        public Usuarios()
        {
            listaUsuarios.Add(new UsuarioModel
            {
                nome = "Jose Mario",
                sobrenome = "Santos",
                endereco = "Monte Serrano, 162",
                email = "j.mario@yahoo.com",
                nascimento = Convert.ToDateTime("05/09/1948")


            });

            listaUsuarios.Add(new UsuarioModel
            {
                nome = "Felipe Felix",
                sobrenome = "Santos",
                endereco = "Joaquim Campos, 165",
                email = "ff.santos@yahoo.com",
                nascimento = Convert.ToDateTime("15/09/1988")


            });

            listaUsuarios.Add(new UsuarioModel
            {
                nome = "Denise Aparecida",
                sobrenome = "Silva",
                endereco = "Av. Capitão Mor Aguiar, 62",
                email = "denise.ap@yahoo.com",
                nascimento = Convert.ToDateTime("02/06/1988")


            });
        }

        public void CriarUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuarios.Add(usuarioModelo);
        }

        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach (UsuarioModel usuario in listaUsuarios)
            {
                if (usuario.email == usuarioModelo.email)
                {
                    listaUsuarios.Remove(usuario);
                    listaUsuarios.Add(usuarioModelo);
                    break;
                }

            }




        }

        public UsuarioModel GetUsuario(string Email)
        {
            UsuarioModel _usuarioModel = null;
            foreach (UsuarioModel _usuario in listaUsuarios)
            {
                if (_usuario.email == Email)
                { _usuarioModel = _usuario;
                break;
                }
            }
            return _usuarioModel;
        }

        public void DeletarUsuario(String Email)
        { 
            foreach (UsuarioModel _usuario in listaUsuarios)
            {
                if (_usuario.email == Email)
                { listaUsuarios.Remove(_usuario);
                break;
                }
            }
        }
    }
}