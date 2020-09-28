using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.BusRabbit
{
    public interface IRabbitEventBust
    {
        Task EnviarComando<T>(T commando) where T : Comando;
    }
}
