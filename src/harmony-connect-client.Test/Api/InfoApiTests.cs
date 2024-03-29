/* 
 * Harmony Connect
 *
 * An easy to use API that helps you access the Factom blockchain.
 *
 * OpenAPI spec version: 1.0.19
 * Contact: harmony-support@factom.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using harmony-connect-client.Client;
using harmony-connect-client.Api;
using harmony-connect-client.Model;

namespace harmony-connect-client.Test
{
    /// <summary>
    ///  Class for testing InfoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InfoApiTests
    {
        private InfoApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InfoApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InfoApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InfoApi
            //Assert.IsInstanceOfType(typeof(InfoApi), instance, "instance is a InfoApi");
        }

        
        /// <summary>
        /// Test GetApiInfo
        /// </summary>
        [Test]
        public void GetApiInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetApiInfo();
            //Assert.IsInstanceOf<AllInfo> (response, "response is AllInfo");
        }
        
    }

}
