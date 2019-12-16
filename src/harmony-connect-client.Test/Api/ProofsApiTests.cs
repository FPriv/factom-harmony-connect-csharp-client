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
    ///  Class for testing ProofsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProofsApiTests
    {
        private ProofsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProofsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProofsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProofsApi
            //Assert.IsInstanceOfType(typeof(ProofsApi), instance, "instance is a ProofsApi");
        }

        
        /// <summary>
        /// Test GetAnchorbySearch
        /// </summary>
        [Test]
        public void GetAnchorbySearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectId = null;
            //var response = instance.GetAnchorbySearch(objectId);
            //Assert.IsInstanceOf<AnchorLong> (response, "response is AnchorLong");
        }
        
        /// <summary>
        /// Test GetReceiptsbyEntry
        /// </summary>
        [Test]
        public void GetReceiptsbyEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entryHash = null;
            //var response = instance.GetReceiptsbyEntry(entryHash);
            //Assert.IsInstanceOf<ReceiptLong> (response, "response is ReceiptLong");
        }
        
        /// <summary>
        /// Test GetSearch
        /// </summary>
        [Test]
        public void GetSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string term = null;
            //string allowedStages = null;
            //var response = instance.GetSearch(term, allowedStages);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
    }

}