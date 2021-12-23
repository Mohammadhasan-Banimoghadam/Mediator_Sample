using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentResults;
using MediatR;

namespace Mediator_Sample.Commands
{
    /// <summary>
    /// Command--------FluentResult-------WithResult-----Async
    /// </summary>
    public class AsynchronousCommand_FluentResult_WithResult : IRequest<Result<string>>
    {
        public AsynchronousCommand_FluentResult_WithResult() : base()
        {
        }
        public string Message { get; set; }
    }
}
