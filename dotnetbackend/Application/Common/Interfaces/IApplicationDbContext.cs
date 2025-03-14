using dotnetbackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnetbackend.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Category> Categories { get; }
        DbSet<Course> Courses { get; }
        DbSet<CourseCategory> CourseCategories { get; }
        DbSet<CourseLecture> CourseLectures { get; }
        DbSet<CourseLectureResource> CourseLectureResources { get; }


    }
}
