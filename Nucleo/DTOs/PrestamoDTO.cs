using System;


namespace Nucleo.DTOs
{
    public class PrestamoDTO
    {   ///<summary>
        ///Resumen: Clave primaria que nos permite diferenciar los prestamos.
        ///</summary>
        public int Id { get; set; }
        /// <summary>
        /// Resumen: Fecha en la que se realizo el prestamo.
        /// </summary>
        public string FechaPrestamo { get; set; }
        /// <summary>
        /// Resumen: Fecha en la que vence el presamo.
        /// </summary>
        public string FechaLimite { get; set; }//Fecha en la que vence el presamo
        /// <summary>
        /// resumen: Fecha en la que se devolvio el prestamo (si fue devuelto).
        /// </summary>
        public string FechaDevolucion { get; set; }
        /// <summary>   
        /// Resumen: Estado del ejemplar(Normal,Proximo a vencer,Retrasado)
        /// </summary>
        public string EstadoPrestamo { get; set; }
        /// <summary>
        /// Resumen: Estado de devolucion del ejemplar( Bueno,Malo)
        public string EstadoDevolucion { get; set; }
        /// <summary>
        /// Resumen: Nombre del usuario que solicito el prestamo.
        /// </summary>
        public string nombreUsuario { get; set; }
       
        /// <summary>
        /// Resumen: Clave foranea que nos permite relacionar el prestamo con un ejemplar.
        /// </summary>
        public int idEjemplar { get; set; }


        /// <summary>
        /// Resumen Este metodo nos permite calcular la fecha limite para un prestamo en funcion del Scoring del usuario que solicita el prestamo
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Fecha limite del prestamo</returns>

        /// <summary>
        /// Resumen: Constructor de la clase
        /// </summary>
        public PrestamoDTO(int id,string pNombreUsuario, int PIdEjemplar,string fechaPrestamo,string fechaLimite, string estadoPrestamo,string estadoDevolucion)
        {   Id = id;
            FechaPrestamo = fechaPrestamo;
            FechaLimite = fechaLimite;
            nombreUsuario = pNombreUsuario;
            idEjemplar = PIdEjemplar;
            EstadoPrestamo = estadoPrestamo;
            EstadoDevolucion = estadoDevolucion;
        }
        /// <summary>
        /// Resumen: Constructor de la clase
        /// </summary>
        public PrestamoDTO()
        {

        }
   
        
        /// <summary>
        /// Resumen: Este metodo nos permite saber si el prestamo se encuenta retrasado
        /// </summary>
        /// <returns>True si el prestamo esta retrasado</returns>
        public bool Retrasado()
        {
            if ((DateTime.Now.Date >= Convert.ToDateTime(FechaLimite).Date))
            {
                if (string.IsNullOrEmpty(FechaDevolucion) || (Convert.ToDateTime(FechaDevolucion).Date >= Convert.ToDateTime(FechaLimite).Date))
                { return true; }
                else return false;
            }
            else return false;
        }
        /// <summary>
        /// Resumen: Este metodo nos permite saber si el prestamo esta proximo a vencerse
        /// </summary>
        /// <returns>True si el prestamo esta proximo a vencerse</returns>
        public bool ProximoAVencerse()
        {
            int cantDiasParaConsiderarseProximo = 3;
            if (!this.Retrasado())
            {
                if (string.IsNullOrEmpty(FechaDevolucion))
                {
                    TimeSpan diferenciaEntreFechas = Convert.ToDateTime(FechaLimite) - DateTime.Now;
                    int dias = diferenciaEntreFechas.Days;
                    if (dias < cantDiasParaConsiderarseProximo)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
       
       
        
}
}
