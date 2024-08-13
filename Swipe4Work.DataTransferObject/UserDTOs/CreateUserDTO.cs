﻿
namespace Swipe4Work.DataTransferObject { 

    public class CreateUserDTO
    {
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? PasswordHash { get; set; }
        public string? UserType { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Headline { get; set; }
        public string? Summary { get; set; }
        public string? Location { get; set; }
        public DateTimeOffset DateJoined { get; set; } = DateTimeOffset.Now;
        public string? LinkedInUrl { get; set; }
        public string? GenderIdentity { get; set; }
        public string? Pronoun { get; set; }
        public string? Ethnicity { get; set; }
        public string? MobileNumber { get; set; }
        public bool RequireVisa { get; set; }
        public string? SearchStage { get; set; }
        public string? ProfilePicture { get; set; }
        public string? ProfileUrl { get; set; }
        public string? PortfolioUrl { get; set; }
        public int RoleId { get; set; }
        public int CompanyId { get; set; }
        public bool IsWorking { get; set; }
    }
}
