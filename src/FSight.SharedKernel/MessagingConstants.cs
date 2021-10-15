namespace FSight.SharedKernel
{
    public static class MessagingConstants
    {
        // can be overridden later with config values but serve as defaults otherwise.
        public static class Credentials
        {
            public const string DEFAULT_USERNAME = "guest";
            public const string DEFAULT_PASSWORD = "guest";
        }
        
        // TODO: Exchanges & Queues once these are defined.

        public static class NetworkConfig
        {
            public const int DEFAULT_PORT = 5672;
            public const string DEFAULT_VIRTUAL_HOST = "/";
        }
    }
}