using CleanArchitecture.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Commands.UserCommands
{
    public class GetUserCommand : IRequest<GetUserDto>
    {
        public int Id { get; set; }
    }
}
