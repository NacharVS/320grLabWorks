
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingIdAndBlaBla
{
    public static class UsingPusingMiddleware
    {
        // Вызываем нами созданный элемент конвеера
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, 
            int minId, int maxId)
        {
            return builder.UseMiddleware<NewMiddleware>(minId, maxId);
        }
    }
}
