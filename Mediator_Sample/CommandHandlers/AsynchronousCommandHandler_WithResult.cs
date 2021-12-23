using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mediator_Sample.Commands;
using MediatR;

namespace Mediator_Sample.CommandHandlers
{
    public class AsynchronousCommandHandler_WithResult : IRequestHandler<AsynchronousCommand_WithResult, string>
    {
        public AsynchronousCommandHandler_WithResult() : base()
        {
        }

        public async Task<string> Handle(AsynchronousCommand_WithResult request, CancellationToken cancellationToken)
        {
            var result = string.Empty;

            await Task.Run(() =>
            {
                result = request.Message.ToUpper();
                Console.WriteLine(result);
            });

            return result;
        }
    }
}
