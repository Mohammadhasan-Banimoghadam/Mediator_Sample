using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mediator_Sample.Commands;
using MediatR;

namespace Mediator_Sample.CommandHandlers
{
    public class AsynchronousCommandHandler_WithOutResult : IRequestHandler<AsynchronousCommand_WithOutResult>
    {
        public AsynchronousCommandHandler_WithOutResult() : base()
        {

        }
        public async Task<Unit> Handle(AsynchronousCommand_WithOutResult request, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                var message = request.Message.ToUpper();
                Console.WriteLine(message);
            });

            return new MediatR.Unit();
        }
    }
}
