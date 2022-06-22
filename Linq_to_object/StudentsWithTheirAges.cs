
namespace LinqToObjects
{
    class StudentsWithTheirAges
    {
        public string StudentSurname { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{StudentSurname} {StudentName} - {Age} р.";
        }
    }
}
