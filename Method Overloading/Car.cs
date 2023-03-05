namespace Method_Overloading
{
    internal class Car
    {
        public int NoOfTires { get; internal set; }

        internal void Brake()
        {
            throw new NotImplementedException();
        }

        internal void Print()
        {
            throw new NotImplementedException();
        }
    }
}