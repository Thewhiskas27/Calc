namespace Calc
{
    public class Calc
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add() { return FirstNumber + SecondNumber; }
        public int Sub() { return FirstNumber - SecondNumber; }
        public int Mult() { return FirstNumber * SecondNumber; }
        public int Div() { return FirstNumber / SecondNumber; }
    }
}
