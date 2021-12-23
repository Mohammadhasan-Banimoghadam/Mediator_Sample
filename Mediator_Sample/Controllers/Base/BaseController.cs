using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mediator_Sample.Controllers.Base
{
    public class BaseController : ControllerBase
    {
        protected IMediator _mediator { get; }
        public BaseController(IMediator mediator) : base()
        {
            _mediator = mediator;
        }
    }
}
