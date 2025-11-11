using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario
    {
        private Int32 _idUsuario;
        private String _nome;
        private String _email;
        private String _senha;

        public Int32 IdUsuario { get => getIdUsuario(); set => setIdUsuario(value); }
        public String Nome { get => getNome(); set => setNome(value); }
        public String Email { get => getEmail(); set => setEmail(value); }
        public String Senha { get => getSenha(); set => setSenha(value); }

        public Usuario(Int32 idUsuario, String nome, String email, String senha)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        private Int32 getIdUsuario()
        {
            return _idUsuario;
        }
        private void setIdUsuario(Int32 valor)
        {
            _idUsuario = valor;
        }
        private String getNome()
        {
            return _nome;
        }
        private void setNome(String valor)
        {
            _nome = valor;
        }
        private String getEmail()
        {
            return _email;
        }
        private void setEmail(String valor)
        {
            _email = valor;
        }
        private String getSenha()
        {
            return _senha;
        }
        private void setSenha(String valor)
        {
            _senha = valor;
        }
    }
}
