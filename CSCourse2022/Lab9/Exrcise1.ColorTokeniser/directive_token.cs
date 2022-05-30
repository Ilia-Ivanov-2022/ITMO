
namespace CSharp
{
    internal sealed class Directive
    {
        internal static 
        bool Match(Position begin, Position end)
        {
            return begin != end && begin.Get() == '#';
        }

        internal static 
        Position Eat(Position begin, Position end)
        {
            return end;
        }
        
        internal static 
        IDirectiveToken MakeToken(Position begin, Position end) 
        { 
            return new DirectiveToken(begin, end); 
        }
        
        private sealed class DirectiveToken : Token, IDirectiveToken
        {
            internal DirectiveToken(Position begin, Position end)
              : base(begin, end)
            {
            }
        
            internal override void Accept(ITokenVisitor visitor)
            {
                visitor.Visit(this);
            }
        }
        
        private Directive() {}
    }
}
