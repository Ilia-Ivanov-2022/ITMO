
namespace CSharp
{
    /// <remarks>
    /// The specific kinds of derived token interfaces are
    /// not complete. For example, there are no interface
    /// class representing any of the literals. Any unrecognised
    /// token causes the remainder of the source file line
    /// to be classified as an IOtherToken. For example,
    /// in this code:
    /// <code>
    /// string message = "Hello"; int answer = 42;
    /// </code>
    /// there are five tokens:
    /// 'string' (a Keyword token),
    /// ' ' (a Whitespace token),
    /// 'message' (an Identifier token),
    /// ' ' (a Whitespace token)
    /// and '= "Hello"; int answer = 42;' (an Other token)
    /// </remarks>      
    
    public interface ITokenVisitor
    {
        void Visit(ILineStartToken t);
        void Visit(ILineEndToken   t);

        void Visit(ICommentToken    t);
        void Visit(IDirectiveToken  t);
        void Visit(IIdentifierToken t);
        void Visit(IKeywordToken    t);
        void Visit(IWhiteSpaceToken t);

        void Visit(IOtherToken t);
    }    
}
