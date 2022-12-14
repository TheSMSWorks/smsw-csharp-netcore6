/*
 * The SMS Works API
 *
 * The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed messages are refunded.
 *
 * The version of the OpenAPI document: 1.7.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing BatchMessagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BatchMessagesApiTests : IDisposable
    {
        private BatchMessagesApi instance;

        public BatchMessagesApiTests()
        {
            instance = new BatchMessagesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BatchMessagesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BatchMessagesApi
            //Assert.IsType<BatchMessagesApi>(instance);
        }

        /// <summary>
        /// Test CancelScheduledBatchJob
        /// </summary>
        [Fact]
        public void CancelScheduledBatchJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchid = null;
            //var response = instance.CancelScheduledBatchJob(batchid);
            //Assert.IsType<CancelledMessageResponse>(response);
        }

        /// <summary>
        /// Test GetBatchById
        /// </summary>
        [Fact]
        public void GetBatchByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchid = null;
            //var response = instance.GetBatchById(batchid);
            //Assert.IsType<List<MessageResponse>>(response);
        }

        /// <summary>
        /// Test ScheduleBatch
        /// </summary>
        [Fact]
        public void ScheduleBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchMessage smsMessage = null;
            //var response = instance.ScheduleBatch(smsMessage);
            //Assert.IsType<ScheduledBatchResponse>(response);
        }

        /// <summary>
        /// Test SendAny
        /// </summary>
        [Fact]
        public void SendAnyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<Message> messages = null;
            //var response = instance.SendAny(messages);
            //Assert.IsType<BatchMessageResponse>(response);
        }

        /// <summary>
        /// Test SendBatch
        /// </summary>
        [Fact]
        public void SendBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchMessage smsMessage = null;
            //var response = instance.SendBatch(smsMessage);
            //Assert.IsType<BatchMessageResponse>(response);
        }
    }
}
