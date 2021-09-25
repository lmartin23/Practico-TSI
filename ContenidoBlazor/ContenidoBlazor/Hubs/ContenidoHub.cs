using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContenidoBlazor.Hubs
{
    public class ContenidoHub : Hub
    {
        public async Task cantidadEntidades(int contador)
        {   //Una vez recibo el contador
            await Clients.All.SendAsync("CantEntidades", contador);
            //Desde aca estoy mandando la cantidad de entidades que obtengo de cantidadEntidades
            //a todos los conectados. "CantEntidades" metodo del lado del cli que reciben los datos 
        }
    }
}
