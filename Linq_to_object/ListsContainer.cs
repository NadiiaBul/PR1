using System;
using System.Collections.Generic;

namespace LinqToObjects
{
    class ListsContainer
    {
        public List<Groups> Groups { get; set; } = new List<Groups>()
        {
            new Groups{IDGroup = 1, Group = "БП-01"},
            new Groups{IDGroup = 2, Group = "БП-02"},
            new Groups{IDGroup = 3, Group = "БП-03"},
            new Groups{IDGroup = 4, Group = "БВ-01"},
            new Groups{IDGroup = 5, Group = "БВ-02"},
            new Groups{IDGroup = 6, Group = "БВ-03"},
            new Groups{IDGroup = 7, Group = "БВ-04"}
        };
        public List<Student> Students { get; set; } = new List<Student>()
        {
                new Student {ID = 1, Surname = "Трохименко", Name = "Іван", Patronymic = "Іванович", IDGroup = 1, Birthday = DateTime.Parse("24.11.2002"), Mark = 97.3m, ProfessorID = 1},
                new Student {ID = 2, Surname = "Малютенко", Name = "Людмила", Patronymic = "Ігорівна", IDGroup = 6, Birthday = DateTime.Parse("28.06.1999"), Mark = 95.4m, ProfessorID = 2},
                new Student {ID = 3, Surname = "Стожанюк", Name = "Ігор", Patronymic = "Сергійович", IDGroup = 1, Birthday = DateTime.Parse("18.01.2002"), Mark = 92.8m, ProfessorID = 1},
                new Student {ID = 4, Surname = "Прохопчук", Name = "Петро", Patronymic = "Павлович", IDGroup = 2, Birthday = DateTime.Parse("12.09.2001"), Mark = 88.3m, ProfessorID = 3},
                new Student {ID = 5, Surname = "Волокунь", Name = "Марія", Patronymic = "Тарасівна", IDGroup = 7, Birthday = DateTime.Parse("03.11.2000"), Mark = 87.7m, ProfessorID = 4},
                new Student {ID = 6, Surname = "Тарапата", Name = "Максим", Patronymic = "Павлович", IDGroup = 5, Birthday = DateTime.Parse("14.07.2001"), Mark = 93.5m, ProfessorID = 5},
                new Student {ID = 7, Surname = "Любахович", Name = "Злата", Patronymic = "Олегівна", IDGroup = 1, Birthday = DateTime.Parse("15.05.2002"), Mark = 94.1m, ProfessorID = 1},
                new Student {ID = 8, Surname = "Антонович", Name = "Ольга", Patronymic = "Степанівна", IDGroup = 4, Birthday = DateTime.Parse("21.10.1999"), Mark = 95.9m, ProfessorID = 6},
                new Student {ID = 9, Surname = "Хвастунець", Name = "Федір", Patronymic = "Романович", IDGroup = 5, Birthday = DateTime.Parse("03.04.2000"), Mark = 87.7m, ProfessorID = 5},
                new Student {ID = 10, Surname = "Боднарук", Name = "Ілля", Patronymic = "Васильович", IDGroup = 3, Birthday = DateTime.Parse("12.11.2001"), Mark = 92.8m, ProfessorID = 6}
        };
        public List<Positions> Positions { get; set; } = new List<Positions>()
        {
            new Positions{IDPosition = 1, Position = "доцент"},
            new Positions{IDPosition = 2, Position = "професор"},
            new Positions{IDPosition = 3, Position = "завідувач кафедри"}
        };
        public List<ConnectionsManyToMany> Connections { get; set; } = new List<ConnectionsManyToMany>()
        {
            new ConnectionsManyToMany{IDProfessor = 1, IDPosition = 1},
            new ConnectionsManyToMany{IDProfessor = 2, IDPosition = 1},
            new ConnectionsManyToMany{IDProfessor = 3, IDPosition = 2},
            new ConnectionsManyToMany{IDProfessor = 4, IDPosition = 1},
            new ConnectionsManyToMany{IDProfessor = 4, IDPosition = 3},
            new ConnectionsManyToMany{IDProfessor = 5, IDPosition = 2},
            new ConnectionsManyToMany{IDProfessor = 6, IDPosition = 1}
        };
        public List<Professor> Professors { get; set; } = new List<Professor>()
            {
                new Professor {ID = 1, Surname = "Добренький", Name = "Олександр", Patronymic = "Дмитрович"},
                new Professor {ID = 2, Surname = "Китунець", Name = "Володимир", Patronymic = "Вікторович"},
                new Professor {ID = 3, Surname = "Рибарчук", Name = "Світлана", Patronymic = "Михайлівна"},
                new Professor {ID = 4, Surname = "Жаданович", Name = "Мирослав", Patronymic = "Денисович"},
                new Professor {ID = 5, Surname = "Полюхович", Name = "Святослав", Patronymic = "Панасович"},
                new Professor {ID = 6, Surname = "Довганюк", Name = "Василина", Patronymic = "Іванівна"}
            };
    }
}
