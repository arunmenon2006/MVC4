using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Models
{
    public interface IAuth
    {
        bool DoLogin(string username, string password);
    }
}
