![images](https://github.com/user-attachments/assets/7823e8f6-52b1-4650-8759-976bb9dfb61c)
# Ingenieria en Sistemas de Informacion
# Proyecto Final de Taller de Programación
# 📚 E-Library | UTN - FRCU
# Sistema de Gestión de Préstamos de Biblioteca | UTN - FRCU

Este proyecto fue realizado con el objetivo de solucionar la problematica inicial planteada en el proyecto final de la cátedra de tercer año *Taller de Programación* dictada por el Ing. Enzo Tanga. 
# Funcionalidades principales:
- ✅ Gestión de libros: Alta y actualización de libros desde Open Library API 📖
- ✅ Administración de usuarios: Usuarios administradores y estándar 👥
- ✅ Registro de préstamos y devoluciones 📅
- ✅ Reportes de préstamos próximos a vencer 📊
- ✅ Sistema de puntuación (Scoring): Beneficios o penalizaciones según la devolución del libro 🏆
- ✅ Notificaciones por correo antes del vencimiento del préstamo 📩
- ✅ Base de datos relacional para persistencia de datos 🗄️
- ✅ Registro de actividad y logs para diagnóstico 🔍


## Como configurar este proyecto en local:
- Clonar este repositorio con Visual Studio
- Para correrlo debe estar configurado como proyecto de inicio el llamado Presentacion.
- Se debe tener SQL Server localmente instalado, el proyecto se encargará de crear automáticamente la base de datos necesaria para que este funcione.
- Compilar el proyecto.
- Iniciar sesion. El administrador principal tiene como credenciales por defecto,
  - ***NombreUsuario***: "admin"
  - ***Contraseña***: "admin"
  - Se recomienda modificar las credeciales una vez iniciada sesión por primera vez para mayor seguridad.
-Luego de compilado el proyecto el ejecutable del programa junto a los demas archivos necesarios para la ejecución estaran en la carpeta donde se clono el repositorio dentro de Programa/bin/debug, el ejecutable principal se llama "Programa.exe".

## Tecnologías utilizadas
- **Lenguaje**:  C#.
- **Base de datos**:  MSSQL server.
- **ORM**:  Entity Framework code first.
- **GUI**:  WinForms.
- **Librerias utilizadas**:
  - ***Quartz*** :Libreria de trabajo asincrono.
  - ***Log4Net** :Libreria de logs.
- **APIs utilizadas**:
  - ***OpenLibrary***: Libreria de informacion de libros. 
  

## Grupo de trabajo
El grupo de trabajo se compone de los siguientes integrantes: 
- **Emmanuel Davezac**
- **Facundo Acevedo** 
- **Franco Rodriguez**  
- **Nicolas Villanueva**

## Requerimientos no funcionales
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
