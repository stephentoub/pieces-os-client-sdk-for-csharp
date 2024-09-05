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
    ///  Class for testing BackupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BackupApiTests : IDisposable
    {
        private BackupApi instance;

        public BackupApiTests()
        {
            instance = new BackupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BackupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BackupApi
            //Assert.IsType<BackupApi>(instance);
        }

        /// <summary>
        /// Test Backup
        /// </summary>
        [Fact]
        public void BackupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Assets assets = null;
            //instance.Backup(assets);
        }

        /// <summary>
        /// Test BackupAsset
        /// </summary>
        [Fact]
        public void BackupAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Asset asset = null;
            //instance.BackupAsset(asset);
        }

        /// <summary>
        /// Test BackupRestoreSpecificBackup
        /// </summary>
        [Fact]
        public void BackupRestoreSpecificBackupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string backup = null;
            //Backup backup2 = null;
            //var response = instance.BackupRestoreSpecificBackup(backup, backup2);
            //Assert.IsType<Backup>(response);
        }

        /// <summary>
        /// Test BackupRestoreSpecificBackupStreamed
        /// </summary>
        [Fact]
        public void BackupRestoreSpecificBackupStreamedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string backup = null;
            //Backup backup2 = null;
            //var response = instance.BackupRestoreSpecificBackupStreamed(backup, backup2);
            //Assert.IsType<BackupStreamedProgress>(response);
        }

        /// <summary>
        /// Test BackupSpecificBackupSnapshot
        /// </summary>
        [Fact]
        public void BackupSpecificBackupSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string backup = null;
            //var response = instance.BackupSpecificBackupSnapshot(backup);
            //Assert.IsType<Backup>(response);
        }

        /// <summary>
        /// Test BackupSpecificCreationCancel
        /// </summary>
        [Fact]
        public void BackupSpecificCreationCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string backup = null;
            //instance.BackupSpecificCreationCancel(backup);
        }

        /// <summary>
        /// Test BackupSpecificCreationStatus
        /// </summary>
        [Fact]
        public void BackupSpecificCreationStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string backup = null;
            //var response = instance.BackupSpecificCreationStatus(backup);
            //Assert.IsType<BackupStatus>(response);
        }

        /// <summary>
        /// Test BackupSpecificRestorationCancel
        /// </summary>
        [Fact]
        public void BackupSpecificRestorationCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string backup = null;
            //Backup backup2 = null;
            //instance.BackupSpecificRestorationCancel(backup, backup2);
        }

        /// <summary>
        /// Test BackupSpecificRestorationStatus
        /// </summary>
        [Fact]
        public void BackupSpecificRestorationStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string backup = null;
            //var response = instance.BackupSpecificRestorationStatus(backup);
            //Assert.IsType<BackupStatus>(response);
        }
    }
}