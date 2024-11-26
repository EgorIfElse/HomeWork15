internal class Program
{
    private static void Main(string[] args)
    {
        ArithProgression arithProgression = new ArithProgression();
        arithProgression.SetStart(2);
        arithProgression.SetStep(3);


        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());

        arithProgression.Reset();
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine();
        Console.WriteLine();

        GeomProgression geomprog = new GeomProgression(2, 5);

        Console.WriteLine(geomprog.GetNext());
        Console.WriteLine(geomprog.GetNext());
        Console.WriteLine(geomprog.GetNext());
        Console.WriteLine(geomprog.GetNext());

        geomprog.Reset();
        Console.WriteLine(geomprog.GetNext());
        Console.WriteLine(geomprog.GetNext());
        Console.WriteLine(geomprog.GetNext());
    }
    interface ISeries
    {
        void SetStart(int x); /// устанавливает начальное значение
        int GetNext(); ///- возвращает следующее число ряда
        void Reset();//- выполняет сброс к начальному значению

    }

    class ArithProgression : ISeries
    {
        int start;
        int step;
        int current;
        public void SetStart(int x)
        {
            start = x;
            current = start;
        }
        public int GetNext()
        {
            current += step;
            return current;

        }
        public void Reset()
        {
            current = start;

        }
        public void SetStep(int s)
        {
            step = s;
        }
    }





    class GeomProgression : ISeries
    {
        int start;
        int step;
        int current;
        public GeomProgression(int start, int step)
        {
            this.start = start;
            this.step = step;
            this.current = start;

        }
        public void SetStart(int x)
        {
            start = x;


        }
        public int GetNext()
        {

            start *= step;
            return start;

        }
        public void Reset()
        {
            start = current;
        }



    }

}