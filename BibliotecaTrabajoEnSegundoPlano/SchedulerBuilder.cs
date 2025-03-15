
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace BibliotecaTrabajoEnSegundoPlano
{   /// <summary>
    /// Resumen: Esta clase construye un planificador
    public static class SchedulerBuilder
    {
        /// <summary>
        /// Resumen: Fabrica de planificadores
        /// </summary>
        public static StdSchedulerFactory factory = new StdSchedulerFactory();

        /// <summary>
        /// Resumen: Este metodo construye un planificador
        /// </summary>
        /// <param name="scheduler"></param>
    
        public static Task build(IScheduler scheduler)
        {

            IJobDetail job = BibliotecaTrabajoEnSegundoPlano.JobBuilder.build();
            ITrigger trigger = BibliotecaTrabajoEnSegundoPlano.TriggerBuilder.build();
            return scheduler.ScheduleJob(job, trigger);
        }
    }
}
