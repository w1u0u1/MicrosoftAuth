using Newtonsoft.Json;
using System;

namespace MicrosoftAuth
{
    class AuthResponse
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string clientId { get; set; }
        public string secret { get; set; }
        public string expires_in { get; set; }
        public DateTime created { get; set; }

        public static AuthResponse GetResponse(string response)
        {
            AuthResponse result = JsonConvert.DeserializeObject<AuthResponse>(response);
            result.created = DateTime.Now;
            return result;
        }
    }
}