using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp43.Model;

namespace WpfApp43.Model
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Role> Roles { get; private set; } = new ObservableCollection<Role>();
    }
}
