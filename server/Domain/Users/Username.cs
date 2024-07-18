namespace Domain.Users
{
    public partial record Username
    {
        public string Value { get; }

        public Username(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Username cannot be empty", nameof(value));
            if (value.Length < 3 || value.Length > 20)
                throw new ArgumentException("Username must be between 3 and 20 characters", nameof(value));
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, "^[a-zA-Z0-9_]+$"))
                throw new ArgumentException("Username can only contain alphanumeric characters and underscores", nameof(value));

            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
