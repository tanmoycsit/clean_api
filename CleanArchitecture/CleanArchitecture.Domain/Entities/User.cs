using CleanArchitecture.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string NickName { get; set; }
        public string  Password { get; set; }
    }
}
