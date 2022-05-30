
namespace CSharp
{
    public interface IToken 
    {
        string ToString();
    }

    public interface ILineStartToken 
    {
        int Number();
    }

    public interface ILineEndToken
    {
        int Number();
    }

    public interface ICommentToken    : IToken {}
    public interface IDirectiveToken  : IToken {}
    public interface IIdentifierToken : IToken {}
    public interface IKeywordToken    : IToken {}
    public interface IWhiteSpaceToken : IToken {}
    
    public interface IOtherToken      : IToken {}
}
