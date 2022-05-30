
namespace CSharp
{
    public abstract class NullTokenVisitor : ITokenVisitor
    {
        public virtual void Visit(ILineStartToken t) { }
        public virtual void Visit(ILineEndToken t) { }

        public virtual void Visit(ICommentToken t) { }
        public virtual void Visit(IDirectiveToken t) { }
        public virtual void Visit(IIdentifierToken t) { }
        public virtual void Visit(IKeywordToken t) { }
        public virtual void Visit(IWhiteSpaceToken t) { }

        public virtual void Visit(IOtherToken t) { }

        
    }
}
