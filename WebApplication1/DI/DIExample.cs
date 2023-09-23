namespace WebApplication1.DI
{
    public class DIExample : Sample2 ,IDIExample
    {
        private readonly ISample _sample;

        // We register ISample in our DI Container
        // and inject it whenever we need it
        public DIExample(ISample sample)
        {
            _sample = sample;
        }

        // IOC principle: Inversion of control
        public void Sample()
        {
            MyBase obj = new MyBase();
            MyBase obj2 = new MyDerivedClass();
            MyDerivedClass obj3 = new MyDerivedClass();

            ISample obj5 = new Sample2();

            // this is not possible
            //MyDerivedClass obj4 = new MyBase();


            _sample.Name = "Sample";
        }
    }

    public class MyBase
    {
        public int BaseProperty { get; set; }
    }

    public class MyDerivedClass: MyBase
    {
        public int MyDerivedProperty { get; set; }
    }

    public interface ISample
    {
        void Sample();
        string Name { get; set; }

    }

    public class Sample2: ISample
    {
        public string Name { get; set; }

        public virtual void Sample()
        {
        }

        public void Sample33()
        {
        }
    }

    public class Sample3 : ISample
    {
        public string Name { get; set; }
        public void Sample()
        {
        }
    }

    public class Sample4 : ISample
    {
        public string Name { get; set; }
        public void Sample()
        {
        }
    }
}
