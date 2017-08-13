namespace ConsoleApp
{
    public class MyClass
    {
        public MyClass(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get; }
        public int Num2 { get; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Num1 ^ Num2;
        }

        public override string ToString()
        {
            return string.Format(@"Override the Object's ToString() for MyClass with Num1:{0}, Num2:{1}",Num1,Num2);
        }
    }
}