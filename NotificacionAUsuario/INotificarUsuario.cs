﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace NotificacionAUsuario
{
    public interface INotificarUsuario
    {
        void Notificar(UsuarioSimple usuario); 
    }
}
