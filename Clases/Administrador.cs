namespace CajaRegistradora.Clases
{
    internal class Administrador : Usuario
    {
        public Administrador(string username, string password) : base(username, password, false)
        {
        }
    }
}
