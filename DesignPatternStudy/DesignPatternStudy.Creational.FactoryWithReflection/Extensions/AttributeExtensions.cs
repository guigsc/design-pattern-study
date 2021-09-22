using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Extensions
{
    public static class AttributeExtensions
    {
        public static string GetAttributeName(this Attribute attribute)
        {
            string fullAttributeName = attribute.GetType().Name;
            return fullAttributeName.Substring(0, fullAttributeName.Length - 10);
        }
    }
}
