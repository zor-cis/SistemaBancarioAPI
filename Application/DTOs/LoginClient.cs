using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class LoginClient
    {
        //Esta clase representa un cliente que inicia sesión en el sistema.
        public string Email { get; set; }
        public string Password { get; set; }

        //Constructor que inicializa los atributos del cliente y valida que los datos sean correctos.
        public LoginClient(string email, string password) 
        { 
            if(string.IsNullOrEmpty(email))
                throw new ArgumentException("El correo electrónico no puede estar vacío");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("La contraseña no puede estar vacía");
            Email = email;
            Password = password;
        }
    }
}
