
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace LocalBussinessTestWebAPI.Models
{
    public class Users
    {
        public int Id { get; set; }

       
        public string UserName { get; set; } = string.Empty;

        public string email { get; set; } =string.Empty;

      
        public int mobile { get; set; }

       
        public string password { get; set; } = string.Empty;

      
    }
}
