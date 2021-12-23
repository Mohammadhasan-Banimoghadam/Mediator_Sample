using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mediator_Sample.Notifications;
using MediatR;

namespace Mediator_Sample.NotificationHandlers
{
    public class NotificationHandler2 : INotificationHandler<Notification>
    {
        public NotificationHandler2() : base()
        {
        }
        public async Task Handle(Notification notification, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                var message = $"{ToString()} _ {notification.Message.ToUpper()}";
                Console.WriteLine(message);
            });
        }
    }
}
