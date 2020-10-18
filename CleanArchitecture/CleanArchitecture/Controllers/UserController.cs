using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Commands.UserCommands;
using CleanArchitecture.Application.Handlers.UserHandlers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        [Route("GetUserById")]
        public async Task<IActionResult> GetUser(int UserId)
        {
            GetUserCommand getUserCommand = new GetUserCommand() { Id = UserId };

            var result = await _mediator.Send(getUserCommand);
            return Ok(result);
        }

        [HttpGet]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateUser(string userName, string nickName)
        {
            InsertUserCommand cmd = new InsertUserCommand() { UserName = userName, NickName = nickName };

            var result = await _mediator.Send(cmd);
            return Ok(result);
        }
    }
}
