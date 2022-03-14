using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Security
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class PermissionAttribute : Attribute, IAsyncAuthorizationFilter
    {
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            var isAuthorize = false;
            var urlPath = context.HttpContext.Request.Path.HasValue ? context.HttpContext.Request.Path.Value : "";

            var configuration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            DbContextOptionsBuilder<Context> dbContextOptionsBuilder = new DbContextOptionsBuilder<Context>();
            dbContextOptionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            using Context dbContext = new Context(dbContextOptionsBuilder.Options);

            var id = context.HttpContext.Request.Cookies["UserID"];

            if (!string.IsNullOrEmpty(id))
            {
                var convertedId = Convert.ToInt32(id);

                var user = await
                    dbContext.Users
                    .Include(x => x.UserRoles)
                    .ThenInclude(x => x.Role)
                    .ThenInclude(x => x.RoleApplications)
                    .ThenInclude(x => x.Application)
                    .FirstOrDefaultAsync(x => x.UserID == convertedId);

                foreach (var userRole in user.UserRoles)
                {
                    foreach (var auth in userRole.Role.RoleApplications)
                    {
                        if (urlPath.Contains(auth.Application.ApplicationHref))
                        {
                            if (auth.IsAccessible)
                            {
                                isAuthorize = true;
                            }
                        }
                    }

                }
                if (isAuthorize)
                {
                    return;
                }
            }
            context.Result = new RedirectToActionResult("Page403", "Error", new RouteValueDictionary());
            return;
        }


    }
}
