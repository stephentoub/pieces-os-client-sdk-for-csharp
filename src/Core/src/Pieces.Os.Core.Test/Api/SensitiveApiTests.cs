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
    ///  Class for testing SensitiveApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SensitiveApiTests : IDisposable
    {
        private SensitiveApi instance;

        public SensitiveApiTests()
        {
            instance = new SensitiveApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SensitiveApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SensitiveApi
            //Assert.IsType<SensitiveApi>(instance);
        }

        /// <summary>
        /// Test SensitiveScoresIncrement
        /// </summary>
        [Fact]
        public void SensitiveScoresIncrementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensitive = null;
            //SeededScoreIncrement seededScoreIncrement = null;
            //instance.SensitiveScoresIncrement(sensitive, seededScoreIncrement);
        }

        /// <summary>
        /// Test SensitiveSnapshot
        /// </summary>
        [Fact]
        public void SensitiveSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensitive = null;
            //var response = instance.SensitiveSnapshot(sensitive);
            //Assert.IsType<Sensitive>(response);
        }

        /// <summary>
        /// Test UpdateSensitive
        /// </summary>
        [Fact]
        public void UpdateSensitiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Sensitive sensitive = null;
            //var response = instance.UpdateSensitive(sensitive);
            //Assert.IsType<Sensitive>(response);
        }
    }
}