using System;
using System.Collections.Generic;
using System.Text;

namespace cmts
{
    public class Dbcontext;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Unique Email
        modelBuilder.Entity<Employee>()
            .HasIndex(e => e.Email)
            .IsUnique();

        // Unique Trainig Title 
        modelBuilder.Entiy<TrainingProgram>()
            .HasIndex(t => t.Title)
            .IsUnique();

        // Composite Key 
        modelBuilder.Entity<Enrollment>()
            .HasKey(e => new { e.EmployeeId, e.TrainingProgramId });

        // Relationships
        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Employee)
            .WithMany(e => e.Enrollments)
            .HasForeignKey(e => e.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.TrainingProgram)
            .WithMany(t => t.Enrollments)
            .HasForeignKey(e => e.TrainingProgramId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
