using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharesBusiness
{
    public partial class Member
    {
        public int Id { get; set; }
        public MemberTitle Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MemberType Type { get; set; }
    }
}
