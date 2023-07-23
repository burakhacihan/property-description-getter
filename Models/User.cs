namespace PropertyDescriptionGetter{

    using System.ComponentModel;

    public class User
    {
        [Description("This is an username property")]
        public string UserName { get; set; } = default!;

        [Description("This is an password property")]
        public string Password { get; set; } = default!;

        [Description("This is an email property")]
        public string Email { get; set; } = default!;

        [Description("This is an phone number property")]
        public string PhoneNumber { get; set; } = default!;

        [Description("This is an address property")]
        public string Address { get; set; } = default!;

        [Description("This is an city property")]
        public string City { get; set; } = default!;

        [Description("This is an country property")]
        public string Country { get; set; } = default!;

        [Description("This is an zip code property")]
        public string ZipCode { get; set; } = default!;

        [Description("This is an age property")]
        public int Age { get; set; } = default!;
    }
}