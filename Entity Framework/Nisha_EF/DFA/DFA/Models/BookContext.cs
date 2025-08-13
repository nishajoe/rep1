using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DFA.Models;

public partial class BookContext : DbContext
{
    public BookContext()
    {
    }

    public BookContext(DbContextOptions<BookContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-H9IDN1A;Initial Catalog=book;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Books__C223F3B47C0FD5A2");

            entity.Property(e => e.BookId)
                .ValueGeneratedNever()
                .HasColumnName("Book_Id");
            entity.Property(e => e.BookAuthor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Book_Author");
            entity.Property(e => e.BookPrice).HasColumnName("Book_Price");
            entity.Property(e => e.BookTitle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Book_Title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
