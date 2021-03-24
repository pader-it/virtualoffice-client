namespace VirtualOfficeClient.Model.Auth.Sessions
{
    public static class SessionFactory
    {
        public static UserSession BuildSession(string token, string userName)
        {
            return new UserSession(token, userName);
        }
    }
}
