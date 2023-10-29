using TpiBarberShop.DTOs.Usuario;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public interface IUsuariosRepository
    {
        void AgregarUsuario(EUsuarios usuarioNuevo);
        void EliminarUsuario(EUsuarios usuario);
        bool ExisteEmail(string email);

        EUsuarios ValidateToken(string token);
        EUsuarios ResetPass(string token);


        EUsuarios ForgotPassword(string email);


        bool ExisteNombreUsuario(string nombre);
        public IEnumerable<EUsuarios> GetUsuarios();
        public EUsuarios? GetUsuarios(int idUsuario);
        bool GuardarCambios();
        EUsuarios? ValidateUser(UsuariosLoginDTO authParams);
        bool EnviarEmail(string emailTo, string token);
        bool EnviarEmailVerificacion(string emailTo, string token);
    }
}
