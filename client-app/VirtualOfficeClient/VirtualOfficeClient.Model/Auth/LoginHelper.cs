using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using VirtualOffice.RestApiClient.Api;
using VirtualOffice.RestApiClient.Client;
using VirtualOfficeClient.Model.Apis;
using VirtualOfficeClient.Model.Auth.Sessions;

namespace VirtualOfficeClient.Model.Auth
{
    public class LoginHelper
    {
        private readonly static IUserManagementApi _userApi;
        
        static LoginHelper()
        {
            _userApi = ApiProvider.UserApi;
        }

        public static async Task<int> PerformLogin(string username, string password)
        {
            _userApi.Configuration.Username = username;
            _userApi.Configuration.Password = password;

            try
            {
                var response = await _userApi.LoginAsyncWithHttpInfo();

                if(response.StatusCode == 200)
                {
                    var token = ((JObject)response.Data).Value<string>("token");
                    var session = SessionFactory.BuildSession(token, username);
                    AuthContext.Instance.RegisterActiveSession(session);
                }

                return response.StatusCode;
            }
            catch (ApiException apiX)
            {
                return apiX.ErrorCode;
            }
        }
    }
}
