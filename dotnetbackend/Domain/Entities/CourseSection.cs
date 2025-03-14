using dotnetbackend.Domain.Common;

namespace dotnetbackend.Domain.Entities
{
    public class CourseSection : EntityBase
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public string Title { get; set; }
        public TimeSpan TotalLength { get; set; }
        public int LectureCount { get; set; }
        public int Order { get; set; }
    }
}
