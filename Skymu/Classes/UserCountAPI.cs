// Skymu "notelemetry" patch

using System;
using System.Threading.Tasks;

namespace Skymu.UserDirectory
{
    internal static class UserCountAPI
    {
        public static string ApiTkn = "token";
        public static event Action<int> OnUserCountUpdate;

        public static Task GenerateUID()
        {
            return Task.CompletedTask;
        }

        public static Task<bool> SetUserStatus(
            bool online,
            string dn = null,
            string user = null,
            string id = null
        )
        {
            return Task.FromResult(true);
        }

        public static Task<bool> PingServer()
        {
            return Task.FromResult(true);
        }

        public static Task ConnectWS()
        {
            return Task.CompletedTask;
        }

        public static Task SendGetCount()
        {
            return Task.CompletedTask;
        }

        public static Task CloseWS()
        {
            return Task.CompletedTask;
        }
    }
}