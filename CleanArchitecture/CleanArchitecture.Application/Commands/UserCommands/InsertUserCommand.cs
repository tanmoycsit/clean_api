using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Commands.UserCommands
{
    public class InsertUserCommand : IRequest<int>
    {
        public string UserName { get; set; }
        public string NickName { get; set; }
    }
}
