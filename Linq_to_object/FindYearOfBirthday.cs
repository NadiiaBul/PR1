
namespace LinqToObjects
{
    class FindYearOfBirthday
    {
        public string StudentSurname { get; set; }
        public bool IsYear2000 { get; set; }
        public override string ToString()
        {
            return IsYear2000 ? $"Студент(ка) {StudentSurname} народився(лась) 2000 року." : $"Студент(ка) {StudentSurname} народився(лась) іншого року.";
        }
    }
}
