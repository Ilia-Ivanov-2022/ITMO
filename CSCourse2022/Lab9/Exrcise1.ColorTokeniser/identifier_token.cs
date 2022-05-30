
namespace CSharp
{
    using Ctype = System.Char;

    /// <remarks>
    /// The Identifier class does not support the 
    /// syntax that allows a @ character to prefix 
    /// an identifier.
    /// </remarks>
       
    internal sealed class Identifier
    {
        /// <summary>
        /// Match is a static method that determines whether
        /// or not the token starting at 
        /// <paramref name="begin">begin</paramref>
        /// is an C# identifier. 
        /// </summary>        
        /// <param name="begin">begin</param>
        /// <param name="end">end</param>
        
        internal static bool Match(Position begin, Position end)
        {
            if (begin == end) {
                return false;
            }
            char read = begin.Get();
            return Ctype.IsLetter(read) || read == '_';
        }
        
        /// <summary>
        /// Eat is a static method that eats the identifier
        /// token assumed to start at 
        /// <paramref name="begin">begin</paramref>.
        /// </summary>        
        /// <param name="begin">begin</param>
        /// <param name="end">end</param>        
        /// <returns>
        /// A Position representing the first 
        /// character not in the identifier token. The
        /// returned Position is useful as the second
        /// parameter to the MakeToken method.
        /// </returns>

        internal static Position Eat(Position begin, Position end)
        {
            return Utility.FindIf(begin, end, notIdentifier);
        }

        /// <summary>
        /// MakeToken is a static method that creates and
        /// returns a token representing an identifier that 
        /// starts at 
        /// <paramref name="begin">begin</paramref>
        /// and finishes just before 
        /// <paramref name="end">end</paramref>.
        /// </summary>
        /// <param name="begin">begin</param>
        /// <param name="end">end</param>        

        internal static 
        IIdentifierToken MakeToken(Position begin, Position end) 
        { 
            return new IdentifierToken(begin, end); 
        }

        private sealed class IdentifierToken : Token, IIdentifierToken
        {
            internal IdentifierToken(Position begin, Position end)
              : base(begin, end)
            {
            }
        
            internal override void Accept(ITokenVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        private static readonly NotIdentifier notIdentifier
            = new NotIdentifier();
            
        private sealed class NotIdentifier : Utility.IPredicate1
        {
            public bool Execute(char current)
            {
                return !(Ctype.IsLetter(current) 
                      || Ctype.IsDigit(current)
                      || current == '_');
            }
        }
        
        private Identifier() {}
    }
}
