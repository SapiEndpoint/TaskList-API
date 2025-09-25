using Microsoft.EntityFrameworkCore; 
using TaskList.Models;

namespace TaskList.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<Users> User { get; set; }                             
        public DbSet<TaskManagement> TaskManagements { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)      
        {
            modelBuilder.Entity<Users>().
                HasKey(u => u.IdUser);      

            modelBuilder.Entity<TaskManagement>().
                HasKey(t => t.IdTask);      

            modelBuilder.Entity<TaskManagement>((entity =>
            {
                entity.ToTable("task_management");      
                entity.Property(e => e.IdTask).HasColumnName("id_task");
                entity.Property(e => e.IdUser).HasColumnName("id_user");
                entity.Property(e => e.Task).HasColumnName("task");
                entity.Property(e => e.TaskStatus).HasColumnName("task_status");
            }));         

            modelBuilder.Entity<Users>((entity =>
            {
                entity.ToTable("users");                
                entity.Property(e => e.FirstName).HasColumnName("first_name");    
                entity.Property(e => e.IdUser).HasColumnName("id_user");
                entity.Property(e => e.LastName).HasColumnName("last_name");
            }));

            modelBuilder.Entity<TaskManagement>().
                HasOne(u => u.User).        
                WithMany(t => t.Task).      
                HasForeignKey(f => f.IdUser);     
        }
    }
}
