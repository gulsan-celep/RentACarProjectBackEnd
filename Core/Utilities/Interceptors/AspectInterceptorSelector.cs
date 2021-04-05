using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute> //classın attributelerini oku
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)       // Methodun attributelerini oku
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);     // Bunları attributleri listeye ekle

            return classAttributes.OrderBy(x => x.Priority).ToArray();  // Önceliklendirme olarak sırala
        } 
    }
}
