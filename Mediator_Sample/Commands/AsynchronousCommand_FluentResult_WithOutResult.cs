using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentResults;
using Mediator_Sample.CommandHandlers;
using MediatR;

namespace Mediator_Sample.Commands
{
    /// <summary>
    /// Command----FluentResult-----WithResult-----Async
    /// </summary>
    public class AsynchronousCommand_FluentResult_WithOutResult : IRequest<Result>
    {
        public AsynchronousCommand_FluentResult_WithOutResult() : base()
        {
        }
        public string Message { get; set; }
    }
}
