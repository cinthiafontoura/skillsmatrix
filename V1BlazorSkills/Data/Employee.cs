﻿namespace V1BlazorSkills.Data
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, int>? EmployeeSkills { get; set; }
    }
}
