using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
    }
}
