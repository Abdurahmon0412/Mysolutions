using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Model
{
    public enum UserRole
    {
        ProjectManager,
        Developer
    }

    public class User
    {
        private static User _defoultAddmin;
        private static User GetDefoult()
        {
            if (_defoultAddmin == null)
                _defoultAddmin = new User(1, "", "", "");

            return _defoultAddmin;

        }

        public User(byte rolid, string username, string password, string emailaddress)
        {

        }

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string UsernName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }

        public List<Task> AssignedProjects;

        public List<string> Comments;

        public Project Project { get; set; }

        public User(string username, string password, int roleid)
        {
            Id = Guid.NewGuid();
            UsernName = username;
            Password = password;
            RoleId = roleid;
            AssignedProjects = new List<Task>();
            Comments = new List<string>();
        }
    }
}
