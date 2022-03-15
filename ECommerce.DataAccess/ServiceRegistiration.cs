using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
        {

            services.AddScoped<IApplicationDal, EfApplicationRepository>();  
            services.AddScoped<IDepartmentDal, EfDepartmentRepository>();
            services.AddScoped<IProductCategoryDal, EfProductCategoryRepository>();
            services.AddScoped<IProductColorDal, EfProductColorRepository>();
            services.AddScoped<IProductCommentDal, EfProductCommentRepository>();
            services.AddScoped<IProductImageDal, EfProductImageRepository>();
            services.AddScoped<IProductDal, EfProductRepository>();
            services.AddScoped<IProductSizeDal, EfProductSizeRepository>();
            services.AddScoped<IRoleApplicationDal, EfRoleApplicationRepository>();
            services.AddScoped<IRoleDal, EfRoleRepository>();
            services.AddScoped<ITitleDal, EfTitleRepository>();
            services.AddScoped<IUserRoleDal, EfUserRoleRepository>();
            services.AddScoped<IUserDal, EfUserRepository>();

            return services;
        }


    }
}
