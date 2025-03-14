﻿using dotnetbackend.Domain.Common;
using dotnetbackend.Domain.Enums;

namespace dotnetbackend.Domain.Entities
{
    public sealed class CourseLecture : EntityBase
    {
        public Guid SectionId { get; set; }
        public CourseSection Section { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? VideoUrl { get; set; }
        public string? ArticleContent { get; set; }
        public LectureType Type { get; set; }
        public TimeSpan Length { get; set; }
        public int Order { get; set; }
        public bool IsFreePreview { get; set; }
        public ICollection<CourseLectureResource> Resources { get; set; } = [];
    }
}
