using Microsoft.EntityFrameworkCore;
using MimeKit;
using TpiBarberShop.DBContexts;
using TpiBarberShop.DTOs.Usuario;
using TpiBarberShop.Entities;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
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
            //return _context.Usuarios.Include(c => c.Compras).ToList();
            return _context.Usuarios.Include(c => c.Imagen).Include(x => x.Compras).ToList();

        }


        public EUsuarios? ValidateUser(UsuariosLoginDTO usuario)
        {
            // Validar las credenciales del usuario
            // Buscar al usuario por nombre de usuario
            var user = _context.Usuarios.FirstOrDefault(p => p.Nombre == usuario.Nombre);

            if (user == null)
            {
                // El usuario no existe
                return null;
            }

            // Verificar la contraseña proporcionada con el hash almacenado
            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(usuario.Password, user.Password);

            if (!isPasswordValid)
            {
                // La contraseña es incorrecta
                return null;
            }

            // El usuario ha sido autenticado exitosamente
            return user;
        }

        public EUsuarios? GetUsuarios(int idUsuario)
        {
            return _context.Usuarios.Include(c => c.Compras).Include(c => c.Imagen).Where(c => c.Id == idUsuario).FirstOrDefault();

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

        public bool ExisteNombreUsuario(string nombre)
        {
            return _context.Usuarios.Any(u => u.Nombre == nombre);
        }

        public bool ExisteEmail(string email)
        {
            return _context.Usuarios.Any(u => u.Email == email);
        }

        public EUsuarios ValidateToken(string token)
        {
            var user = _context.Usuarios.FirstOrDefault(p => p.VerificationToken == token);

            if (user == null)
            {
                // El usuario no existe
                return null;
            }


            return user;
        }

        public EUsuarios ForgotPassword(string email)
        {
            var user = _context.Usuarios.FirstOrDefault(p => p.Email == email);

            if (user == null)
            {
                // El usuario no existe
                return null;
            }


            return user;
        }

        public EUsuarios ResetPass(string token)
        {
            var user = _context.Usuarios.FirstOrDefault(p => p.PasswordResetToken == token);

            if (user == null)
            {
                // El usuario no existe
                return null;
            }


            return user;
        }

        public bool EnviarEmailVerificacion(string emailTo, string token)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Nombre Remitente", "NAVAJAFINA"));
            message.To.Add(new MailboxAddress("Nombre Destinatario", emailTo));
            message.Subject = "Recuperación de contraseña";

            var builder = new BodyBuilder();
            builder.TextBody = $"Hemos recibido una solicitud para verificar tu cuenta. Tu token de verificación es: http://localhost:3000/VerificarTokenEmail/{token}";

            message.Body = builder.ToMessageBody();

            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false); // Cambia esto según tu proveedor de correo
                    client.Authenticate("valentifranco23@gmail.com", "mupj odqy mbsv xecj"); // Utiliza la contraseña de aplicación
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Maneja los errores aquí, por ejemplo, registra el error en un archivo de registro
                return false;
            }
        }
        public bool EnviarEmail(string emailTo, string token)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Nombre Remitente", "NAVAJAFINA"));
            message.To.Add(new MailboxAddress("Nombre Destinatario", emailTo));
            message.Subject = "Recuperación de contraseña";

            var builder = new BodyBuilder();
            builder.TextBody = $"Hemos recibido una solicitud para restablecer tu contraseña. Tu token de reinicio es: {token}";

            message.Body = builder.ToMessageBody();

            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false); // Cambia esto según tu proveedor de correo
                    client.Authenticate("valentifranco23@gmail.com", "mupj odqy mbsv xecj"); // Utiliza la contraseña de aplicación
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Maneja los errores aquí, por ejemplo, registra el error en un archivo de registro
                return false;
            }
        }

        //public EUsuarios? ValidateUser(UsuariosDTO usuario)
        //{
        //    if (string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Password))
        //        return null;

        //    return _context.ValidateUser(usuario);
        //}



    }
}
