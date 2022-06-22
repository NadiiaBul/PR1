using System;
using System.Text;

namespace LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Queries query = new Queries();
            ListsContainer listsContainer = new ListsContainer();
            PrintOnScreen printOnScreen = new PrintOnScreen();

            printOnScreen.PrintCondition("1. Вивести всі дані про керівників:\n");
            printOnScreen.WriteOnScreen(query.ProfessorsInfo(listsContainer.Professors));

            printOnScreen.PrintCondition("\n2. Список всіх студентів відсортований за середнім балом(порядок спадання) та прізвищем студентів (у алфавітному порядку):\n");
            printOnScreen.WriteOnScreen(query.ListOfStudentsOrderByMarkAndSurname(listsContainer.Students));

            printOnScreen.PrintCondition("\n3. ПІБ студентів, середній бал яких більше 95:\n");
            printOnScreen.WriteOnScreen(query.ListOfStudentsWithHighMark(listsContainer.Students));

            printOnScreen.PrintCondition("\n4. Список студентів, поділених на групи, у яких вони навчаються:\n");
            printOnScreen.WriteOnScreen(query.StudentsGroupByGroups(listsContainer.Students, listsContainer.Groups));

            printOnScreen.PrintCondition("\n5. Знайти середній, найбільший та найменший бал серед всіх студентів:\n");
            printOnScreen.WriteOnScreen(query.FindMaxMinAverageMarks(listsContainer.Students));

            printOnScreen.PrintCondition("\n6. Порахувати скільки керівників займають кожну з посад:\n");
            printOnScreen.WriteOnScreen(query.ProfessorsGroupByPosition(listsContainer.Professors, listsContainer.Connections, listsContainer.Positions));

            printOnScreen.PrintCondition("\n7. Студенти-дипломники та їх керівники:\n");
            printOnScreen.PrintCondition("\n\t\tСТУДЕНТИ\t\t\t\t\tКЕРІВНИКИ\n");
            printOnScreen.WriteOnScreen(query.ListOfStudentsWithTheirProfessors(listsContainer.Students, listsContainer.Professors));

            printOnScreen.PrintCondition("\n8. Вивести назви всіх груп (без повторів):\n");
            printOnScreen.WriteOnScreen(query.ListOfGroupNames(listsContainer.Groups));

            printOnScreen.PrintCondition("\n9. Список студентів, керівники яких займають посаду доцента:\n");
            printOnScreen.WriteOnScreen(query.FindStudentsWhereProfessorsIsDocent(listsContainer.Students, listsContainer.Professors, listsContainer.Connections, listsContainer.Positions));

            printOnScreen.PrintCondition("\n10. Прізвища керівників, кількість студентів та їх інформація:\n");
            printOnScreen.WriteOnScreen(query.ListOfProfessorsWithAmountOfTheirStudentsAndGroups(listsContainer.Students, listsContainer.Professors));

            printOnScreen.PrintCondition("\n11. Список студентів та їх вік:\n");
            printOnScreen.WriteOnScreen(query.StudentsAndTheirAges(listsContainer.Students));

            printOnScreen.PrintCondition("\n12. Вивести 3 найвищі середні бали:\n");
            printOnScreen.WriteOnScreen(query.FindTopThreeMarks(listsContainer.Students));

            printOnScreen.PrintCondition("\n13. Використовуємо операцію Concat для виводу інформації про керівників:\n");
            printOnScreen.WriteOnScreen(query.ProfessorsInfoByConcat(listsContainer.Professors));

            printOnScreen.PrintCondition("\n14. Перевіряємо чи є серед студентів ті, хто народились 2000 року:\n");
            printOnScreen.WriteOnScreen(query.FindYearOfBirth(listsContainer.Students));

            printOnScreen.PrintCondition("\n15. Прізвища керівників, що починаються на літеру 'Д':\n");
            printOnScreen.WriteOnScreen(query.FindProfessorsSurname(listsContainer.Professors));
            Console.ReadLine();
        }
    }
}
