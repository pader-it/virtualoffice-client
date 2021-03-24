using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualOfficeClient.Model.Auth;

namespace VirtualOfficeClient.Model.Offices
{
    public class UserContext
    {
        private readonly AuthContext _authContext = AuthContext.Instance;

        public string CurrentOfficeId { get; private set;}

        public List<string> CurrentTaskIds { get; private set; }

        public UserContext()
        {
            this.CurrentOfficeId = null;
            this.CurrentTaskIds = new List<string>();
        }

        public async Task<bool> enterOffice(string officeId)
        {
            EnsureValidSession();

            if (this.CurrentOfficeId != null)
                return false;

            return true;
        }

        public async Task<bool> leaveCurrentOffice()
        {
            EnsureValidSession();

            if (this.CurrentOfficeId == null)
                return false;

            return true;
        }


        private void EnsureValidSession()
        {
            if (!this._authContext.HasActiveSession())
                throw new System.Exception("No active Session!");
        }
    }
}
