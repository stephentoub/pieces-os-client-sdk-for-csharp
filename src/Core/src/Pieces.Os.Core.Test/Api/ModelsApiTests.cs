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
    ///  Class for testing ModelsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ModelsApiTests : IDisposable
    {
        private ModelsApi instance;

        public ModelsApiTests()
        {
            instance = new ModelsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModelsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ModelsApi
            //Assert.IsType<ModelsApi>(instance);
        }

        /// <summary>
        /// Test ModelsCreateNewModel
        /// </summary>
        [Fact]
        public void ModelsCreateNewModelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SeededModel seededModel = null;
            //var response = instance.ModelsCreateNewModel(seededModel);
            //Assert.IsType<Model>(response);
        }

        /// <summary>
        /// Test ModelsDeleteSpecificModel
        /// </summary>
        [Fact]
        public void ModelsDeleteSpecificModelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string model = null;
            //instance.ModelsDeleteSpecificModel(model);
        }

        /// <summary>
        /// Test ModelsDeleteSpecificModelCache
        /// </summary>
        [Fact]
        public void ModelsDeleteSpecificModelCacheTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string model = null;
            //ModelDeleteCacheInput modelDeleteCacheInput = null;
            //var response = instance.ModelsDeleteSpecificModelCache(model, modelDeleteCacheInput);
            //Assert.IsType<ModelDeleteCacheOutput>(response);
        }

        /// <summary>
        /// Test ModelsSnapshot
        /// </summary>
        [Fact]
        public void ModelsSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ModelsSnapshot();
            //Assert.IsType<Models>(response);
        }

        /// <summary>
        /// Test UnloadModels
        /// </summary>
        [Fact]
        public void UnloadModelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.UnloadModels();
        }
    }
}