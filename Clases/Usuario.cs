public abstract class Usuario
{
    protected string nombre;
    protected string contrasena;

    public Usuario(string nombre, string contrasena)
    {
        this.nombre = nombre;
        this.contrasena = contrasena;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Contrasena { get => contrasena; set => contrasena = value; }

    public static bool VerificarCredenciales(string nombre, string contrasena)
    {

        try
        {
            string rutaArchivo = @"Datos\usuarios.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);
            foreach (string linea in lineas)
            {
                string[] datosUsuario = linea.Split(':');
                string nombreUsuario = datosUsuario[0];
                string contrasenaUsuario = datosUsuario[1];
                if (nombreUsuario == nombre && contrasenaUsuario == contrasena)
                {
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error verificar credenciales" + ex.Message);
        }
        return false;
    }

    public static bool EsAdministrador(string nombre)
    {
        return false;
    }
}