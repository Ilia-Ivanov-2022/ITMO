
namespace CSharp
{
    internal struct Position // in a SourceFile
    {
        public Position(char[] contents, int index)
        {
            this.contents = contents;
            this.index = index;
        }

        public char Get() 
        {
            // could check if index >= contents.Length
            // and throw a user defined exception here
            return contents[index]; 
        }

        public static string MakeString(Position begin, Position end)
        {
            CheckSameWhole(begin, end);
            if (begin > end) {
                throw new System.ArgumentException("end not reachable from begin");
            }
            return new string(begin.contents, begin.index, end-begin);
        }
                
        public static Position operator++(Position p)
        {
            p.index++;
            return p;
        }

        public static Position operator--(Position p)
        {
            p.index--;
            return p;
        }
        
        public static Position operator+(Position lhs, int rhs)
        {
            return new Position(lhs.contents, lhs.index + rhs);    
        }
            
        public static Position operator+(int lhs, Position rhs)
        {
            return new Position(rhs.contents, rhs.index + lhs);
        }
        
        public static int operator-(Position lhs, Position rhs)
        {
            CheckSameWhole(lhs, rhs);
            return lhs.index - rhs.index;
        }
        
        public static bool operator==(Position lhs, Position rhs)
        {
            return lhs.contents == rhs.contents
                && lhs.index == rhs.index;
        }
                
        public static bool operator!=(Position lhs, Position rhs)
        {
            return !(lhs == rhs);
        }

        public static bool operator<(Position lhs, Position rhs)
        {
            return lhs.contents == rhs.contents 
                && lhs.index < rhs.index;
        }
        
        public static bool operator>(Position lhs, Position rhs)
        {
            return lhs.contents == rhs.contents
                && lhs.index > rhs.index;
        }

        public static bool operator<=(Position lhs, Position rhs)
        {
            return lhs.contents == rhs.contents 
                && lhs.index <= rhs.index;
        }
        
        public static bool operator>=(Position lhs, Position rhs)
        {
            return lhs.contents == rhs.contents
                && lhs.index >= rhs.index;
        }
        
        private static void CheckSameWhole(Position lhs, Position rhs)
        {
            if (lhs.contents != rhs.contents) {
                string msg = "Position parameters refer to different char arrays";
                throw new System.ArgumentException(msg);
            }
        }
               
        private readonly char[] contents;
        private int index;
    }
}

