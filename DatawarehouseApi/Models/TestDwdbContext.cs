using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataWarehouseApi.Models;

public partial class TestDwdbContext : DbContext
{
    public TestDwdbContext()
    {
    }

    public TestDwdbContext(DbContextOptions<TestDwdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<InvoiceExtractionLog> InvoiceExtractionLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=eudwsqlserver.database.windows.net;Database=testDWDB;User Id=Fxdatafactory;password=AE9oKdiY&!#6k@;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InvoiceExtractionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceE__3213E83FF5A67856");

            entity.ToTable("InvoiceExtractionLog", "log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CorrelationId).HasColumnName("correlationId");
            entity.Property(e => e.DateSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("dateSubmitted");
            entity.Property(e => e.EmailFrom)
                .HasMaxLength(255)
                .HasColumnName("emailFrom");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(255)
                .HasColumnName("errorMessage");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(255)
                .HasColumnName("invoiceNumber");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
