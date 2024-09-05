/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
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

using Pieces.Os.Core.Client;
using Pieces.Os.Core.Api;
// uncomment below to import models
//using Pieces.Os.Core.SdkModel;

namespace Pieces.Os.Core.Test.Api
{
    /// <summary>
    ///  Class for testing AllocationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AllocationApiTests : IDisposable
    {
        private AllocationApi instance;

        public AllocationApiTests()
        {
            instance = new AllocationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AllocationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AllocationApi
            //Assert.IsType<AllocationApi>(instance);
        }

        /// <summary>
        /// Test AllocationSnapshot
        /// </summary>
        [Fact]
        public void AllocationSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string allocation = null;
            //var response = instance.AllocationSnapshot(allocation);
            //Assert.IsType<AllocationCloud>(response);
        }

        /// <summary>
        /// Test AllocationUpdate
        /// </summary>
        [Fact]
        public void AllocationUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AllocationCloud allocationCloud = null;
            //var response = instance.AllocationUpdate(allocationCloud);
            //Assert.IsType<AllocationCloud>(response);
        }
    }
}