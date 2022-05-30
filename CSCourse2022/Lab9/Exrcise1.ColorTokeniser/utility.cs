
namespace CSharp
{
    /// <summary>
    /// Utility contains two interfaces and a number of
    /// static methods. It is modeled on some of the most
    /// commonly used algorithms from C++.
    /// Utility has to be a class as static methods can't
    /// live directly in a namespace but is not intended
    /// to be used to create objects or to be derived from.
    /// hence its constructor is private and it is a sealed
    /// class.
    /// </summary>
    
    internal sealed class Utility
    {
        internal interface IPredicate1
        {
            bool Execute(char current);
        }

        internal interface IPredicate2
        {
            bool Execute(char lhs, char rhs);
        }

        internal static 
        bool Equal(Position begin, Position end, string s)
        {
            int i = 0;
            while (begin != end && begin.Get() == s[i]) {
                begin++;
                i++;
            }
            return begin == end;
        }

        internal static 
        Position Find(Position begin, Position end, char value)
        {
            while (begin != end && begin.Get() != value) {
                ++begin;
            }
            return begin;
        }

        internal static 
        Position FindIf(Position begin, Position end, IPredicate1 f)
        {
            while (begin != end && !f.Execute(begin.Get())) {
                ++begin;
            }
            return begin;
        }
        
        internal static 
        Position AdjacentFind(Position begin, Position end, IPredicate2 f)
        {
            Position result = begin;
            if (begin != end) {
                while (++begin != end && !f.Execute(result.Get(), begin.Get())) {
                    result = begin;
                }
            }
            return (begin == end) ? end : result;
        }
        
        private Utility() {}
    }
}    
