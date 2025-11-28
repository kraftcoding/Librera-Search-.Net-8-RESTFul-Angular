using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCore.ArticlesWebAPI.Models;

public partial class TutorialsManagementApiContext : DbContext
{
    public TutorialsManagementApiContext()
    {
    }

    public TutorialsManagementApiContext(DbContextOptions<TutorialsManagementApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tutorial> Tutorial { get; set; }
  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WIN-UGCST86JVC7;Database=TutorialsManagementAPI;Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tutorial>(entity =>
        {
            entity.HasIndex(e => e.id, "id");

            //entity.Property(e => e.title).HasColumnName("title");

            //entity.HasOne(d => d.User).WithMany(p => p.Books).HasForeignKey(d => d.UserId);

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
