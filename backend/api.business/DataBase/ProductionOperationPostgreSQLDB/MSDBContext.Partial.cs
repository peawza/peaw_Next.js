using Microsoft.EntityFrameworkCore;

namespace BusinessSQLDB;

public partial class MSDBContext : DbContext
{
    void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        // OnModelCreatingForAPI001(modelBuilder);

        OnModelCreatingForCommon(modelBuilder);
        OnModelCreatingForTMS030(modelBuilder);
        OnModelCreatingForTMS050(modelBuilder);
        OnModelCreatingForTMS040(modelBuilder);
        OnModelCreatingForTMS060(modelBuilder);
    }


}

