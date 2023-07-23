# Property Description Attribute Value Getter
You can get any class any property get the description attribute value.

Along with the helper, you can retrieve all attribute descriptions within the class or individual attribute description values.

## How to Get All Property Description
I made an example User class. I have included this project. You can find the user class under the models directory.
```csharp
var properties = PropertyDescriptionHelper.GetAll<User>();

foreach (var property in properties)
    Console.WriteLine($"{property.Item1}: {property.Item2}");
```

### How to Get By Property Name
```csharp
var userNamePropertyDescription = PropertyDescriptionHelper.GetByPropertyName<User>(nameof(User.UserName));

Console.WriteLine("UserName Description: " + userNamePropertyDescription);
```