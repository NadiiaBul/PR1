using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObjects
{
    class Queries
    {
        private readonly TextNormalize _textNormalize = new TextNormalize();
        public IEnumerable<Professor> ProfessorsInfo(List<Professor> professors)
        {
            var professorsInfo = from professor in professors select professor;
            return professorsInfo;
        }
        public IEnumerable<Student> ListOfStudentsOrderByMarkAndSurname(List<Student> students)
        {
            var listOfStudentsOrderByMarkAndSurname = students.Select(st => st)
                .OrderByDescending(s => s.Mark).ThenBy(s => s.Surname);
            return listOfStudentsOrderByMarkAndSurname;
        }
        public IEnumerable<Student> ListOfStudentsWithHighMark(List<Student> students)
        {
            var listOfStudentsWithHighMark = from st in students
                                             where st.Mark > 95
                                             orderby st.Mark descending
                                             select st;
            return listOfStudentsWithHighMark;
        }
        public Dictionary<string, List<Student>> StudentsGroupByGroups(List<Student> students, List<Groups> groups)
        {
            var studentsGroupByGroups = from st in students
                                        join gr in groups on st.IDGroup equals gr.IDGroup
                                        group st by _textNormalize.NormalizeGroup(gr.Group) into newGroup
                                        orderby newGroup.Key
                                        select newGroup;
            return studentsGroupByGroups.ToDictionary(x=>x.Key, x=>x.ToList());
        }
        public IEnumerable<decimal> FindMaxMinAverageMarks(List<Student> students)
        {
            var findMaxMinAverageMarks = students.Select(s => s.Mark);
            yield return findMaxMinAverageMarks.Average();
            yield return findMaxMinAverageMarks.Max();
            yield return findMaxMinAverageMarks.Min();
        }
        public Dictionary<string, List<Professor>> ProfessorsGroupByPosition(List<Professor> professors, List<ConnectionsManyToMany> connections, List<Positions> positions)
        {
            var professorsGroupByPosition = from pr in professors
                                            join con in connections on pr.ID equals con.IDProfessor
                                            join pos in positions on con.IDPosition equals pos.IDPosition
                                            group pr by _textNormalize.NormalizePosition(pos.Position) into newGroupPosition
                                            select newGroupPosition;

            return professorsGroupByPosition.ToDictionary(x => x.Key, x => x.ToList());
        }
        public IEnumerable<InitialsStudetsWithInitialsProffesor> ListOfStudentsWithTheirProfessors(List<Student> students, List<Professor> professors)
        {
            var listOfStudentsWithTheirProfessors = from st in students
                                                    join pr in professors on st.ProfessorID equals pr.ID
                                                    select new InitialsStudetsWithInitialsProffesor { StudentSurname = st.Surname
                                                    , StudentName = st.Name
                                                    , StudentPatronymic = st.Patronymic
                                                    , ProfessorSurname = pr.Surname
                                                    , ProfessorName = pr.Name
                                                    , ProfessorPatronymic = pr.Patronymic };
     
            return listOfStudentsWithTheirProfessors;  
        }
        public IEnumerable<string> ListOfGroupNames(List<Groups> groups)
        {
            var listOfGroupNames = groups.Select(gr => _textNormalize.NormalizeGroup(gr.Group)).OrderBy(g => g).Distinct();
            return listOfGroupNames;
        }
        public IEnumerable<Student> FindStudentsWhereProfessorsIsDocent(List<Student> students, List<Professor> professors, List<ConnectionsManyToMany> connections, List<Positions> positions)
        {
            var findStudentsWhereProfessorsIsDocent = from st in students
                                                      join pr in professors on st.ProfessorID equals pr.ID
                                                      join con in connections on pr.ID equals con.IDProfessor
                                                      join pos in positions on con.IDPosition equals pos.IDPosition
                                                      where _textNormalize.NormalizePosition(pos.Position) is "доцент"
                                                      select st;
            return findStudentsWhereProfessorsIsDocent;
        }
        public Dictionary<string, List<Student>> ListOfProfessorsWithAmountOfTheirStudentsAndGroups(List<Student> students, List<Professor> professors)
        {
            var listOfProfessorsWithAmountOfTheirStudentsAndGroups = from st in students
                                                                     join pr in professors on st.ProfessorID equals pr.ID
                                                                     group st by pr.Surname into prGroup
                                                                     select prGroup;
            return listOfProfessorsWithAmountOfTheirStudentsAndGroups.ToDictionary(x => x.Key, x => x.ToList());
        }
        public IEnumerable<StudentsWithTheirAges> StudentsAndTheirAges(List<Student> students)
        {
            var studentsAndTheirAges = from age in students
                                       select new StudentsWithTheirAges {StudentSurname = age.Surname
                                       , StudentName = age.Name
                                       , Age = DateTime.Now.Year - age.Birthday.Year };

            return studentsAndTheirAges;
        }
        public IEnumerable<decimal> FindTopThreeMarks(List<Student> students)
        {
            var topThreeMarks = students.Select(mark => mark.Mark).OrderByDescending(m => m).Take(3);
            return topThreeMarks;
        }
        public IEnumerable<Professor> ProfessorsInfoByConcat(List<Professor> professors)
        {
            var professorsInfoByConcat = professors.Take(3).Concat(professors.Skip(3));
            return professorsInfoByConcat;
        }
        public IEnumerable<FindYearOfBirthday> FindYearOfBirth(List<Student> students)
        {
            var findYearOfBirth = students.Select(Surname => Surname.Surname);
            foreach (var st in findYearOfBirth)
            {
                var findYear = students.Where(year => year.Birthday.Year is 2000).Select(sN => sN.Surname).Contains(st);
                yield return new FindYearOfBirthday { StudentSurname = st, IsYear2000 = findYear };
            }
        }
        public IEnumerable<Professor> FindProfessorsSurname(List<Professor> professors)
        {
            var findProfessorsSurname = professors.Where(profSurName => profSurName.Surname.StartsWith("Д"));
            return findProfessorsSurname;
        }
    }
}
