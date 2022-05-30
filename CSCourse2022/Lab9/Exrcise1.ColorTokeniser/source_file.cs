       
namespace CSharp
{
    using System.Collections;
    using System.IO;
    using Ctype = System.Char;
    
    public sealed class SourceFile
    {
        public SourceFile(string filename)
        {
            FileInfo source = new FileInfo(filename);
            StreamReader reader = source.OpenText();

            try {              
                int count = (int)source.Length;
                contents = new char[count];
                reader.Read(contents, 0, count);
                SplitIntoLines();
            }
            finally {
                reader.Close();
            }
        }

        public void Accept(ITokenVisitor visitor)
        {
            LineStart.Token start = new LineStart.Token(1);
            LineEnd.Token end = new LineEnd.Token(1);
            foreach(Line line in lines) {
                visitor.Visit(start); start++;  
                line.Accept(visitor);
                visitor.Visit(end); end++; 
            }
        }

        private class Line
        {
            internal Line(Position begin, Position end, ref bool inComment)
            {
                while (begin != end) {
                    Position pos; 
                    if (inComment || MultiLineComment.Match(begin, end)) { 
                        pos = MultiLineComment.Eat(begin, end);
                        if (pos != end) {
                            ++pos; ++pos; inComment = false;
                        } else {
                            inComment = true;
                        }
                        tokens.Add(MultiLineComment.MakeToken(begin, pos));
                    } 
                    else if (OneLineComment.Match(begin, end)) {
                        pos = OneLineComment.Eat(begin, end);
                        tokens.Add(OneLineComment.MakeToken(begin, pos));
                    } 
                    else if (WhiteSpace.Match(begin, end)) {
                        pos = WhiteSpace.Eat(begin, end);
                        tokens.Add(WhiteSpace.MakeToken(begin, pos));
                    } 
                    else if (Identifier.Match(begin, end)) {
                        pos = Identifier.Eat(begin, end);
                        if (Keyword.Match(begin, pos)) {
                            tokens.Add(Keyword.MakeToken(begin, pos));
                        } else {
                            tokens.Add(Identifier.MakeToken(begin, pos));
                        }
                    }
                    else if (Directive.Match(begin, end)) {
                        pos = Directive.Eat(begin, end);
                        tokens.Add(Directive.MakeToken(begin, pos));
                    }
                    else {
                        pos = end;
                        tokens.Add(Other.MakeToken(begin, end));
                    }

                    begin = pos;
                }
            }

            public void Accept(ITokenVisitor visitor)
            {
                foreach (Token token in tokens) {
                    token.Accept(visitor);
                }
            }

            private class NotWhiteSpace : Utility.IPredicate1
            {
                public virtual bool Execute(char current)
                {
                    return !Ctype.IsWhiteSpace(current);
                }
            }
        
            private static readonly NotWhiteSpace notWhiteSpace
                = new NotWhiteSpace();            
            
            internal bool IsBlank()
            {
                return tokens.Count == 0 ||
                       (tokens.Count == 1
                    && tokens[0] is IWhiteSpaceToken);
            }
           
            private readonly ArrayList tokens = new ArrayList();
        }
        
        private void SplitIntoLines()
        {
            Position begin = new Position(contents, 0);
            Position end = new Position(contents, contents.Length);
            Position pos;
            bool inComment = false;
            while ((pos = Utility.Find(begin, end, '\r')) != end) {
                lines.Add(new Line(begin, pos, ref inComment));
                begin = ++pos;
                if (begin != end && begin.Get() == '\n') {
                    ++begin;
                }
            }
            
            // last line might not have a terminating newline
            if (begin != end) {
                lines.Add(new Line(begin, pos, ref inComment));
            }

            // remove trailing blank lines
            while (lines.Count > 0 && ((Line)lines[lines.Count-1]).IsBlank()) {
                lines.RemoveAt(lines.Count - 1);
            }
        }
        
        private readonly char[] contents;
        private ArrayList lines = new ArrayList();
    }
}

