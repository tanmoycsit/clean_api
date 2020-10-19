using CleanArchitecture.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class UserHistory : BaseEntity
    {
        public int UserId { get; set; }
        public DateTime LoginTime { get; set; }
        public string AccessToken { get; set; }
        public DateTime? TokenExpirationTime { get; set; }
    }
}
