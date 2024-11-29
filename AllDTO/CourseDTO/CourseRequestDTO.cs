﻿using MyEducatin.Models;

namespace MyEducatin.AllDTO.CourseDTO
{
    public class CourseRequestDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int DurationInWeeks { get; set; }
        public int CategoryId { get; set; }

        public HashSet<int> Subjects;
    }
}