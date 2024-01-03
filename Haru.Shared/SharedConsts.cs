namespace Haru.Shared
{
    public class SharedConsts
    {
        public const string Address = "localhost:8000";
        public const string AccountId = "409154";
        public const string GameVersion = "0.13.5.0.28500";

        public static readonly string HttpAddress;
        public static readonly string WsAddress;

        static SharedConsts()
        {
            HttpAddress = $"https://{Address}";
            WsAddress = $"wss://{Address}";
        }
    }
}