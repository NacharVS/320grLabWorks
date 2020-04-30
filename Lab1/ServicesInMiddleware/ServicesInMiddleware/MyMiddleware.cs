using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesInMiddleware
{
    public class MyMiddleware
    {
        private RequestDelegate next;

        public MyMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, MyMath method)
        {
            var tokenSum = context.Request.Query["sum"];
            var tokenMultiplication = context.Request.Query["multiplication"];

            string masSum = tokenSum.ToString();
            string masMultiplication = tokenMultiplication.ToString();

            if (masSum != "")
            {
                await context.Response.WriteAsync("Sum = " + method.Sum(masSum));
            }
            else if (masMultiplication != "")
            {
                await context.Response.WriteAsync("Multiplication = " + method.Multiplication(masMultiplication));
            }
            else
            {
                await next.Invoke(context);
            }
        }
    }
}
