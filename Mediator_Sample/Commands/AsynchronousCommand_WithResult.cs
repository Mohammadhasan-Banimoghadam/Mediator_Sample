using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Mediator_Sample.Commands
{
    /// <summary>
    /// Command-----WithResult-----Async
    /// </summary>
    public class AsynchronousCommand_WithResult : IRequest<string>
    {
        public AsynchronousCommand_WithResult() : base()
        {
        }
        public string Message { get; set; }
    }
}
