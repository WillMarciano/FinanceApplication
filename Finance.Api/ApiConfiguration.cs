namespace Finance.Api
{
    public static class ApiConfiguration
    {
        public const string UserId = "Admin";
        public static string ConnectionString { get; set; } = string.Empty;
        public static string CorsPolicyName = "wasm";
    }
}
