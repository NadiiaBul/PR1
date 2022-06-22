
namespace LinqToObjects
{
    class TextNormalize
    {
        public string NormalizePosition(string position)
        {
            return position.ToLower();
        }
        public string NormalizeGroup(string group)
        {
            return group.ToUpper();
        }
    }
}
