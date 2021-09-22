using DesignPatternStudy.Creational.FactoryWithReflection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Extensions
{
    public static class TypeExtensions
    {
        private const string ComparisonPropertyNotFound = "Comparison property does not exist on attribute class";

        public static List<Type> GetImplementations<T>(this Type type)
        {
            return type.Assembly.GetTypes()
                .Where(implementation => !implementation.IsAbstract && typeof(T).IsAssignableFrom(implementation))
                .ToList();
        }

        public static bool HasCustomAttribute<T>(this Type type, string loggerMedium) where T : Attribute
        {
            T attribute = (T)type.GetCustomAttributes(typeof(T), false).FirstOrDefault();
            if (attribute == null) return false;

            var attributeName = attribute.GetAttributeName();

            var attributeProperty = attribute.GetType().GetProperty(attributeName);
            if (attributeProperty == null)
                throw new ArgumentException(ComparisonPropertyNotFound);

            return string.Compare(attributeProperty.GetValue(attribute).ToString(), loggerMedium, true) == 0;
        }
    }
}
