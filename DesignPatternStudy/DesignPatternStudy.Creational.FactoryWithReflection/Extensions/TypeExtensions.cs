using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Extensions
{
    public static class TypeExtensions
    {
        public static List<Type> GetImplementations(this Type type)
        {
            return type.Assembly.GetTypes()
                .Where(implementation => !implementation.IsAbstract && typeof(ILogger).IsAssignableFrom(implementation))
                .ToList();
        }
    }
}
