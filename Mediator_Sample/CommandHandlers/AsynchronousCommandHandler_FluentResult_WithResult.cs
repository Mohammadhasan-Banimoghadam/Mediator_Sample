using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentResults;
using Mediator_Sample.Commands;
using MediatR;

namespace Mediator_Sample.CommandHandlers
{
    public class AsynchronousCommandHandler_FluentResult_WithResult : IRequestHandler<AsynchronousCommand_FluentResult_WithResult, Result<string>>
    {
        public AsynchronousCommandHandler_FluentResult_WithResult() : base()
        {
        }

        public async Task<Result<string>> Handle(AsynchronousCommand_FluentResult_WithResult request, CancellationToken cancellationToken)
        {
            var result = new Result<string>();

            try
            {
                //IsFail
                //await Task.Run(() =>
                //{
                //    result.WithError("error message (1)");
                //    result.WithError("error message (2)");
                //});

                //IsSuccess
                var value = request.Message.ToUpper();

                result.WithValue(value);
                result.WithSuccess("Success message (1)");
                result.WithSuccess("Success message (2)");

                Console.WriteLine(value);

            }
            catch (Exception ex)
            {
                result.WithError(ex.Message);
            }

            return result;
        }
        
    }
}

