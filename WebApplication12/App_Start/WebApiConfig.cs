using FluentValidation.WebApi;
using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication12.App_Start;
using WebApplication12.Filters;

namespace WebApplication12
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new ValidateModelStateFilter());
            StructuremapWebApi.Start();
            FluentValidationModelValidatorProvider.Configure(config);

            
        }
    }
}
