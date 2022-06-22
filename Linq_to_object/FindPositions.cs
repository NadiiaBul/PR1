using System.Linq;

namespace LinqToObjects
{
    class FindPositions
    {
        public string Positions(uint ID)
        {
            ListsContainer listsContainer = new ListsContainer();
            string positions = "";
            var findPosition = from pos in listsContainer.Positions
                               join con in listsContainer.Connections on pos.IDPosition equals con.IDPosition
                               where con.IDProfessor == ID
                               select pos.Position;
            foreach (var x in findPosition)
            {
                positions += $"{x} ";
            }
            return positions;
        }
    }
}
