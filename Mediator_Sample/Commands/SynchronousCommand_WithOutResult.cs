using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Mediator_Sample.Commands
{
    /// <summary>
    /// Command-----WithOutResult-----Sync
    /// </summary>
    public class SynchronousCommand_WithOutResult : IRequest
    {
        public SynchronousCommand_WithOutResult() : base()
        {
        }
        public string Message { get; set; }
    }
}
