// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represents the properties of an Azure SQL Database Elastic Pool.
    /// </summary>
    public partial class ElasticPoolActivityProperties
    {
        private string _elasticPoolName;
        
        /// <summary>
        /// Optional. Gets the name of the Elastic Pool.
        /// </summary>
        public string ElasticPoolName
        {
            get { return this._elasticPoolName; }
            set { this._elasticPoolName = value; }
        }
        
        private System.DateTime? _endTime;
        
        /// <summary>
        /// Optional. Gets the time the operation finished.
        /// </summary>
        public System.DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private int? _errorCode;
        
        /// <summary>
        /// Optional. Gets the error code if available.
        /// </summary>
        public int? ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Gets the error message if available.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private int? _errorSeverity;
        
        /// <summary>
        /// Optional. Gets the error severity if available.
        /// </summary>
        public int? ErrorSeverity
        {
            get { return this._errorSeverity; }
            set { this._errorSeverity = value; }
        }
        
        private string _operation;
        
        /// <summary>
        /// Optional. Gets the operation name.
        /// </summary>
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }
        
        private Guid _operationId;
        
        /// <summary>
        /// Optional. Gets the unique operation ID.
        /// </summary>
        public Guid OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }
        
        private int? _percentComplete;
        
        /// <summary>
        /// Optional. Gets the percentage complete if available.
        /// </summary>
        public int? PercentComplete
        {
            get { return this._percentComplete; }
            set { this._percentComplete = value; }
        }
        
        private int? _requestedDatabaseDtuMax;
        
        /// <summary>
        /// Optional. Gets the requested max DTU per database if available.
        /// </summary>
        public int? RequestedDatabaseDtuMax
        {
            get { return this._requestedDatabaseDtuMax; }
            set { this._requestedDatabaseDtuMax = value; }
        }
        
        private int? _requestedDatabaseDtuMin;
        
        /// <summary>
        /// Optional. Gets the requested min DTU per database if available.
        /// </summary>
        public int? RequestedDatabaseDtuMin
        {
            get { return this._requestedDatabaseDtuMin; }
            set { this._requestedDatabaseDtuMin = value; }
        }
        
        private int? _requestedDtu;
        
        /// <summary>
        /// Optional. Gets the requested DTU for the pool if available.
        /// </summary>
        public int? RequestedDtu
        {
            get { return this._requestedDtu; }
            set { this._requestedDtu = value; }
        }
        
        private string _requestedElasticPoolName;
        
        /// <summary>
        /// Optional. Gets the requested name for the Elastic Pool if available.
        /// </summary>
        public string RequestedElasticPoolName
        {
            get { return this._requestedElasticPoolName; }
            set { this._requestedElasticPoolName = value; }
        }
        
        private long? _requestedStorageLimitInGB;
        
        /// <summary>
        /// Optional. Gets the requested storage limit for the pool in GB if
        /// available.
        /// </summary>
        public long? RequestedStorageLimitInGB
        {
            get { return this._requestedStorageLimitInGB; }
            set { this._requestedStorageLimitInGB = value; }
        }
        
        private string _serverName;
        
        /// <summary>
        /// Optional. Gets the name of the Azure Sql Database Server the
        /// Elastic Pool is in.
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }
        
        private System.DateTime? _startTime;
        
        /// <summary>
        /// Optional. Gets the time the operation started.
        /// </summary>
        public System.DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. Gets the current state of the operation.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ElasticPoolActivityProperties
        /// class.
        /// </summary>
        public ElasticPoolActivityProperties()
        {
        }
    }
}