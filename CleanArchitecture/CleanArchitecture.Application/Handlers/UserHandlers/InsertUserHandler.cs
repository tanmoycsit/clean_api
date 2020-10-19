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
        IUserHistoryRepository _userHistoryRepository;
        IUnitOfWork _unitOfWork;
        public InsertUserHandler(IUserRepository userRepository, IUserHistoryRepository userHistoryRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _userHistoryRepository = userHistoryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(InsertUserCommand request, CancellationToken cancellationToken)
        {
            var data = new User() { DisplayName = request.UserName, NickName = request.NickName, Password = "1234" };
            _userRepository.Add(data);
            var history = new UserHistory { UserId = 3, AccessToken = "", LoginTime = DateTime.Now, TokenExpirationTime = DateTime.Now.AddHours(1) };
            _userHistoryRepository.Add(history);

            var result = await _unitOfWork.SaveChangesAsync();
            return result;
        }
    }
}
