using Day02.Data.DbContexts;
using Day02.Models;

namespace Day02.Data
{
    public static class DatabaseSeeder
    {
        private static readonly Random _rng = new();

        // ── name pools ──────────────────────────────────────────────────
        private static readonly string[] DeptNames =
            ["Computer Science", "Mathematics", "Physics", "Engineering", "Business"];

        private static readonly string[] MgrNames =
            ["Dr. Ahmed", "Dr. Sara", "Dr. Khaled", "Dr. Nour", "Dr. Omar"];

        private static readonly string[] FirstNames =
            ["Ali", "Mona", "Omar", "Sara", "Youssef", "Nada", "Khaled", "Rana", "Hassan", "Layla"];

        private static readonly string[] LastNames =
            ["Hassan", "Mostafa", "Ibrahim", "Khalil", "Saleh", "Nasser", "Farouk", "Samir"];

        private static readonly string[] CourseNames =
            ["Algorithms", "Data Structures", "Calculus", "Linear Algebra",
             "OOP", "Database Systems", "Networking", "Operating Systems",
             "Thermodynamics", "Marketing"];

        private static readonly string[] Addresses =
            ["Cairo", "Giza", "Alexandria", "Mansoura", "Aswan", "Luxor", "Tanta"];

        // ── public entry point ──────────────────────────────────────────
        /// <summary>
        /// Seeds the database with randomized records.
        /// Call this once at application startup (e.g. from Program.cs).
        /// Skips seeding if any departments already exist.
        /// </summary>
        public static void Seed(CollegeSystemDbContext db)
        {
            // Guard: only seed on an empty database
            if (db.Departments.Any()) return;

            // 1. Departments
            var departments = SeedDepartments(db);

            // 2. Courses (depend on departments)
            var courses = SeedCourses(db, departments);

            // 3. Students (depend on departments)
            var students = SeedStudents(db, departments);

            // 4. Teachers (depend on departments + courses)
            SeedTeachers(db, departments, courses);

            // 5. StuCrsRes – composite PK (StudentId, CourseId)
            SeedStuCrsRes(db, students, courses);
        }

        // ── private helpers ─────────────────────────────────────────────

        private static List<Department> SeedDepartments(CollegeSystemDbContext db)
        {
            var departments = DeptNames
                .Select((name, i) => new Department
                {
                    Name    = name,
                    MgrName = MgrNames[i % MgrNames.Length]
                })
                .ToList();

            db.Departments.AddRange(departments);
            db.SaveChanges();
            return departments;
        }

        private static List<Course> SeedCourses(
            CollegeSystemDbContext db, List<Department> departments)
        {
            var courses = CourseNames
                .Select(name =>
                {
                    double degree    = _rng.Next(50, 100);
                    double minDegree = Math.Round(degree * 0.5, 1);
                    return new Course
                    {
                        Name         = name,
                        Degree       = degree,
                        MinDegree    = minDegree,
                        DepartmentId = departments[_rng.Next(departments.Count)].Id
                    };
                })
                .ToList();

            db.Courses.AddRange(courses);
            db.SaveChanges();
            return courses;
        }

        private static List<Student> SeedStudents(
            CollegeSystemDbContext db, List<Department> departments)
        {
            var students = Enumerable.Range(0, 20)
                .Select(_ => new Student
                {
                    Name         = $"{Pick(FirstNames)} {Pick(LastNames)}",
                    Age          = _rng.Next(18, 30),
                    DepartmentId = departments[_rng.Next(departments.Count)].Id
                })
                .ToList();

            db.Students.AddRange(students);
            db.SaveChanges();
            return students;
        }

        private static void SeedTeachers(
            CollegeSystemDbContext db,
            List<Department> departments,
            List<Course> courses)
        {
            var teachers = Enumerable.Range(0, 10)
                .Select(_ => new Teacher
                {
                    Name         = $"Dr. {Pick(FirstNames)} {Pick(LastNames)}",
                    Salary       = Math.Round((decimal)(_rng.NextDouble() * 8000 + 3000), 2),
                    Address      = Pick(Addresses),
                    DepartmentId = departments[_rng.Next(departments.Count)].Id,
                    CourseId     = courses[_rng.Next(courses.Count)].Id
                })
                .ToList();

            db.Teachers.AddRange(teachers);
            db.SaveChanges();
        }

        private static void SeedStuCrsRes(
            CollegeSystemDbContext db,
            List<Student> students,
            List<Course> courses)
        {
            // Each student gets 2–4 unique courses
            var records = new List<StuCrsRes>();
            var seen    = new HashSet<(int, int)>();

            foreach (var student in students)
            {
                int count = _rng.Next(2, 5);
                var shuffled = courses.OrderBy(_ => _rng.Next()).Take(count);

                foreach (var course in shuffled)
                {
                    var key = (student.Id, course.Id);
                    if (seen.Add(key))
                    {
                        records.Add(new StuCrsRes
                        {
                            StudentId = student.Id,
                            CourseId  = course.Id,
                            Grade     = Math.Round(_rng.NextDouble() * course.Degree, 2)
                        });
                    }
                }
            }

            db.StuCrsRes.AddRange(records);
            db.SaveChanges();
        }

        // ── tiny utility ────────────────────────────────────────────────
        private static T Pick<T>(T[] array) => array[_rng.Next(array.Length)];
    }
}
