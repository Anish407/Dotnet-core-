namespace WebApplication1.DI
{
    public class Demo
    {
        private readonly ISample _sample;

        public Demo(ISample sample)
        {
            _sample = sample;
        }

        public void Show()
        {
            var name = _sample.Name;
        }
    }
}
