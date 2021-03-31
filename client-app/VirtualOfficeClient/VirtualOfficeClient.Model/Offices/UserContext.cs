using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualOffice.RestApiClient.Api;
using VirtualOfficeClient.Model.Apis;
using VirtualOfficeClient.Model.Auth;

namespace VirtualOfficeClient.Model.Offices
{
    public class UserContext
    {
        private readonly AuthContext _authContext = AuthContext.Instance;

        private readonly IDefaultApi _apiInstance = ApiProvider.DefaultApi;

        public long? CurrentOfficeId { get; private set;}

        public List<string> CurrentTaskIds { get; private set; }

        public UserContext()
        {
            this.CurrentOfficeId = null;
            this.CurrentTaskIds = new List<string>();
            this._apiInstance = new DefaultApi();
        }

        public async Task<bool> EnterOffice(long officeId)
        {
            EnsureValidSession();

            if (this.CurrentOfficeId != null)
                return false;

            var response = await this._apiInstance.EnterOfficeAsyncWithHttpInfo(officeId);

            //TODO: Might want to print failures here...

            if (response.StatusCode == 200)
                this.CurrentOfficeId = officeId;

            return response.StatusCode == 200;
        }

        public async Task<bool> LeaveCurrentOffice()
        {
            EnsureValidSession();

            if (this.CurrentOfficeId == null)
                return false;

            var response = await this._apiInstance.LeaveOfficeAsyncWithHttpInfo(this.CurrentOfficeId);

            if (response.StatusCode == 200)
                this.CurrentOfficeId = null;


            return response.StatusCode == 200;
        }


        private void EnsureValidSession()
        {
            if (!this._authContext.HasActiveSession())
                throw new System.Exception("No active Session!");

            this._apiInstance.Configuration.AddApiKeyPrefix("USER-TOKEN", this._authContext.ActiveSession.AccessToken);

            //this._apiInstance.Configuration.AccessToken = this._authContext.ActiveSession.AccessToken;
        }
    }
}
