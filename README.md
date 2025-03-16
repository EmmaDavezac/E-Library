![images](https://github.com/user-attachments/assets/7823e8f6-52b1-4650-8759-976bb9dfb61c)

# Proyecto Final de Taller de Programación
#Sistema de gestión y administración de biblioteca.

Este proyecto fue realizado con el objetivo de cumplir con el proyecto final de la cátedra Taller de Programación. Se trata de un sistema que permite al adminitrador de una biblioteca:

- ABM de clientes(usuario simple)
- ABM de libros.
- ABM de administradores
- ABM de préstamos.
- Control del estado de los préstamos.
- Sistema de puntos para los clientes.

## Como configurar este proyecto en local:

- Para correrlo debe estar configurado el inicio a traves de la carpeta llamada UtilidadesPresentacion. 
- También debe tener SQL Server instalado, el proyecto se encargará de crear automáticamente la base de datos necesaria para que este funcione.
- El administrador principal tiene como credenciales, nombre: admin, contraseña: admin, se recomienda modificarlo una ves iniciada sesion por primera ves.

## Tecnologías utilizadas
- **Lenguaje**:  C#.
- **Base de datos**:  MSSQL server.
- **ORM**:  Entity Framework code first.
- **Maquetado**:  WinForms.
- **Librerias utilizadas**:
  - ***Quartz*** :
  - ***Log4Net** :
- **APIs utilizadas**:
  - ***OpenLibrary***:  
  

## Grupo de trabajo
El grupo de trabajo se compone de los siguientes integrantes: 
- **Acevedo Facundo** 
- **Davezac Emmanuel** 
- **Rodriguez Franco**  
- **Nicolas Villanueva**

##Requerimientos no funcionales
- La aplicación deberá ser robusta ante cualquier tipo de errores.
- La aplicación deberá ser fácil de usar e intuitiva.
- La interfaz del usuario deberá ser consistente y no deberá tener errores de interacción ni de visualización de información.
- La aplicación deberá ser desarrollado sobre la plataforma .NET y en lenguaje C#.
- El programa deberá tener una interfaz gráfica, se sugiere el uso de WinForms, integrando los conocimientos y técnicas adquiridos durante la cátedra. La
incorporación de conocimientos no adquiridos durante la cátedra serán también bienvenidos.
- El programa deberá persistir las configuraciones y otros datos en una Base de Datos relacional, utilizando el gestor es a elección del alumno. Se espera que en un futuro puedan configurarse persistencia en distintos gestores de Bases de Datos u otras formas de persistencia (como por ejemplo archivos, Bases de Datos No-SQL, entre otras), por lo que el software debe estar preparado para ello.
- La aplicación deberá contener una bitácora de monitoreo (archivo de log), que permita hacer diagnósticos ante la ocurrencia de errores.
- Se espera que en un futuro la aplicación pueda acceder a diferentes catálogos online de libros. El sistema deberá estar diseñado para que los cambios a realizar para incorporar catálogos sea el menor posible.
- Se espera además incorporar en un futuro otros mecanismos de notificación de vencimiento de préstamos, por lo que se debe tener esto en cuenta en el desarrollo de la aplicación.
- El código fuente deberá estar correctamente comentado y documentado con los formatos correspondientes.
