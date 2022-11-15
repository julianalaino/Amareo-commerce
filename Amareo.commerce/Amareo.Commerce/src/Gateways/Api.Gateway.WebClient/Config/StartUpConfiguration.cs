﻿using Api.Gateway.Proxies;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Gateway.WebClient.Config
{
    public static class StartUpConfiguration
    {
        public static IServiceCollection AddAppsettingBinding(this IServiceCollection service, IConfiguration configuration)
        {
            service.Configure<ApiUrls>(opts => configuration.GetSection("ApiUrls"));
            return service;
            
        } 

        public static IServiceCollection AddProxiesRegistration(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddHttpContextAccessor();
            service.AddHttpClient<IOrderProxy, OrderProxy>();
            service.AddHttpClient<ICatalogProxy, CatalogProxy>();
            service.AddHttpClient<ICustomerProxy, CustomerProxy>();

            return service;
        }
    }
}
