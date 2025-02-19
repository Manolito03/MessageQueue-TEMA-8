using MessageQueue.Domain.Common;
using MessageQueue.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageQueue.Domain.Entities
{
    /// <summary>
    /// Entidad que representa un consumidor de mensajes
    /// Relación: N Mensajes <-> N Consumidores (mediante Message.ReadBy)
    /// </summary>
    public class Consumer : Entity
    {
        /// <summary>
        /// Endpoint de red del consumidor
        /// </summary>
<<<<<<< HEAD
        public NetworkEndpoint Endpoint { get; set; }
=======
        public NetworkEndpoint Endpoint { get; private set; }
>>>>>>> e5542982c77b16914d02c9db4323c0190571acdf

        /// <summary>
        /// Constructor para crear un consumidor en la base de datos
        /// </summary>
        public Consumer() { }

        /// <summary>
        /// Constructor para crear un consumidor
        /// </summary>
        /// <param name="id">Identificador único</param>
        /// <param name="endpoint">Endpoint de red válido</param>
        public Consumer(Guid id, NetworkEndpoint endpoint) : base(id)
        {
            Endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
        }
    }
}

