namespace PropertyDescriptionGetter{
    
    using System.ComponentModel;
    using System.Reflection;

    public class PropertyDescriptionHelper
    {
        public static List<(string, string)> GetAll<T>()
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            var propertyDescriptions = new List<(string, string)>();

            foreach (var property in properties)
            {
                var descriptionAttribute = property.GetCustomAttribute<DescriptionAttribute>();
                if (descriptionAttribute is not null)
                    propertyDescriptions.Add((property.Name, descriptionAttribute.Description));
            }

            return propertyDescriptions;
        }

        public static string GetByPropertyName<T>(string propertyName)
        {
            Type type = typeof(T);
            var property = type.GetProperty(propertyName);

            if (property is null)
                throw new ArgumentException($"Property with the name '{propertyName}' not found in type '{type.FullName}'.");

            var descriptionAttribute = property.GetCustomAttribute<DescriptionAttribute>();

            if (descriptionAttribute is null)
                throw new ArgumentException($"Property with the name '{propertyName}' in type '{type.FullName}' does not have a description.");

            return descriptionAttribute.Description;
        }
    }
}