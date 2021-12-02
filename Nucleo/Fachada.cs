﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.EntityFramework;
using Dominio;
namespace Nucleo
{
    public class Fachada
    {
       
        private IUnitOfWork unitOfWork = new UnitOfWork(new AdministradorDePrestamosDbContext());//abstraemos del tipo de base de datos
        public Fachada()
        {

        }
        public void AñadirUsuario(string nombre,string apellido,DateTime fechaNacimiento,string mail)
        {
            UsuarioSimple usuario = new UsuarioSimple(nombre,apellido, fechaNacimiento,mail);
            using (new UnitOfWork(new AdministradorDePrestamosDbContext()))
            {
                unitOfWork.RepositorioUsuarios.Add(usuario);
                unitOfWork.Complete();
            }
        }
        public UsuarioSimple ObtenerUsuario(int id)
        {
            using (new UnitOfWork(new AdministradorDePrestamosDbContext()))
            {
                return unitOfWork.RepositorioUsuarios.Get(id);
            }
        }
        public void AñadirAdministrador(string nombre, string apellido, DateTime fechaNacimiento, string mail,string contraseña)
        {
            UsuarioAdministrador usuario = new UsuarioAdministrador(nombre, apellido, fechaNacimiento, mail,contraseña);
            using (new UnitOfWork(new AdministradorDePrestamosDbContext()))
            {
                unitOfWork.RepositorioAdministradores.Add(usuario);
                unitOfWork.Complete();
            }
        }
        public UsuarioAdministrador ObtenerAdministrador(int id)
        {
            using (new UnitOfWork(new AdministradorDePrestamosDbContext()))
            {
                return unitOfWork.RepositorioAdministradores.Get(id);
            }
        }
        public bool VerficarContraseña(int id, string contraseña)
        {
            return ObtenerAdministrador(id).VerificarContraseña(contraseña);
        }
        public IEnumerable<UsuarioSimple> ObtenerUsuarios()
        { return unitOfWork.RepositorioUsuarios.GetAll(); }
        public IEnumerable<UsuarioAdministrador> ObtenerAdministradores()
        { return unitOfWork.RepositorioAdministradores.GetAll(); }
        public IEnumerable<Libro> ObtenerLibros()
        { return unitOfWork.RepositorioLibros.GetAll(); }
        public IEnumerable<Ejemplar> ObtenerEjemplares()
        { return unitOfWork.RepositorioEjemplares.GetAll(); }
        public IEnumerable<Prestamo> ObtenerPrestamos()
        { return unitOfWork.RepositorioPrestamos.GetAll(); }
        public int ObtenerUltimoIdUsuario()

        {return ObtenerUsuarios().Last().Id; }
        public int ObtenerUltimoIdAdministrador()

        { return ObtenerAdministradores().Last().Id; }
        public int ObtenerUltimoIdLibro()

        { return ObtenerLibros().Last().Id; }
        public int ObtenerUltimoIdEjemplar()

        { return ObtenerEjemplares().Last().Id; }
        public int ObtenerUltimoIdPrestamo()

        { return ObtenerPrestamos().Last().Id; }

    }
}
