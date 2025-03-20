using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Nucleo.DTOs
{
    public class  Mapeador
    {   ///<summary>
        ///Resumen: Este metodo nos permite mapear un usuario simple a un usuario simple DTO.
        ///</summary>
        /// <param name="usuarioSimple">Usuario simple a mapear</param>
        /// <returns>Usuario simple DTO</returns>
        public UsuarioSimpleDTO Mapear(UsuarioSimple usuarioSimple)
        {   
            UsuarioSimpleDTO usuarioSimpleDTO = new UsuarioSimpleDTO(usuarioSimple.Nombre, usuarioSimple.Apellido, usuarioSimple.FechaNacimiento, usuarioSimple.Mail, usuarioSimple.Telefono, usuarioSimple.nombreUsuario, usuarioSimple.Scoring);
            return usuarioSimpleDTO;
        }

     }


}
