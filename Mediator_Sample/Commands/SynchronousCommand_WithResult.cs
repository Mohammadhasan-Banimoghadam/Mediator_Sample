using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Mediator_Sample.Commands
{
    /// <summary>
    /// Command-----WithResult-----Sync
    /// </summary>
    public class SynchronousCommand_WithResult : IRequest<string>
    {
        public SynchronousCommand_WithResult() : base()
        {

        }
        public string Message { get; set; }
    }
}
