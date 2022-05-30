
namespace CSharp
{ 
    using System;
    
    public sealed class HTMLTokenVisitor : ITokenVisitor // Inherits from ITokenVisitor
    {
        public void Visit(ILineStartToken line) // Overriding NullTokenVisitor.Visit()
        {
            Console.Write("<span class=\"line_number\">");   
            Console.Write("{0, 3}", line.Number());         // Writing line numbers in one line
            Console.Write("</span>");
        }
        public void Visit(ILineEndToken t)
        {
            Console.WriteLine();    // Writing 'end of line' symbol after each line number in the above method
        }
        public void Visit(IIdentifierToken token)
        {
            SpannedFilteredWrite("identifier", token);
        }
        public void Visit(ICommentToken token)
        {
            SpannedFilteredWrite("comment", token);
        }
        public void Visit(IKeywordToken token)
        {
            SpannedFilteredWrite("keyword", token);
        }
        public void Visit(IWhiteSpaceToken token)
        {
            Console.WriteLine(token.ToString());
        }
        public void Visit(IOtherToken token)
        {
            FilteredWrite(token);
        }
        private void FilteredWrite(IToken token) // Introducing html symbols
        {
            string src = token.ToString();
            for (int i = 0; i != src.Length; i++){
                string dst;
                switch (src[i]){
                    case '<':
                        dst = "&lt";
                        break;
                    case '>':
                        dst = "&gt";
                        break;
                    case '&':
                        dst = "&amp";
                        break ;
                    default:
                        dst = new string(src[i], 1);
                        break;
                }
                Console.Write(dst);
            }            
        }
        private void SpannedFilteredWrite(string spanName, IToken token)
        {
            Console.Write("<span class=\"{0}\">", spanName);
            FilteredWrite(token);
            Console.Write("</span>");

        }
        public void Visit(IDirectiveToken token)
        {
            SpannedFilteredWrite("directive", token);
        }
    }
}
