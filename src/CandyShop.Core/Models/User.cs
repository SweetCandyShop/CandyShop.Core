using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop.Core.Models
{
    public sealed class User : DataBaseUnit, IEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
