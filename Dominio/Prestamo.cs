using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{   ///<summary>
    ///Resumen: Esta clase nos permite definir un prestamo de un ejemplar de un libro.
    ///</summary>
    public class Prestamo
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
        public EstadoPrestamo EstadoPrestamo { get; set; }
        /// <summary>
        /// Resumen: Estado de devolucion del ejemplar( Bueno,Malo)
        public EstadoEjemplar EstadoDevolucion { get; set; }
        /// <summary>
        /// Resumen: Nombre del usuario que solicito el prestamo.
        /// </summary>
        public string nombreUsuario { get; set; }
        [ForeignKey("nombreUsuario")]
        /// <summary>
        /// Resumen: Instancia del usuario relacionado al prestamo.
        /// </summary>
        public virtual UsuarioSimple Usuario { get; set; }
        /// <summary>
        /// Resumen: Clave foranea que nos permite relacionar el prestamo con un ejemplar.
        /// </summary>
        public int idEjemplar { get; set; }
        [ForeignKey("idEjemplar")]
        /// <summary>
        /// Resumen: Instancia del ejemplar relacionado al prestamo.
        /// </summary>
        public virtual Ejemplar Ejemplar { get; set; }
    
        /// <summary>
        /// Resumen Este metodo nos permite calcular la fecha limite para un prestamo en funcion del Scoring del usuario que solicita el prestamo
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Fecha limite del prestamo</returns>
        public DateTime CalcularFechaLimite()
        {
            int scoring = Usuario.Scoring;

            if (scoring >= 0)
            {
                int aux = scoring / 5;
                if (aux >= 10)
                {
                    return DateTime.Now.AddDays(15);
                }
                else return DateTime.Now.AddDays(5 + aux);
            }
            else return DateTime.Now.AddDays(5);
        }
        /// <summary>
        /// Resumen: Constructor de la clase
        /// </summary>
        /// <param name="usuario">Usuario que solicita el prestamo</param>
        /// <param name="ejemplar">Ejemplar que se presta</param>   
        /// <param name="libro">Libro que se presta</param>
        public Prestamo(UsuarioSimple usuario, Ejemplar ejemplar)
        {
            FechaPrestamo = DateTime.Now.ToShortDateString();
            FechaLimite = CalcularFechaLimite().ToShortDateString();
            nombreUsuario = usuario.nombreUsuario;
            Usuario = usuario;
            idEjemplar = ejemplar.Id;
            Ejemplar = ejemplar;
            EstadoPrestamo = EstadoPrestamo.Normal;
          
        }
        /// <summary>
        /// Resumen: Constructor de la clase
        /// </summary>
        public Prestamo()
        {

        }
        /// <summary>
        /// Resumen: Este metodo nos permite actualizar el estado del prestamo  del prestamo y devolverlo
        /// </summary>
        /// <returns>Estado del prestamo</returns>
        public EstadoPrestamo ActualizarEstado()
        {
            if (Retrasado() )
            {
                EstadoPrestamo = EstadoPrestamo.Retrasado;
            }
            else if (ProximoAVencerse() )
            {
                EstadoPrestamo = EstadoPrestamo.ProximoAVencer;
            }
            else
            {
                EstadoPrestamo = EstadoPrestamo.Normal;
            }
            return EstadoPrestamo;
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
        /// <summary>
        /// Resumen: Este metodo nos permite actualizar el scoring de un usuario luego de devuelto el ejemplar.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public int CalcularScoring()
        {
            int scoring = this.Usuario.Scoring;
            if (EstadoDevolucion == EstadoEjemplar.Malo)
            {   
                    scoring -= 10;
            }
          
            if (Retrasado())
            {
                TimeSpan difFechas = Convert.ToDateTime(FechaDevolucion) - Convert.ToDateTime(FechaLimite);
                int dias = difFechas.Days;
                scoring -= 2 * dias;
            }
             
           if (EstadoDevolucion == EstadoEjemplar.Bueno && !Retrasado())
            {
                scoring += 5;
            }
            if (scoring<0)//Para que el scoring no sea negativo
            {
              scoring = 0;
            }
            return scoring;
        }
        /// <summary>
        /// Resumen: Este metodo nos permite registrar la devolucion de un ejemplar
        /// </summary>
        /// <param name="estadoDevolucion">Estado de devolucion del ejemplar</param>
        public void RegistrarDevolucion(EstadoEjemplar estadoDevolucion)
        {
            EstadoDevolucion = estadoDevolucion;
            if (estadoDevolucion == EstadoEjemplar.Malo)
            {
                Ejemplar.Disponible = false;
                Ejemplar.Estado = estadoDevolucion;
                Ejemplar.Baja = true;
            }
            else
            {
                Ejemplar.Disponible = true;
                Ejemplar.Estado = estadoDevolucion;
                Ejemplar.Baja = false;
            }
            FechaDevolucion = DateTime.Now.Date.ToString();
            Usuario.Scoring = CalcularScoring();
        }
    }
}
