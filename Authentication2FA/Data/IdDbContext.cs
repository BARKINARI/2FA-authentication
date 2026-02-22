using Authentication2FA.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication2FA.Data;

public class IdDbContext : IdentityDbContext<IdUser>
{
    public IdDbContext(DbContextOptions<IdDbContext> options)
        : base(options) { }
}
