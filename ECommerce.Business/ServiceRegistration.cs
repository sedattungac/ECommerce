using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationService, ApplicationManager>();
            services.AddScoped<IDepartmentService, DepartmentManager>();
            services.AddScoped<IProductCategoryService, ProductCategoryManager>();
            services.AddScoped<IProductColorService, ProductColorManager>();
            services.AddScoped<IProductCommentService, ProductCommentManager>();
            services.AddScoped<IProductImageService, ProductImageManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductSizeService, ProductSizeManager>();
            services.AddScoped<IRoleApplicationService, RoleApplicationManager>();
            services.AddScoped<IRoleService, RoleManager>();
            services.AddScoped<ITitleService, TitleManager>();
            services.AddScoped<IUserRoleService, UserRoleManager>();
            services.AddScoped<IUserService, UserManager>();
            return services;
        }
    }
}
