namespace Finance.Core
{
    public static class Configuration
    {
        public const int DefaultStatusCode = 200;
        public const int DefaultPageNumber = 1;
        public const int DefaultPageSize = 25;

        public static string BackendUrl { get; set; } = "https://localhost:5201";
        public static string FrontendUrl { get; set; } = "https://localhost:4001";
    }
}
