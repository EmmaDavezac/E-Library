﻿using Quartz;

namespace BibliotecaTrabajoEnSegundoPlano
{
    static class JobBuilder
    {    /// <summary>
         /// Resumen: Este metodo devuelve un constructor de trabajo (NotificacionTrabajo).
         /// </summary>
         /// <returns>Una instancia de trabajo asignada al grupo group1</returns>
        public static IJobDetail build()
        {
            return Quartz.JobBuilder.Create<NotificacionJob>()//creamos una instancia de trabajo y la asignamos al grupo group1
                .WithIdentity("job1", "group1")
                .Build();
        }
    }
}

