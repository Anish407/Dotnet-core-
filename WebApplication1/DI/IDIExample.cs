namespace WebApplication1.DI
{
    public interface IDIExample
    {
        void Sample();
    }

    class MyClass
    {
       public void Show()
        {
            StaticDemo.Demo();

            StaticDemo.Demo();
        }
    }

    // we cannot inherit from another class or implement an interface
    // Will cause tight coupling
    public static class StaticDemo2
    {
        public static int MyProperty { get; set; }

        public static void Demo()
        {
            var x = new MyClass();
            x.Show();
        }
    }

    public static  class StaticDemo
    {
        public static int MyProperty { get; set; }

        public static void Demo()
        {
            StaticDemo2.Demo();
            var x = new MyClass();
            x.Show();
        }

    }
}