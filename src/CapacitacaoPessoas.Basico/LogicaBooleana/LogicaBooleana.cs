using Csl = System.Console;

namespace CapacitacaoPessoas.Basico.LogicaBooleana
{
    public class LogicaBooleana
    {
        public void OperadorAnd()
        {
            Csl.WriteLine($"true && true: {true && true}");
            Csl.WriteLine($"true && false: {true && false}");
            Csl.WriteLine($"false && true: {false && true}");
            Csl.WriteLine($"false && false: {false && false}");

            Csl.WriteLine($"true & true: {true & true}");
            Csl.WriteLine($"true & false: {true & false}");
            Csl.WriteLine($"false & true: {false & true}");
            Csl.WriteLine($"false & false: {false & false}");
        }

        public void OperadorOr()
        {
            Csl.WriteLine($"true || true: {true || true}");
            Csl.WriteLine($"true || false: {true || false}");
            Csl.WriteLine($"false || true: {false || true}");
            Csl.WriteLine($"false || false: {false || false}");

            Csl.WriteLine($"true | true: {true | true}");
            Csl.WriteLine($"true | false: {true | false}");
            Csl.WriteLine($"false | true: {false | true}");
            Csl.WriteLine($"false | false: {false | false}");
        }

        public void OperadorXor()
        {
            Csl.WriteLine($"true ^ true: {true ^ true}");
            Csl.WriteLine($"true ^ false: {true ^ false}");
            Csl.WriteLine($"false ^ true: {false ^ true}");
            Csl.WriteLine($"false ^ false: {false ^ false}");
        }

        public void OperadorNot()
        {
            Csl.WriteLine($"!true: {!true}");
            Csl.WriteLine($"!false: {!false}");
        }
    }
}