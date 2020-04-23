using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingIdAndBlaBla
{
    public class NewMiddleware
    {
        // Задаем запрос следующего элемента в конвеере
        private RequestDelegate request;

        // Диапозон айдишника
        private int minId, maxId;

        // Инициализация
        public NewMiddleware(RequestDelegate request, int minId, int maxId)
        {
            this.request = request;
            this.minId = minId;
            this.maxId = maxId;
        }

        // Метод где запрос обрабатывается
        public async Task InvokeAsync(HttpContext context)
        {
            // Ловим айдишник
            var idString = context.Request.Query["Id"];
            int id = Convert.ToInt32(idString);

            // Проверка на корректность
            if (id > maxId || id < minId)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Id is incorrect");
            }
            else
            {
                await request.Invoke(context);
            }
        }
    }
}
