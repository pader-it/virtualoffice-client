using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using VirtualOffice.RestApiClient.Api;
using VirtualOffice.RestApiClient.Client;

namespace VirtualOfficeClient.Model.Auth
{
    public class LoginHelper
    {
        private readonly static IUserManagementApi _userApi;
        
        static LoginHelper()
        {
            _userApi = new UserManagementApi();
            _userApi.Configuration.BasePath = "http://localhost:8080/";
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
                    //TODO: Do something with the token to store it persistently
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
