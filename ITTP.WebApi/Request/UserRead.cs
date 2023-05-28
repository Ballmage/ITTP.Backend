using System;

namespace ITTP.WebApi.Request
{
    public class UserRead
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string? IsActive { get; set; }
    }
}
