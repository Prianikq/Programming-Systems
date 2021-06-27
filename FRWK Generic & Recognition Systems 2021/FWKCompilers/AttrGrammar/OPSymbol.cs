using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Processor.AbstractGrammar;

namespace Processor.AttrGrammar
{
    public class OPSymbol : Symbol
    {
        public AttrFunction function = null;  // убрать в общее множество F 

         // symbol operation  x, y => x + y ;  )
         Func<int,int,int> f = null;

    //   Func<int, int> square = (s) => s * s;
        public OPSymbol(string s,List<Symbol> a,List<Symbol> L, List<Symbol> R): 
            base(s,a) {
            function = new AttrFunction(L,R); 
        }

        public OPSymbol(string s, List<Symbol> a) : base(s, a) {}

    public OPSymbol(string s) : base(s) { }

    public override void print() {      
            Console.Write(this.symbol + "\n");    
        }
    }

}
