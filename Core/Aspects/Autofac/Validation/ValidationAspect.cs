using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType) // Atribute tipini al
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType)) // Validator değilse
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil.");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            // Instance oluştur
            var validator = (IValidator)Activator.CreateInstance(_validatorType); // Reflection var, Çalışma anında bir şeyleri çalıştırma, newleme yapar reflection
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; // Çalışma tipini bul. Veri tipini bul (Örneğin Car) AbstractValidator<Car> -> GetGenericArguments
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); // Parametrelerini bul ilgili methodun örneğin adddeki car parametresi
            // invocation ->  method demek
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
