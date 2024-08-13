﻿namespace Swipe4Work.DataTransferObject
{
    public class UpdateEducationDTO
    {
        public int EducationId { get; set; }
        public string? SchoolName { get; set; }
        public string? Degree { get; set; }
        public string? FieldOfStudy { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string? Grade { get; set; }
        public string? ActivitiesAndSocieties { get; set; }
        public string? Description { get; set; }
    }
}
