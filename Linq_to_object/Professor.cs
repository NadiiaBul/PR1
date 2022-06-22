using System.Linq;

namespace LinqToObjects
{
    public class Professor : Person
    {
        public override string ToString()
        {
          return $"ID керівника: {ID}\tПрізвище: {Surname}\tІм'я: {Name}\tПо батькові: {Patronymic}\tПосада:{new FindPositions().Positions(ID)}\t"; 
        }
    }
}
