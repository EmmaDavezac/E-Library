using Nucleo;
using Quartz;
using System.Threading.Tasks;

namespace BibliotecaTrabajoEnSegundoPlano
{
    /// <summary>
    /// RESUMEN: Esta clase representa el trabajo que se va a realizar en segundo plano
    /// </summary>
    public class NotificacionJob : IJob
    {

        /// <summary>
        /// RESUMEN: Este metodo es la tarea asincronica a ejecutarse en segundo plano
        /// </summary>
        /// <param name="context"></param>

        public async Task Execute(IJobExecutionContext context)
        {
            FachadaNucleo fachada = new FachadaNucleo();
            fachada.NotificarUsuarios();//Notificamos a los usuarios con prestamos vencidos o proximos a vencer(en el caso de ser la hora correcta)
            await Task.CompletedTask;//Se espera que la tarea se complete para terminar el proceso
        }
    }
}
