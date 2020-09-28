using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.BusRabbit
{
    public interface IEventoManejador<in TEvent> : IEventoManejador where 
    {

    }
}
