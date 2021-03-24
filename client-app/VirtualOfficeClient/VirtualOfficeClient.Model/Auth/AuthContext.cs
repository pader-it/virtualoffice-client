using VirtualOfficeClient.Model.Auth.Sessions;

namespace VirtualOfficeClient.Model.Auth
{
    public class AuthContext
    {

        private static AuthContext _instance;

        public static AuthContext Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AuthContext();
                return _instance;
            }
        }

        public UserSession ActiveSession { get; private set; }


        private AuthContext()
        {

        }

        public void RegisterActiveSession(UserSession session)
        {
            if (this.ActiveSession != null)
                this.ActiveSession.Deactivate();

            session.Activate();
            this.ActiveSession = session;
        }

        public bool HasActiveSession()
        {
            return this.ActiveSession != null && this.ActiveSession.IsActive;
        }

        public void RevokeActiveSession()
        {
            if(this.ActiveSession != null)
            {
                this.ActiveSession.Deactivate();
            }

            this.ActiveSession = null;
        }



    }
}
