using App.GlobantAssessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.GlobantAssessment.Controllers
{
    [ApiController]
    [Route("api")]
    public class DevopsController : ControllerBase
    {
        [HttpPost]
        [Route("devops")]
        public dynamic postDevops(Devops devops)
        {

            string metodo = Request.Method.ToString();
            string mensaje = devops.message;
            string receiver = devops.to;
            string sender = devops.from;
            int secs = devops.ToLifeSec;
            string ApiKey = Request.Headers.Where(x => x.Key == "x-api-key").FirstOrDefault().Value;

            if (metodo != "POST")
            {
                return new
                {
                    success = false,
                    message = "ERROR",

                };
            }
            if (ApiKey != "2f5ae96c-b558-4c7b-a590-a501ae1c3f6c")
            {
                return new
                {
                    success = false,
                    message = "ApiKey invalida",

                };
            }

            if (mensaje != "This is a test" || receiver != "Juan Perez" || sender != "Rita Asturia" || secs != 45)
            {
                return new
                {
                    success = false,
                    message = "Parámetros no validos - ERROR, elija el método POST ó coloque bien el body",

                };
            }

            return new
            {
                success = true,
                message = "Hello " + receiver + " your message will be send"

            };

        }
    }
}
