using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediator_Sample.Commands;
using MediatR;

namespace Mediator_Sample.CommandHandlers
{
    public class SynchronousCommandHandler_WithResult : RequestHandler<SynchronousCommand_WithResult, string>
    {
        public SynchronousCommandHandler_WithResult() : base()
        {

        }

        protected override string Handle(SynchronousCommand_WithResult request)
        {
            var message = request.Message.ToUpper();
            Console.WriteLine(message);
            return message;
        }
    }
}
