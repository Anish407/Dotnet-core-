namespace WebApplication1.MIddlewares
{
    public class ExceptionMiddleware 
    {
        private readonly RequestDelegate next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                int x = 1 + 1;
                // before next middleware is called
                await next(context);
                x = 5;
                // after the middleware is called
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
