using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Mediator_Sample.Commands
{
    /// <summary>
    /// Command-----WithOutResult----Async
    /// </summary>
    public class AsynchronousCommand_WithOutResult : IRequest
    {
        public AsynchronousCommand_WithOutResult()
        {
        }
        public string Message { get; set; }
    }
}
