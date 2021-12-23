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
    public class AsynchronousCommandHandler_FluentResult_WithOutResult : IRequestHandler<AsynchronousCommand_FluentResult_WithOutResult, Result>
    {
        public AsynchronousCommandHandler_FluentResult_WithOutResult() : base()
        {
        }

        public async Task<Result> Handle(AsynchronousCommand_FluentResult_WithOutResult request, CancellationToken cancellationToken)
        {
            var result = new Result();
            try
            {
                // Is Faild
                //await Task.Run(() =>
                //{
                //    result.WithError("error message (1)");
                //    result.WithError("error message (2)");
                //});


                // Is Success
                var value = request.Message.ToUpper();

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
