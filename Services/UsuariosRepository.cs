using Microsoft.EntityFrameworkCore;
using TpiBarberShop.DBContexts;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly Context _context;

        public UsuariosRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<EUsuarios> GetUsuarios()
        {
            return _context.Usuarios.OrderBy(u => u.Nombre).ToList();
        }


        public EUsuarios? ValidateUser(UsuariosLoginDTO usuario)
        {
            // Validar las credenciales del usuario
            var user = _context.Usuarios.FirstOrDefault(p => p.Nombre == usuario.Nombre && p.Password == usuario.Password);
            if (user == null)
                return null;

           

            return user;
        }

        public EUsuarios? GetUsuarios(int idUsuario)
        {
            return _context.Usuarios.Find(idUsuario);
        }

         public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void EliminarUsuario(EUsuarios usuario)
        {
            _context.Usuarios.Remove(usuario);
        }

        public void AgregarUsuario(EUsuarios UsuarioNuevo)
        {

            _context.Usuarios.Add(UsuarioNuevo);

        }


        //public EUsuarios? ValidateUser(UsuariosDTO usuario)
        //{
        //    if (string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Password))
        //        return null;

        //    return _context.ValidateUser(usuario);
        //}



    }
}
