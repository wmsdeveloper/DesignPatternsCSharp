﻿namespace Domain.Entities {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public double Salary { get; set; } = 0;
    }
}