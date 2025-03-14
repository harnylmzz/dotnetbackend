﻿using dotnetbackend.Domain.Common;

namespace dotnetbackend.Domain.Entities
{
    public sealed class CourseLectureResource : EntityBase
    {
        public Guid LectureId { get; set; }
        public CourseLecture Lecture { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
    }
}
