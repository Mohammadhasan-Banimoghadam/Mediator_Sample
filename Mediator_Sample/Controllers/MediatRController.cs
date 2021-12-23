using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentResults;
using Mediator_Sample.Commands;
using Mediator_Sample.Controllers.Base;
using Mediator_Sample.Notifications;
using MediatR;

namespace Mediator_Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MediatRController : BaseController
    {
        public MediatRController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("SynchronousCommand_WithOutResult")]
        public IActionResult GetSynchronousCommand_WithOutResult()
        {
            var command = new SynchronousCommand_WithOutResult()
            {
                Message = "SynchronousCommand_WithOutResult"
            };
            _mediator.Send(command);

            return Ok("Succeed");
        }

        [HttpGet("AsynchronousCommand_WithOutResult")]
        public IActionResult GetAsynchronousCommand_WithOutResult()
        {
            var command = new SynchronousCommand_WithOutResult()
            {
                Message = "AsynchronousCommand_WithOutResult"
            };
            _mediator.Send(command);

            return Ok("Succeed");
        }

        [HttpGet("SynchronousCommand_WithResult")]
        public IActionResult GetSynchronousCommand_WithResult()
        {
            var command = new SynchronousCommand_WithResult()
            {
                Message = "SynchronousCommand_WithResult"
            };
            var result = _mediator.Send(command).Result;
            return Ok(result);
        }

        [HttpGet("AsynchronousCommand_WithResult")]
        public IActionResult GetAsynchronousCommand_WithResult()
        {
            var command = new AsynchronousCommand_WithResult()
            {
                Message = "AsynchronousCommand_WithResult"
            };
            var result = _mediator.Send(command).Result;
            return Ok(result);
        }

        [HttpGet("AsynchronousCommand_FluentResult_WithOutResult")]
        public IActionResult GetAsynchronousCommand_FluentResult_WithOutResult()
        {
            var command = new AsynchronousCommand_FluentResult_WithOutResult()
            {
                Message = "AsynchronousCommand_FluentResult_WithOutResult"
            };
            var result = _mediator.Send(command).Result;

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("AsynchronousCommand_FluentResult_WithResult")]
        public IActionResult GetAsynchronousCommand_FluentResult_WithResult()
        {
            var command = new AsynchronousCommand_FluentResult_WithResult()
            {
                Message = "AsynchronousCommand_FluentResult_WithResult"
            };
            var result = _mediator.Send(command).Result;

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.ToResult());
            }
        }



        [HttpGet("NotificationHandler")]
        public IActionResult GetNotificationHandler()
        {
            try
            {
                var notification = new Notification()
                {
                    Message = "Notification Message"
                };

                _mediator.Publish(notification);

                return Ok("Succeeded");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
