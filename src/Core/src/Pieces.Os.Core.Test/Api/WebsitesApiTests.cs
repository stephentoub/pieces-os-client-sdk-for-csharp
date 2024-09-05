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
    ///  Class for testing WebsitesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebsitesApiTests : IDisposable
    {
        private WebsitesApi instance;

        public WebsitesApiTests()
        {
            instance = new WebsitesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebsitesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebsitesApi
            //Assert.IsType<WebsitesApi>(instance);
        }

        /// <summary>
        /// Test SearchWebsites
        /// </summary>
        [Fact]
        public void SearchWebsitesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //SearchInput searchInput = null;
            //var response = instance.SearchWebsites(transferables, searchInput);
            //Assert.IsType<SearchedWebsites>(response);
        }

        /// <summary>
        /// Test WebsitesCreateNewWebsite
        /// </summary>
        [Fact]
        public void WebsitesCreateNewWebsiteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //SeededWebsite seededWebsite = null;
            //var response = instance.WebsitesCreateNewWebsite(transferables, seededWebsite);
            //Assert.IsType<Website>(response);
        }

        /// <summary>
        /// Test WebsitesDeleteSpecificWebsite
        /// </summary>
        [Fact]
        public void WebsitesDeleteSpecificWebsiteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string website = null;
            //instance.WebsitesDeleteSpecificWebsite(website);
        }

        /// <summary>
        /// Test WebsitesExists
        /// </summary>
        [Fact]
        public void WebsitesExistsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExistentMetadata existentMetadata = null;
            //var response = instance.WebsitesExists(existentMetadata);
            //Assert.IsType<ExistingMetadata>(response);
        }

        /// <summary>
        /// Test WebsitesSnapshot
        /// </summary>
        [Fact]
        public void WebsitesSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //var response = instance.WebsitesSnapshot(transferables);
            //Assert.IsType<Websites>(response);
        }
    }
}