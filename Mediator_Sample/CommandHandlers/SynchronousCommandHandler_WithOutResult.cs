using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediator_Sample.Commands;
using MediatR;

namespace Mediator_Sample.CommandHandlers
{
    public class SynchronousCommandHandler_WithOutResult : RequestHandler<SynchronousCommand_WithOutResult>
    {
        public SynchronousCommandHandler_WithOutResult() : base()
        {
        }

        protected override void Handle(SynchronousCommand_WithOutResult request)
        {
            var message = request.Message.ToUpper();
            Console.WriteLine(message);
        }
    }
}
