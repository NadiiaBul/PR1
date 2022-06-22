
namespace LinqToObjects
{
    class InitialsStudetsWithInitialsProffesor
    {
        public string StudentSurname { get; set; }
        public string StudentName { get; set; }
        public string StudentPatronymic { get; set; }
        public string ProfessorSurname { get; set; }
        public string ProfessorName { get; set; }
        public string ProfessorPatronymic { get; set; }
        public override string ToString()
        {
            return $"{StudentSurname}\t{StudentName}\t{StudentPatronymic}\t{ProfessorSurname}\t{ProfessorName}\t{ProfessorPatronymic}\t";
        }
    }
}
