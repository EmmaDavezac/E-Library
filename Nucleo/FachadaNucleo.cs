using BibliotecaEncriptacion;
using Bitacora;//Libreria que nos permite registrar logs en la bitacora
using DAL;//Libreria de la capa de acceso a datos,nos permite interactuar con la base de datos, brindandonos control sobre la misma
using DAL.EntityFramework;
using Dominio;//Liberia que contiene las clases de dominio  
using NotificacionAUsuario;//Libreria que nos permite notificar a usuarios con prestamos retrasados o proximos a vencer
using Nucleo.DTOs;
using ServiciosAPILibros;//Libreria que nos permite interactuar con la API de libros, pudiendo hacer consultas y obtener informacion acerca de libros
using System;
using System.Collections.Generic;



namespace Nucleo

{
    /// <summary>
    ///  Fachada del programa
    /// </summary>
    /// <remarks> Resumen: Representa la fachada del programa, nos permite acceder a todas las funciones del programa sin dar a conocer como funcionan por dentro</remarks>
    public class FachadaNucleo
    {
        ///<summary>
        ///Resumen: Esta variable nos permite interactuar con la API de libros, pudiendo hacer consultas y obtener informacion acerca de libros.
        ///</summary>  
        private IServicioAPILibros ServicioAPILibros = new APIOpenLibrary();
        /// <summary>
        /// Resumen: Esta variable nos permite notificar a los usuarios con prestamos retrasados o proximos a vencer.
        /// </summary>
        private INotificadorUsuario NotificadorUsuarios = new NotificadorOutlook();
        /// <summary>
        /// Resumen: Esta variable nos permite registrar logs en la bitacora.
        /// </summary>
        private IBitacora bitacora = new ImplementacionBitacora();
        /// <summary>
        /// Resumen: Encriptador que nos permite encriptar y desencriptar la contraseña del administrador.
        /// </summary>
        private IEncriptador encriptador = new EncriptadorCesar();
        private Mapeador mapeador = new Mapeador();




        /// <summary>
        /// Resumen: Este metodo nos permite obtener alguna de las implementaciones posibles para las base de datos, interactua con la interfaz IUnitOfWork, esta abtraccion nos permite poder trabajar con distintas implementaciones
        /// </summary>
        /// <returns></returns>
        private IUnitOfWork GetUnitOfWork()
        {
            return new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext());//implementacion por defecto,implementacion en una base de datos relacional en un servidor local de MSQLSERVER
        }

        /// <summary>
        /// Resumen: Constructor de la clase
        /// </summary>
        public FachadaNucleo()
        {
        }

        /// <summary>
        /// Permite registrar un nuevo usuario simple en la base de datos.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del nuevo usuario simple</param>
        /// <param name="nombre">Nombre o nombres del nuevo usuario</param>
        /// <param name="apellido">Apellido o apellidos del nuevo usuario</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del nuevo usuario</param>
        /// <param name="mail">Email del nuevo usuario</param>
        /// <param name="telefono">Telefono del nuevo usuario</param>
        /// <returns> true si la operacion es exitosa y false si fue erronea</returns>
        public void AñadirUsuario(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono)
        {
            UsuarioSimple usuario = new UsuarioSimple(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario);//Instanciamos un usuario con los datos pasados por parametro
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
               
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioUsuarios.Add(usuario);//Añado el usuario a la base de datos
                    unitOfWork.Complete();//Guardamos los cambios
                }

            }
            catch (Exception ex)
            {
                msg = "Error al registrar usuario (" + nombre + "-" + apellido + ")" + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener un usuario simple de la base de datos a partir del nombreUsuario del usuario.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del usuario deseado</param>
        /// <returns>Un usuario simple</returns>
        public UsuarioSimpleDTO ObtenerUsuario(string pNombreUsuario)

        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            UsuarioSimpleDTO usuario = null;//Creamos una variable de tipo usuario que sera devuelta por el metodo
            try
            {


                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    usuario = mapeador.Mapear(unitOfWork.RepositorioUsuarios.Get(pNombreUsuario));//Asignamos al usuario el valor obtenido por el get a la base de datos
                }
                return usuario;//Devolvemos el usuario
            }
            catch (Exception ex)
            {
                msg = "Error al obtener el usuario (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                return usuario;//Devolvemos el usuario
                throw new Exception(msg);
            }
        }



        /// <summary>
        /// Resumen: Permite actualizar la informacion de un usuario simple.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario</param>
        /// <param name="nombre">Nombre o nombres del usuario</param>
        /// <param name="apellido">Apellido o apellidos del usuario</param>
        /// <param name="pFechaNacimiento">Fecha de nacimiento del usuario</param>
        /// <param name="mail">Email del usuario</param>
        /// <param name="telefono">Telefono del usuario</param>
        public void ActualizarUsuario(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Usuario " + pNombreUsuario + " Actualizado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Nombre = nombre;//Modificamos uno por uno los valores por los parametros pasados
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Apellido = apellido;
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).FechaNacimiento = Convert.ToDateTime(pFechaNacimiento);
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Mail = mail;
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Telefono = telefono;
                    unitOfWork.Complete();//Guardamos los cambios
                }

            }
            catch (Exception ex)
            {
                msg = "Error al actualizar el usuario (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);

            }
        }

        /// <summary>
        /// Resumen: Permite registrar un nuevo usuario administrador en la base de datos.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del nuevo administrador</param>
        /// <param name="nombre">Nombre o nombre del nuevo usuario administrador</param>
        /// <param name="apellido">Apellido o apellidos del usuario administrador</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del administrador</param>
        /// <param name="mail">Email del administrador</param>
        /// <param name="contraseña">Constraseña del administrador</param>
        /// <param name="telefono">Telefono del administrador</param>
        /// <returns>True si el registro es exitoso, en caso contrario False.</returns>
        public void AñadirAdministrador(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono)

        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            UsuarioAdministrador usuario = new UsuarioAdministrador(nombre, apellido, fechaNacimiento, mail, encriptador.Encriptar(contraseña), telefono, pNombreUsuario);//Instanciamos un administrador con los datos pasados por parametro
            try
            {
                msg = "Administrador " + pNombreUsuario + " registrado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Add(usuario);//Añadimos el administrador a la base de datos
                    unitOfWork.Complete();//Guardamos los cambios
                }

            }
            catch (Exception ex)
            {
                msg = "Error al Registrar el administrador (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);

            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener un usuario administrador de la base de datos a partir del nombreUsuario del usuario administrador.
        /// </summary>
        /// <param name="pNombreAdministrador">Nombre de usuario del administrador que se desea obtener</param>
        /// <returns>Un UsuarioAdministrador o null</returns>
        public UsuarioAdministradorDTO ObtenerAdministrador(string pNombreAdministrador)
        {
            UsuarioAdministradorDTO administrador = new UsuarioAdministradorDTO();//Instanciamos un administrador para que luego sea devuelto como resultado
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    administrador = mapeador.Mapear(unitOfWork.RepositorioAdministradores.Get(pNombreAdministrador));//Asignamos a la variable administrado instanciada el valor que nos devuelve el get.
                }

            }
            catch (Exception ex)
            {
                msg = "Error al obtener el administrador (" + pNombreAdministrador + " ) " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);

            }
            return administrador;//Devolvemos el administrador
        }

        /// <summary>
        /// Resumen: Permite actualizar la informacion de un usuario administrador.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del administrador</param>
        /// <param name="nombre">Nombre o nombres del administrador</param>
        /// <param name="apellido">Apellido o apellidos del administrador</param>
        /// <param name="pFechaNacimiento">Fecha de nacimiento del administrador</param>
        /// <param name="mail">Email del administrador</param>
        /// <param name="telefono">Telefono del administrador</param>
        public void ActualizarAdministrador(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Administrador " + pNombreUsuario + " actualizado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Nombre = nombre;//Modificamos uno por uno los valores por los parametros pasados
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Apellido = apellido;
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).FechaNacimiento = Convert.ToDateTime(pFechaNacimiento);
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Mail = mail;
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Telefono = telefono;
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar el administrador (" + pNombreUsuario + " ) " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);

            }
        }

        /// <summary>
        /// Resumen: Este metodo permite actualizar la contraseña de un administrador
        /// </summary>
        /// <param name="pNombreAdministrador"></param>
        /// <param name="contraseña"></param>
        public void ActualizarContraseñaAdministrador(string pNombreAdministrador, string contraseña)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Contraseña del administrador " + pNombreAdministrador + " actualizada con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreAdministrador).Pass=encriptador.Encriptar(contraseña);//Modificamos la contraseña actual por la que pasamos como parametro
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar la contraseña del administrador (" + pNombreAdministrador + " ) " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);

            }

        }

        /// <summary>
        /// Resumen: Este metodo nos permite registrar un nuevo libro en la base de datos.
        /// </summary>
        /// <param name="unISBN">ISBN del libro</param>
        /// <param name="titulo">Titulo del libro</param>
        /// <param name="autor">Autor del libro</param>
        /// <param name="añoPublicacion">Año de publicacion del libro</param>
        /// <param name="pCantidadEjempalares">Cantidad de ejemplares del libro</param>
        /// <returns>True si el registro fue exitoso, False en caso contrario</returns>
        public void AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            bool resultado = true;
            try
            {
                Libro libro = new Libro(unISBN, titulo, autor, añoPublicacion);//Instanciamos un libro con los parametros pasados al metodo.
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    foreach (var item in unitOfWork.RepositorioLibros.GetAllISBN())
                    {
                        if (item == unISBN)
                        {
                            resultado = false;
                            break;
                        }
                    }
                    if (resultado == true)
                    {
                        foreach (var item in unitOfWork.RepositorioLibros.GetAllTitulo())
                        {
                            if (item == titulo)
                            {
                                resultado = false;
                                break;
                            }
                        }
                    }
                    if (resultado == true)
                    {
                        unitOfWork.RepositorioLibros.Add(libro);//Añadimos el libro a la base de datos
                                                                //  this.AñadirEjemplares(unitOfWork.RepositorioLibros.GetAll().Last().Id,pCantidadEjempalares);

                        unitOfWork.Complete();//Guardamos los cambios
                    }
                }

            }
            catch (Exception ex)
            {

                msg = "Error al registrar el libro ( Titulo: " + titulo + " Autor: " + autor + " ISBN:" + unISBN + " ) ." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener un libro de la base de datos a partir del id del mismo .
        /// </summary>
        /// <param name="id">ID del libro</param>
        /// <returns>Libro o null</returns>
        public LibroDTO ObtenerLibro(int id)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            LibroDTO libro = new LibroDTO();//Instanciamos un libro que sera devuelto por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    libro = mapeador.Mapear(unitOfWork.RepositorioLibros.Get(id));
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener el libro (Id: " + id + " ) ." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }

            return libro;//Devolvemos el libro
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener un ejemplar de libro de la base de datos .
        /// </summary>
        /// <param name="id">id del ejemplar</param>
        /// <returns>EjemplarDTO</returns>
        public EjemplarDTO ObtenerEjemplar(int id)
        {
            EjemplarDTO ejemplarDTO = new EjemplarDTO();
            string msg;
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())
                {
                    Ejemplar ejemplar = unitOfWork.RepositorioEjemplares.Get(id);
                    ejemplarDTO = new Mapeador().Mapear(ejemplar);
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener el ejemplar (Id: " + id + " ) ." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);
                throw new Exception(msg);
            }
            return ejemplarDTO;
        }



        /// <summary>
        /// Resumen: Este metodo nos permite añadir mas ejemplares a un libro.
        /// </summary>
        /// <param name="pIdLibro">ID del libro al cual agregar ejemplares</param>
        /// <param name="pCantidad">Cantidad de ejemplares a agregar</param>
        public void AñadirEjemplares(int pIdLibro, int pCantidad)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = ("Ejemplares Añadidos a libro con exito (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ").");
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    for (int i = 1; i <= pCantidad; i++)//Añadimos la cantidad de ejemplares pasado como parametro al libro con un ciclo for.
                    {
                        Ejemplar ejemplar = new Ejemplar(unitOfWork.RepositorioLibros.Get(pIdLibro));//Instanciamos el nuevo ejemplar y le pasamos el objeto libro como parametro.
                        unitOfWork.RepositorioEjemplares.Add(ejemplar);//Añadimos el ejemplar a la base de datos.
                    }
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al Añadir ejemplares a libro (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ")." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);

            }
        }

  

        /// <summary>
        /// Resumen: Este metodo nos permite dar de baja un libro.
        /// </summary>
        /// <param name="pIdLibro">Id del libro</param>
        public void DarDeBajaUnLibro(int pIdLibro)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Libro Dado de baja con exito (Id: " + pIdLibro + ").";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    Libro libro = unitOfWork.RepositorioLibros.Get(pIdLibro);//Obtenemos el libro por medio del metodo get y lo asignamos a una variable libro.
                    libro.DarDeBaja();//Llamamos al metodo dar de baja del libro
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al dar de baja el libro (Id: " + pIdLibro + ")." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
        }


        /// <summary>
        /// Resumen: Este metodo nos permite dar de alta un libro previamente dado de baja.
        /// </summary>
        /// <param name="pIdLibro">Id del libro</param>
        public void DarDeAltaUnLibro(int pIdLibro)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Libro Dado de alta con exito (Id: " + pIdLibro + ").";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioLibros.Get(pIdLibro).DarDeAlta();//Obtnemos el libro a traves del parametro pasado, y llamamos al metodo DarDeAlta.
                    unitOfWork.Complete();//Guardamos los cambios.
                }
            }
            catch (Exception ex)
            {

                msg = "Error al dar de alta el libro (Id: " + pIdLibro + ")." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener la lista de ejemplares disponibles de un libro.
        /// </summary>
        /// <param name="id">ID del libro</param>
        /// <returns>Lista de ejemplares disponibles de un libro</returns>
        public List<EjemplarDTO> ObtenerEjemplaresDisponiblesLibro(int idLibro)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<EjemplarDTO> lista = new List<EjemplarDTO>();//Instanciamos una lista de ejemplares que sera devuelta por el metodo
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    foreach (var item in unitOfWork.RepositorioEjemplares.GetEjemplaresDisponiblesLibro(idLibro))
                    {
                        lista.Add(mapeador.Mapear(item));
                    }
                    return lista;//Devolvemos la lista
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de ejemplares Disponibles del libro (id: " + idLibro + ")." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                return lista;
                throw new Exception(msg);
            }

        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener la lista total de ejemplares de un libro.
        /// </summary>
        /// <param name="id">ID del libro</param>
        /// <returns>Lista total de ejemplares de un libro</returns>
        public List<EjemplarDTO> ObtenerEjemplaresLibro(int idLibro)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<EjemplarDTO> lista = new List<EjemplarDTO>();//Instanciamos una lista de ejemplares que sera devuelta por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    foreach (var item in unitOfWork.RepositorioEjemplares.GetEjemplaresLibro(idLibro))
                    {
                        lista.Add(mapeador.Mapear(item));
                    }
                }
                return lista;//Devolvemos la lista
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista total de ejemplares del libro (id: " + idLibro + ")." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                return lista;
                throw new Exception(msg);
            }

        }

        /// <summary>
        /// Resumen: Este metodo nos permite registrar un nuevo prestamo.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del usuario que solicita el prestamo</param>
        /// <param name="idEjemplar">ID del ejemplar del libro que se va a prestar </param>
        /// <param name="idLibro">ID del libro que se va a prestar</param>
        public void RegistrarPrestamo(string pNombreUsuario, DateTime fechaLimite, int idEjemplar)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    Ejemplar ejemplar = unitOfWork.RepositorioEjemplares.Get(idEjemplar);
                    UsuarioSimple usuario = unitOfWork.RepositorioUsuarios.Get(pNombreUsuario);
                    Prestamo prestamo = new Prestamo(usuario, fechaLimite, ejemplar);//Instancia de un prestamo con los valores que pasamos como parametro
                    unitOfWork.RepositorioEjemplares.Get(idEjemplar).Disponible = false;//El ejemplar del prestamo pasa a estar no diponible
                    unitOfWork.RepositorioPrestamos.Add(prestamo);//Añadimos el pretamo a la base de datos
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al registrar el Prestamo  (Id Ejemplar: " + idEjemplar + " Usuario: " + pNombreUsuario + ") ." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener un prestamo de la base de datos a partir del id del prestamo.
        /// </summary>
        /// <param name="id">ID del prestamo</param>
        /// <returns>Prestamo o null</returns>
        public PrestamoDTO ObtenerPrestamo(int id)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            PrestamoDTO prestamo = new PrestamoDTO();//Instanciamos un objeto del tipo prestamo que luego sera devuelto por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    prestamo = mapeador.Mapear(unitOfWork.RepositorioPrestamos.Get(id));//Obtenemos el prestamo y lo asignamos a la variable prestamo creada
                }
                return prestamo;
            }
            catch (Exception ex)
            {
                msg = "Error al obtener el prestamo (Id: " + id + ")." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                return prestamo;
                throw new Exception(msg);

            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite actualizar la informacion de un libro.
        /// </summary>
        /// <param name="id">ID del libro</param>
        /// <param name="unISBN">ISBN del libro</param>
        /// <param name="titulo">Titulo del libro</param>
        /// <param name="autor">Autor del libro</param>
        /// <param name="añoPublicacion">Año de publicacion del libro</param>
        public void ActualizarLibro(int id, string unISBN, string titulo, string autor, string añoPublicacion)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioLibros.Get(id).ISBN = unISBN;//Modificamos uno por uno los atributos del libro por los parametros pasados.
                    unitOfWork.RepositorioLibros.Get(id).Titulo = titulo;
                    unitOfWork.RepositorioLibros.Get(id).Autor = autor;
                    unitOfWork.RepositorioLibros.Get(id).AñoPublicacion = añoPublicacion;
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar el libro (Id: " + id + "titulo: " + titulo + "autor: " + autor + ")." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);

            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite registrar la devolucion de un Prestamo.
        /// </summary>
        /// <param name="idPrestamo">ID del Prestamo</param>
        /// <param name="estado">Estado de devolucion del ejemplar</param>
        public void RegistrarDevolucion(int idPrestamo, string estado)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = " Prestamo devuelto (Id Prestamo: " + idPrestamo + " Estado:" + estado + ")";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    if (estado == "Bueno")
                    {
                        unitOfWork.RepositorioPrestamos.Get(idPrestamo).RegistrarDevolucion(EstadoEjemplar.Bueno);//Obtenemos el prestamo por idPrestamo, y llamamos a su metodo registrar debolucion pasandole un EstadoEjemplar bueno
                    }
                    else unitOfWork.RepositorioPrestamos.Get(idPrestamo).RegistrarDevolucion(EstadoEjemplar.Malo);//Obtenemos el prestamo por idPrestamo, y llamamos a su metodo registrar debolucion pasandole un EstadoEjemplar malo

                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al registrar la devolucion del prestamo (Id Prestamo: " + idPrestamo + " Estado:" + estado + ")" + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite verificar que la combinacion NombreUsuario-Contraseña sea correcta.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del Administrador</param>
        /// <param name="contraseña">Contraseña del administrador</param>
        /// <returns>True si la combinacion es correcta, False en caso contrario</returns>
        public bool ValidarContraseña(string pNombreUsuario, string contraseña)
        {
            UsuarioAdministrador administrador = new UsuarioAdministrador();//Instanciamos un administrador para que luego sea devuelto como resultado
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    administrador = unitOfWork.RepositorioAdministradores.Get(pNombreUsuario);//Asignamos a la variable administrado instanciada el valor que nos devuelve el get.
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener el administrador (" + pNombreUsuario + " ) " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);

            }

            return encriptador.Validar(contraseña, administrador.Pass);
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener la lista total de usuarios simples.
        /// </summary>
        /// <returns>Lista total de usuarios simples</returns>
        public IEnumerable<UsuarioSimpleDTO> ObtenerUsuarios()
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<UsuarioSimpleDTO> lista = new List<UsuarioSimpleDTO>();
            try
            {
                foreach (var item in GetUnitOfWork().RepositorioUsuarios.GetAll())
                {
                    lista.Add(mapeador.Mapear(item));
                }

            }//Obtiene todos los usuarios simples con el metodo getall del repositorio
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de usuarios." + ex.Message + ex.StackTrace; ;
                lista = null;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }

            return lista;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener la lista total de usuarios adminitradores.
        /// </summary>
        /// <returns>Lista total de usuarios adminitradores</returns>
        public IEnumerable<UsuarioAdministradorDTO> ObtenerAdministradores()
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<UsuarioAdministradorDTO> lista = new List<UsuarioAdministradorDTO>();
            try
            {
                foreach (var item in GetUnitOfWork().RepositorioAdministradores.GetAll())
                {
                    lista.Add(mapeador.Mapear(item));
                }

            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de administradores." + ex.Message + ex.StackTrace; ;
                lista = null;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
            return lista;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener la lista total de libros.
        /// </summary>
        /// <returns>Lista total de libros</returns>
        public IEnumerable<LibroDTO> ObtenerLibros()
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<LibroDTO> lista = new List<LibroDTO>();
            try
            {
                foreach (var item in GetUnitOfWork().RepositorioLibros.GetAll())
                {
                    lista.Add(mapeador.Mapear(item));
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de libros." + ex.Message + ex.StackTrace; ;
                lista = null;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
            return lista;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener la lista total de prestamos.
        /// </summary>
        /// <returns>Lista total de prestamos</returns>
        public IEnumerable<PrestamoDTO> ObtenerPrestamos()
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<PrestamoDTO> lista = new List<PrestamoDTO>();
            try
            {
                foreach (var item in GetUnitOfWork().RepositorioPrestamos.GetAll())
                {
                    lista.Add(mapeador.Mapear(item));
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de prestamos." + ex.Message + ex.StackTrace; ;
                lista = null;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
            return lista;
        }



        /// <summary>
        /// Resumen: Este metodo nos permite obtener la lista de prestamos proximos a vencer.
        /// </summary>
        /// <returns>Lista de prestamos proximos a vencer</returns>
        public List<PrestamoDTO> ObtenerListadePrestamosProximosAVencerse()
        {
            string msg;
            List<PrestamoDTO> lista = new List<PrestamoDTO>();//Instancia de una lista de prestamos que sera devuelta por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())
                {
                    foreach (var item in unitOfWork.RepositorioPrestamos.GetAllProximosAVencerse())
                    {
                        lista.Add(mapeador.Mapear(item));
                    }
                }
                msg = "La lista de prestamos proximos a vencerse ha sido obtenida correctamente.";
            }
            catch (Exception ex)
            {
                msg = "Error, la lista de prestamos proximos a vencerse no pudo obtenerse." + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
            return lista;//Devuelve la lista            
        }

        /// <summary>
        /// Resumen: Este metodo nos permite obtener la lista de prestamos retrasados.
        /// </summary>
        /// <returns>Lista de prestamos retrasados</returns>
        public List<PrestamoDTO> ObtenerListadePrestamosRetrasados()
        {

            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<PrestamoDTO> lista = new List<PrestamoDTO>();//Instancia de una lista de prestamos que sera devuelta por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())
                {
                    foreach (var item in unitOfWork.RepositorioPrestamos.GetAllRetrasados())
                    {
                        lista.Add(mapeador.Mapear(item));
                    }
                }
                msg = "La lista de prestamos retrasados ha sido obtenida correctamente.";
            }
            catch (Exception ex)
            {
                msg = "Error, la lista de prestamos retrasados no pudo obtenerse. " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log

                throw new Exception(msg);
            }
            return lista;//Devuelve la lista 
        }

        /// <summary>
        /// Resumen: Este metodo nos permite realizar un busqueda en la api de libros.
        /// </summary>
        /// <param name="unaCadena">Libro buscado</param>
        /// <returns>devuelve una lista de libros que coinciden con la cadena buscada</returns>
        public List<LibroDTO> ListarLibrosDeAPIPorCoincidencia(string unaCadena)
        {
            try
            {
                List<LibroDTO> lista = new List<LibroDTO>();
                foreach (var item in ServicioAPILibros.ListarPorCoincidencia(unaCadena))
                {
                    lista.Add(mapeador.Mapear(item));
                }
                return lista;
            }
            catch (Exception ex)
            {
                bitacora.RegistrarLog("Error al listar libros de la API por coincidencia. " + ex.Message + ex.StackTrace);
                throw new Exception("Error al listar libros de la API por coincidencia. " + ex.Message + ex.StackTrace);
            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite notificar a los usuarios con prestamos proximos a vencer.
        /// </summary>
        public void NotificarPrestamosProximosAVencer()
        {
            try
            {
                foreach (var item in ObtenerListadePrestamosProximosAVencerse())
                {
                    string nombreUsuario = item.nombreUsuario;
                    EjemplarDTO ejemplar = ObtenerEjemplar(item.idEjemplar);
                    UsuarioSimpleDTO usuario = ObtenerUsuario(item.nombreUsuario);
                    string titulo = ObtenerLibro(ejemplar.idLibro).Titulo;
                    NotificadorUsuarios.NotificarProximoAVencer(usuario.nombreUsuario, usuario.Nombre, usuario.Apellido, usuario.Mail, titulo, item.FechaLimite);
                }
            }
            catch (Exception ex)
            {
                bitacora.RegistrarLog("Error al notificar prestamos proximos a vencer. " + ex.Message + ex.StackTrace);
                throw new Exception("Error al notificar prestamos proximos a vencer. " + ex.Message + ex.StackTrace);
            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite notificar a los usuarios con prestamos retrasados.
        /// </summary>
        public void NotificarPrestamosRetrasados()
        {
            try
            {
                foreach (var item in ObtenerListadePrestamosRetrasados())
                {
                    string nombreUsuario = item.nombreUsuario;
                    EjemplarDTO ejemplar = ObtenerEjemplar(item.idEjemplar);
                    UsuarioSimpleDTO usuario = ObtenerUsuario(item.nombreUsuario);
                    string titulo = ObtenerLibro(ejemplar.idLibro).Titulo;
                    NotificadorUsuarios.NotificarRetraso(usuario.nombreUsuario, usuario.Nombre, usuario.Apellido, usuario.Mail, titulo, item.FechaLimite);
                }
            }
            catch (Exception ex)
            {
                bitacora.RegistrarLog("Error al notificar prestamos retrasados. " + ex.Message + ex.StackTrace);
                throw new Exception("Error al notificar prestamos retrasados. " + ex.Message + ex.StackTrace);
            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite notificar a los usuarios con prestamos retrasados o proximos a vencer.Siempre que la hora sea entre las 9 y 10 am
        /// </summary>
        public void NotificarUsuarios()
        {
            try
            {
                if (DateTime.Now.Hour == 9)
                {
                    NotificarPrestamosRetrasados();
                    NotificarPrestamosProximosAVencer();
                }
            }
            catch (Exception ex)
            {
                bitacora.RegistrarLog("Error al notificar usuarios. " + ex.Message + ex.StackTrace);
                throw new Exception("Error al notificar usuarios. " + ex.Message + ex.StackTrace);

            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite dar de baja un usuario.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del usuario a dar de baja</param>
        /// <returns>True si la operacion fue exitosa, False en caso contrario</returns>
        public void DarDeBajaUsuario(string pNombreUsuario)
        //pemite dar de baja un usuario simple
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            bool resultado;//Booleano que se devolvera como resultado
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    resultado = unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).ValidarBaja();//Obtiene el usuario y llama a su metodo ValidarBaja. El valor que devuelve este metodo se guarda en la variable anterior nombrada.
                    if (resultado == true)//Si el resultado devuelto anterior mente es true
                    {
                        unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Baja = true;//Da de baja al usuario
                    }
                    else//Si el resultado devuelto anterior mente es false
                    {
                        msg = "El usuario " + pNombreUsuario + " no puede darse de baja porque tiene prestamos activos.";
                        throw new Exception(msg);
                    }
                    unitOfWork.Complete();
                }
            }
            catch (Exception ex)
            {
                msg = "Error, el usuario " + pNombreUsuario + " no ha podido darse de baja. " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite dar de baja un administrador.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del administrador a dar de baja</param>
        /// <returns>True si la operacion fue exitosa, False en caso contrario</returns>
        public void DarDeBajaAdministrador(string pNombreUsuario)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Baja = true;//Obtiene el administrador y coloca en su atributo baja el valor true
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error, el administrador " + pNombreUsuario + " no ha podido darse de baja. " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);

            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite dar de baja un administrador.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del administrador a dar de baja</param>
        /// <returns>True si la operacion fue exitosa, False en caso contrario</returns>
        public void DarDeBajaEjemplar(int idEjemplar)
        {

            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioEjemplares.Get(idEjemplar).Baja = true;//Obtiene el administrador y coloca en su atributo baja el valor true
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error, el ejemplar " + idEjemplar + " no ha podido darse de baja. " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
        }


        /// <summary>
        /// Resumen: Este metodo nos permite dar de alta un usuario simple previamente dado de baja.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del UsuarioSimple a dar de alta</param>
        public void DarDeAltaUsuario(string pNombreUsuario)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Baja = false;//Obtiene el usuario y coloca en su atributo baja el valor false
                    unitOfWork.Complete();//Guardamos los cambios
                }

            }
            catch (Exception ex)
            {
                msg = "Error, el usuario " + pNombreUsuario + " no ha podido darse de alta. " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
        }

        /// <summary>
        /// Resumen: Este metodo nos permite dar de alta un administrador previamente dado de baja.
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario del Administrador a dar de alta</param>
        public void DarDeAltaAdministrador(string pNombreUsuario)
        {
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Baja = false;//Obtiene el administrador y coloca en su atributo baja el valor false
                    unitOfWork.Complete();//Guardamos los cambios
                }

            }
            catch (Exception ex)
            {
                msg = "Error, el administrador" + pNombreUsuario + " no ha podido darse de alta. " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);//Añadimos el mensaje al log
                throw new Exception(msg);
            }
        }
    }
}