
namespace CSharp
{
    internal sealed class MultiLineComment
    {
        internal static bool Match(Position begin, Position end)
        {
            return (end - begin >= 2 && Utility.Equal(begin, begin+2, "/*"));
        }
        
        internal static Position Eat(Position begin, Position end)
        {
            // It is tempting to think you can make this
            // method a bit smarter and to check if the
            // Position returned by AdjacentFind equals end
            // and if it does to increment it twice. Don't.
            // If you do this the caller won't be able to
            // tell if the comment was closed when the end
            // of the line was reached.
            
            return Utility.AdjacentFind(begin, end, starForwardSlash);
        }

        internal static 
        ICommentToken MakeToken(Position begin, Position end) 
        { 
            return new MultiLineCommentToken(begin, end); 
        }
        
        private sealed class MultiLineCommentToken : Token, ICommentToken
        {
            internal MultiLineCommentToken(Position begin, Position end)
              : base(begin, end)
            {
            }

            internal override void Accept(ITokenVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        private static readonly StarForwardSlash starForwardSlash 
            = new StarForwardSlash();

        private sealed class StarForwardSlash : Utility.IPredicate2
        {
            public bool Execute(char previous, char current)
            {
                return previous == '*' && current == '/';
            }
        }
        
        private MultiLineComment() {}
    }
}
