using CleanArchitecture.Application.Commands.UserCommands;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Handlers.UserHandlers
{
    public class GetUserHandler : IRequestHandler<GetUserCommand, GetUserDto>
    {
        private IUserRepository _userRepository;

        public GetUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<GetUserDto> Handle(GetUserCommand request, CancellationToken cancellationToken)
        {
            var data =  await _userRepository.GetById(request.Id);
            GetUserDto result = new GetUserDto()
            {
                Id = data.Id,
                DisplayName = data.DisplayName, 
                UserName = data.NickName
            };
            return result;
        }
    }
}
