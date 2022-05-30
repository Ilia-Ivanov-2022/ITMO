
namespace CSharp
{
    using Ctype = System.Char;
    
    internal sealed class WhiteSpace
    {
        internal static 
        bool Match(Position begin, Position end)
        {
            return begin != end && Ctype.IsWhiteSpace(begin.Get());
        }
    
        internal static 
        Position Eat(Position begin, Position end)
        {
            return Utility.FindIf(begin, end, notWhiteSpace);
        }

        internal static 
        IWhiteSpaceToken MakeToken(Position begin, Position end) 
        { 
            return new WhiteSpaceToken(begin, end); 
        }
        
        private sealed class WhiteSpaceToken : Token, IWhiteSpaceToken
        {
            internal WhiteSpaceToken(Position begin, Position end)
              : base(begin, end)
            {
            }
     
            internal override void Accept(ITokenVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        private static readonly NotWhiteSpace notWhiteSpace
            = new NotWhiteSpace();
                
        private sealed class NotWhiteSpace : Utility.IPredicate1
        {
            public bool Execute(char current)
            {
                return !Ctype.IsWhiteSpace(current);
            }
        }
        
        private WhiteSpace() {}
    }
}
