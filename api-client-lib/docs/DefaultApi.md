# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTask**](DefaultApi.md#createtask) | **POST** /office/{officeId}/tasks | 
[**EndTask**](DefaultApi.md#endtask) | **POST** /office/{officeId}/tasks/{taskId}/end | 
[**EnterOffice**](DefaultApi.md#enteroffice) | **POST** /office/{officeId}/enter | 
[**GetTasks**](DefaultApi.md#gettasks) | **GET** /office/{officeId}/tasks | 
[**LeaveOffice**](DefaultApi.md#leaveoffice) | **POST** /office/{officeId}/leave | 
[**StartTask**](DefaultApi.md#starttask) | **POST** /office/{officeId}/tasks/{taskId}/start | 


<a name="createtask"></a>
# **CreateTask**
> long? CreateTask (long? officeId, Task task)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTaskExample
    {
        public void main()
        {
            // Configure API key authorization: headerAuth
            Configuration.Default.AddApiKey("USER-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("USER-TOKEN", "Bearer");

            var apiInstance = new DefaultApi();
            var officeId = 789;  // long? | Id of the office
            var task = new Task(); // Task | Task to create

            try
            {
                long? result = apiInstance.CreateTask(officeId, task);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **officeId** | **long?**| Id of the office | 
 **task** | [**Task**](Task.md)| Task to create | 

### Return type

**long?**

### Authorization

[headerAuth](../README.md#headerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endtask"></a>
# **EndTask**
> void EndTask (long? officeId, long? taskId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EndTaskExample
    {
        public void main()
        {
            // Configure API key authorization: headerAuth
            Configuration.Default.AddApiKey("USER-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("USER-TOKEN", "Bearer");

            var apiInstance = new DefaultApi();
            var officeId = 789;  // long? | Id of the office
            var taskId = 789;  // long? | Id of the Task

            try
            {
                apiInstance.EndTask(officeId, taskId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EndTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **officeId** | **long?**| Id of the office | 
 **taskId** | **long?**| Id of the Task | 

### Return type

void (empty response body)

### Authorization

[headerAuth](../README.md#headerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enteroffice"></a>
# **EnterOffice**
> void EnterOffice (long? officeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnterOfficeExample
    {
        public void main()
        {
            // Configure API key authorization: headerAuth
            Configuration.Default.AddApiKey("USER-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("USER-TOKEN", "Bearer");

            var apiInstance = new DefaultApi();
            var officeId = 789;  // long? | Id of the office

            try
            {
                apiInstance.EnterOffice(officeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EnterOffice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **officeId** | **long?**| Id of the office | 

### Return type

void (empty response body)

### Authorization

[headerAuth](../README.md#headerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasks"></a>
# **GetTasks**
> List<Task> GetTasks (long? officeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTasksExample
    {
        public void main()
        {
            // Configure API key authorization: headerAuth
            Configuration.Default.AddApiKey("USER-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("USER-TOKEN", "Bearer");

            var apiInstance = new DefaultApi();
            var officeId = 789;  // long? | Id of the office

            try
            {
                List&lt;Task&gt; result = apiInstance.GetTasks(officeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **officeId** | **long?**| Id of the office | 

### Return type

[**List<Task>**](Task.md)

### Authorization

[headerAuth](../README.md#headerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leaveoffice"></a>
# **LeaveOffice**
> void LeaveOffice (long? officeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LeaveOfficeExample
    {
        public void main()
        {
            // Configure API key authorization: headerAuth
            Configuration.Default.AddApiKey("USER-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("USER-TOKEN", "Bearer");

            var apiInstance = new DefaultApi();
            var officeId = 789;  // long? | Id of the office

            try
            {
                apiInstance.LeaveOffice(officeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.LeaveOffice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **officeId** | **long?**| Id of the office | 

### Return type

void (empty response body)

### Authorization

[headerAuth](../README.md#headerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="starttask"></a>
# **StartTask**
> void StartTask (long? officeId, long? taskId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StartTaskExample
    {
        public void main()
        {
            // Configure API key authorization: headerAuth
            Configuration.Default.AddApiKey("USER-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("USER-TOKEN", "Bearer");

            var apiInstance = new DefaultApi();
            var officeId = 789;  // long? | Id of the office
            var taskId = 789;  // long? | Id of the Task

            try
            {
                apiInstance.StartTask(officeId, taskId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.StartTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **officeId** | **long?**| Id of the office | 
 **taskId** | **long?**| Id of the Task | 

### Return type

void (empty response body)

### Authorization

[headerAuth](../README.md#headerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

