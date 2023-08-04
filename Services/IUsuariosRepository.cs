using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public interface IUsuariosRepository
    {
        void AgregarUsuario(EUsuarios usuarioNuevo);
        void EliminarUsuario(EUsuarios usuario);
        bool ExisteEmail(string email);
        bool ExisteNombreUsuario(string nombre);
        public IEnumerable<EUsuarios> GetUsuarios();
        public EUsuarios? GetUsuarios(int idUsuario);
        bool GuardarCambios();
        EUsuarios? ValidateUser(UsuariosLoginDTO authParams);
     
    }
}
