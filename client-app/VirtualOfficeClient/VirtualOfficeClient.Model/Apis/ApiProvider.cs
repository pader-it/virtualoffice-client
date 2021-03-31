using VirtualOffice.RestApiClient.Api;
using VirtualOffice.RestApiClient.Client;

namespace VirtualOfficeClient.Model.Apis
{
    static class ApiProvider
    {
        private static IUserManagementApi _userApi;
        private static IDefaultApi _defaultApi;

        public static IUserManagementApi UserApi => _userApi;
        public static IDefaultApi DefaultApi => _defaultApi;

        static ApiProvider()
        {
            //TODO: Need configuration values here
            string basePath = "http://localhost:8080";

            var apiConfiguration = Configuration.Default;
            apiConfiguration.BasePath = basePath;

            _defaultApi = new DefaultApi() { Configuration = apiConfiguration };
            _userApi = new UserManagementApi() { Configuration = apiConfiguration };
        }


    }
}
