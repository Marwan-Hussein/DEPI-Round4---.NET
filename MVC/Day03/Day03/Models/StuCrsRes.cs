namespace Day02.Models
{
    public class StuCrsRes
    {
        public double Grade { get; set; }

        // FK
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        // NPs
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
