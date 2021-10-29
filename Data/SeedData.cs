using System.Collections.Generic;
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;

public static class SeedData {
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Student>().HasData(
            GetStudents()
        );
    }

    public static List<Student> GetStudents() {
        List<Student> students = new List<Student>() {
            new Student {
                StudentId = 1,
                FirstName = "Jim",
                LastName = "Potter",
                Mobile = "604-123-4567",
                Email = "jim@potter.com",
                City = "Chilliwack",
                Specialization = "Nursing"
            },
            new Student {
                StudentId = 2,
                FirstName = "Jane",
                LastName = "Douglas",
                Mobile = "222-222-2222",
                Email = "jane@douglas.com",
                City = "Vancouver",
                Specialization = "Nursing"
            },
            new Student {
                StudentId = 3,
                FirstName = "Tom",
                LastName = "Gardner",
                Mobile = "333-333-33333",
                Email = "tom@gardner.com",
                City = "Vancouver",
                Specialization = "Computer Programming"
            },
            new Student {
                StudentId = 4,
                FirstName = "Ann",
                LastName = "Lee",
                Mobile = "444-444-4444",
                Email = "ann@lee.com",
                City = "Vancouver",
                Specialization = "Computer Programming"
            },
            new Student {
                StudentId = 5,
                FirstName = "James",
                LastName = "Jones",
                Mobile = "555-555-5555",
                Email = "james@jones.com",
                City = "Victoria",
                Specialization = "Business"
            },
            new Student {
                StudentId = 6,
                FirstName = "Susan",
                LastName = "Taylor",
                Mobile = "666-666-6666",
                Email = "susan@taylor.com",
                City = "Victoria",
                Specialization = "Business"
            },
            new Student {
                StudentId = 7,
                FirstName = "Peter",
                LastName = "White",
                Mobile = "777-777-7777",
                Email = "peter@white.com",
                City = "Victoria",
                Specialization = "Criminal Justice"
            },
            new Student {
                StudentId = 8,
                FirstName = "Philip",
                LastName = "Fox",
                Mobile = "888-888-8888",
                Email = "philip@fox.com",
                City = "Prince George",
                Specialization = "History"
            },
            new Student {
                StudentId = 9,
                FirstName = "Donna",
                LastName = "Ray",
                Mobile = "999-999-9999",
                Email = "donna@ray.com",
                City = "Prince George",
                Specialization = "History"
            },
        };
        return students;
    }
}