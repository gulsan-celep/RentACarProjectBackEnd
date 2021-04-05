using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;
using Business.Constants;

namespace Business.BusinessAspects.Autofac
{
    // JWT [SecuredOperation] classların üzerine yazdığımız attributü burada nasıl oluşturduğumuzu yazarız business da
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        // JWT göndererek yaptığımız istekde, her bir istek için httpcontexti oluşturur(thread oluşturur)
        private IHttpContextAccessor _httpContextAccessor;

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            //injection değerlerini alır
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            // Eğer yetkisi yoksa exeption fırlat demek. Adamın yetkisi var mı onu kontrol eder.
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
