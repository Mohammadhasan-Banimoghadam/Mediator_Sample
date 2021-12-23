using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Mediator_Sample.Notifications
{
    public class Notification : INotification
    {
        public Notification():base()
        {
        }
        public string Message { get; set; }
    }
}
