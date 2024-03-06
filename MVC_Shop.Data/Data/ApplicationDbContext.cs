using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MVC_Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Shop.Data.Data
{
    internal class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
    }
}
