﻿using System;
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
        /// resumen: Estado del prestamo: normal, por vencer, retrasado o devuelto.
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
        /// Resumen: Constructor de la clase
        /// </summary>
        /// <param name="usuario">Usuario que solicita el prestamo</param>
        /// <param name="ejemplar">Ejemplar que se presta</param>   
        /// <param name="libro">Libro que se presta</param>
        public Prestamo(UsuarioSimple usuario, DateTime fechaLimite, Ejemplar ejemplar)
        {
            FechaPrestamo = DateTime.Now.ToShortDateString();
            FechaLimite = fechaLimite.ToShortDateString();
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
        /// Resumen: Este metodo nos permite saber si el prestamo se encuenta retrasado
        /// </summary>
        /// <returns>True si el prestamo esta retrasado</returns>
        public bool Retrasado()
        {
            if ((DateTime.Now.Date > Convert.ToDateTime(FechaLimite).Date && FechaLimite!=null))
            {
                if (EstadoPrestamo != EstadoPrestamo.Devuelto )
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
            if (this.Retrasado()|| FechaLimite==null)
            { return false; }
            else
            {
                    TimeSpan diferenciaEntreFechas = Convert.ToDateTime(FechaLimite) - DateTime.Now;
                    int dias = diferenciaEntreFechas.Days;
                    if (dias < cantDiasParaConsiderarseProximo)
                    {
                        return true;
                    }
                    else 
                        return false;
            }
         
        }
        /// <summary>
        /// Resumen: Este metodo nos permite actualizar el scoring de un usuario luego de devuelto el ejemplar.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        /// <summary>
        /// Resumen: Este metodo nos permite registrar la devolucion de un ejemplar
        /// </summary>
        /// <param name="estadoDevolucion">Estado de devolucion del ejemplar</param>
        public void RegistrarDevolucion(EstadoEjemplar estadoDevolucion)
        {
            EstadoDevolucion = estadoDevolucion;
            EstadoPrestamo = EstadoPrestamo.Devuelto;

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
            EstadoPrestamo = EstadoPrestamo.Devuelto;
            Usuario.Scoring = CalcularScoring();
        }

        public int CalcularScoring()
        {
            int scoring = this.Usuario.Scoring;
            if (EstadoDevolucion == EstadoEjemplar.Malo)
            {
                scoring -= 10;
            }

            if (Retrasado())
            {
                TimeSpan difFechas = DateTime.Now - Convert.ToDateTime(FechaLimite);
                int dias = difFechas.Days;
                scoring -= 2 * dias;
            }

            if (EstadoDevolucion == EstadoEjemplar.Bueno && !Retrasado())
            {
                scoring += 5;
            }
            if (scoring < 0)//Para que el scoring no sea negativo
            {
                scoring = 0;
            }
            return scoring;
        }
    }
}
