/* 
 * Virtual Office
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        
        /// <summary>
        /// Test CreateTask
        /// </summary>
        [Test]
        public void CreateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? officeId = null;
            //Task task = null;
            //var response = instance.CreateTask(officeId, task);
            //Assert.IsInstanceOf<long?> (response, "response is long?");
        }
        
        /// <summary>
        /// Test EndTask
        /// </summary>
        [Test]
        public void EndTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? officeId = null;
            //long? taskId = null;
            //instance.EndTask(officeId, taskId);
            
        }
        
        /// <summary>
        /// Test EnterOffice
        /// </summary>
        [Test]
        public void EnterOfficeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? officeId = null;
            //instance.EnterOffice(officeId);
            
        }
        
        /// <summary>
        /// Test GetTasks
        /// </summary>
        [Test]
        public void GetTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? officeId = null;
            //var response = instance.GetTasks(officeId);
            //Assert.IsInstanceOf<List<Task>> (response, "response is List<Task>");
        }
        
        /// <summary>
        /// Test LeaveOffice
        /// </summary>
        [Test]
        public void LeaveOfficeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? officeId = null;
            //instance.LeaveOffice(officeId);
            
        }
        
        /// <summary>
        /// Test StartTask
        /// </summary>
        [Test]
        public void StartTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? officeId = null;
            //long? taskId = null;
            //instance.StartTask(officeId, taskId);
            
        }
        
    }

}
