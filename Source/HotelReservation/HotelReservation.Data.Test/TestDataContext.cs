using HotelReservation.Data.Test;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data.Test
{
    public class Instructor
    {
        public Instructor()
        {
            Courses = new List<Course>();
        }
        public int InstructorId { get; set; }

        public virtual OfficeAssignment OfficeAssignment { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }

    public class Course
    {
        public Course()
        {
            Instructors = new List<Instructor>();
        }
        public int CourseId { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }

    public class InstructorCourse
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string LessonName { get; set; }

        public virtual Course Course { get; set; }
        public virtual Instructor Instructor { get; set; }
    }

    public class OfficeAssignment
    {
        public int OfficeAssignmentId { get; set; }
        public int InstructorId { get; set; }

        public virtual Instructor Instructor { get; set; }
    }

    public class TestDataContext : DbContext
    {
        public TestDataContext()
            : base("TestDataContext")
        {
            


        }

        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<InstructorCourse> InstructorCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OfficeAssignment>().HasKey(t => t.InstructorId);

            modelBuilder.Entity<InstructorCourse>().HasKey(t => new { t.InstructorId, t.CourseId });

            modelBuilder.Entity<OfficeAssignment>().HasRequired(t => t.Instructor).WithOptional(t => t.OfficeAssignment);

            modelBuilder.Entity<Course>().HasMany(t => t.Instructors).WithMany(t => t.Courses);
        }
    }

          
}
