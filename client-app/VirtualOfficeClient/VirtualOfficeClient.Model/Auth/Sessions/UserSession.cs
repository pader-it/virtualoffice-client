using System;

namespace VirtualOfficeClient.Model.Auth.Sessions
{
    public class UserSession
    {
        public string AccessToken { get; private set; }

        public string Username { get; private set; }

        public bool IsActive { get; private set; }

        public DateTime CreationTime { get; private set; }

        internal UserSession(string accessToken, string userName)
        {
            this.AccessToken = accessToken;
            this.Username = userName;
            this.CreationTime = DateTime.Now;
        }

        internal void Activate()
        {
            this.IsActive = true;
        }

        internal void Deactivate()
        {
            this.IsActive = false;
        }
    }
}
