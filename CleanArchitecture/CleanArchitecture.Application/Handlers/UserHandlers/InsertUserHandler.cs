using CleanArchitecture.Application.Commands.UserCommands;
using CleanArchitecture.Domain.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Handlers.UserHandlers
{
    public class InsertUserHandler : IRequestHandler<InsertUserCommand, int>
    {
        IUserRepository _userRepository;
        IUnitOfWork _unitOfWork;
        public InsertUserHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(InsertUserCommand request, CancellationToken cancellationToken)
        {
            var data = new User() { Id = 2, DisplayName = request.UserName, NickName = request.NickName, Password = "1234" };
            _userRepository.Add(data);
            var result = await _unitOfWork.SaveChangesAsync();
            return result;
        }
    }
}
