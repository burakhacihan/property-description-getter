using PropertyDescriptionGetter;

var properties = PropertyDescriptionHelper.GetAll<User>();

foreach (var property in properties)
    Console.WriteLine($"{property.Item1}: {property.Item2}");

var userNamePropertyDescription = PropertyDescriptionHelper.GetByPropertyName<User>(nameof(User.UserName));
Console.WriteLine("UserName Description: " + userNamePropertyDescription);