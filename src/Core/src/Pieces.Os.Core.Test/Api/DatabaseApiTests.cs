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
    ///  Class for testing DatabaseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DatabaseApiTests : IDisposable
    {
        private DatabaseApi instance;

        public DatabaseApiTests()
        {
            instance = new DatabaseApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatabaseApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DatabaseApi
            //Assert.IsType<DatabaseApi>(instance);
        }

        /// <summary>
        /// Test DatabaseExport
        /// </summary>
        [Fact]
        public void DatabaseExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DatabaseExport();
            //Assert.IsType<ExportedDatabase>(response);
        }

        /// <summary>
        /// Test DatabaseImport
        /// </summary>
        [Fact]
        public void DatabaseImportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExportedDatabase exportedDatabase = null;
            //instance.DatabaseImport(exportedDatabase);
        }
    }
}