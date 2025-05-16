﻿using YouTubeApiCleanArchitecture.API.Middlewares;

namespace YouTubeApiCleanArchitecture.API.Extensions;

public static class ApplicationBuilderExtensions
{
    public static void UseCustomExceptionHandler(this IApplicationBuilder app) =>
        app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

    public static void UseRequestContextLogging(this IApplicationBuilder app) =>
       app.UseMiddleware<RequestContextLoggingMiddleware>();

}