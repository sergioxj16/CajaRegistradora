namespace CajaRegistradora.Clases
{
    internal class UsuarioNormal : Usuario
    {
        public UsuarioNormal(string username, string password) : base(username, password, false)
        {
        }
    }
}
