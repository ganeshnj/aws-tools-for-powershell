/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.Inspector2;
using Amazon.Inspector2.Model;

namespace Amazon.PowerShell.Cmdlets.INS2
{
    /// <summary>
    /// Lists findings for your environment.
    /// </summary>
    [Cmdlet("Get", "INS2FindingList")]
    [OutputType("Amazon.Inspector2.Model.Finding")]
    [AWSCmdlet("Calls the Inspector2 ListFindings API operation.", Operation = new[] {"ListFindings"}, SelectReturnType = typeof(Amazon.Inspector2.Model.ListFindingsResponse))]
    [AWSCmdletOutput("Amazon.Inspector2.Model.Finding or Amazon.Inspector2.Model.ListFindingsResponse",
        "This cmdlet returns a collection of Amazon.Inspector2.Model.Finding objects.",
        "The service call response (type Amazon.Inspector2.Model.ListFindingsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetINS2FindingListCmdlet : AmazonInspector2ClientCmdlet, IExecutor
    {
        
        #region Parameter FilterCriteria_AwsAccountId
        /// <summary>
        /// <para>
        /// <para>Details of the Amazon Web Services account IDs used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_AwsAccountId { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_ComponentId
        /// <summary>
        /// <para>
        /// <para>Details of the component IDs used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_ComponentId { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_ComponentType
        /// <summary>
        /// <para>
        /// <para>Details of the component types used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_ComponentType { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_Ec2InstanceImageId
        /// <summary>
        /// <para>
        /// <para>Details of the Amazon EC2 instance image IDs used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_Ec2InstanceImageId { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_Ec2InstanceSubnetId
        /// <summary>
        /// <para>
        /// <para>Details of the Amazon EC2 instance subnet IDs used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_Ec2InstanceSubnetId { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_Ec2InstanceVpcId
        /// <summary>
        /// <para>
        /// <para>Details of the Amazon EC2 instance VPC IDs used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_Ec2InstanceVpcId { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_EcrImageArchitecture
        /// <summary>
        /// <para>
        /// <para>Details of the Amazon ECR image architecture types used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_EcrImageArchitecture { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_EcrImageHash
        /// <summary>
        /// <para>
        /// <para>Details of the Amazon ECR image hashes used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_EcrImageHash { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_EcrImagePushedAt
        /// <summary>
        /// <para>
        /// <para>Details on the Amazon ECR image push date and time used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.DateFilter[] FilterCriteria_EcrImagePushedAt { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_EcrImageRegistry
        /// <summary>
        /// <para>
        /// <para>Details on the Amazon ECR registry used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_EcrImageRegistry { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_EcrImageRepositoryName
        /// <summary>
        /// <para>
        /// <para>Details on the name of the Amazon ECR repository used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_EcrImageRepositoryName { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_EcrImageTag
        /// <summary>
        /// <para>
        /// <para>The tags attached to the Amazon ECR container image.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FilterCriteria_EcrImageTags")]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_EcrImageTag { get; set; }
        #endregion
        
        #region Parameter SortCriteria_Field
        /// <summary>
        /// <para>
        /// <para>The finding detail field by which results are sorted.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Inspector2.SortField")]
        public Amazon.Inspector2.SortField SortCriteria_Field { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_FindingArn
        /// <summary>
        /// <para>
        /// <para>Details on the finding ARNs used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_FindingArn { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_FindingStatus
        /// <summary>
        /// <para>
        /// <para>Details on the finding status types used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_FindingStatus { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_FindingType
        /// <summary>
        /// <para>
        /// <para>Details on the finding types used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_FindingType { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_FirstObservedAt
        /// <summary>
        /// <para>
        /// <para>Details on the date and time a finding was first seen used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.DateFilter[] FilterCriteria_FirstObservedAt { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_InspectorScore
        /// <summary>
        /// <para>
        /// <para>The Amazon Inspector score to filter on.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.NumberFilter[] FilterCriteria_InspectorScore { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_LastObservedAt
        /// <summary>
        /// <para>
        /// <para>Details on the date and time a finding was last seen used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.DateFilter[] FilterCriteria_LastObservedAt { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_NetworkProtocol
        /// <summary>
        /// <para>
        /// <para>Details on the ingress source addresses used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_NetworkProtocol { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_PortRange
        /// <summary>
        /// <para>
        /// <para>Details on the port ranges used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.PortRangeFilter[] FilterCriteria_PortRange { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_RelatedVulnerability
        /// <summary>
        /// <para>
        /// <para>Details on the related vulnerabilities used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FilterCriteria_RelatedVulnerabilities")]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_RelatedVulnerability { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_ResourceId
        /// <summary>
        /// <para>
        /// <para>Details on the resource IDs used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_ResourceId { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_ResourceTag
        /// <summary>
        /// <para>
        /// <para>Details on the resource tags used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FilterCriteria_ResourceTags")]
        public Amazon.Inspector2.Model.MapFilter[] FilterCriteria_ResourceTag { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_ResourceType
        /// <summary>
        /// <para>
        /// <para>Details on the resource types used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_ResourceType { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_Severity
        /// <summary>
        /// <para>
        /// <para>Details on the severity used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_Severity { get; set; }
        #endregion
        
        #region Parameter SortCriteria_SortOrder
        /// <summary>
        /// <para>
        /// <para>The order by which findings are sorted.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Inspector2.SortOrder")]
        public Amazon.Inspector2.SortOrder SortCriteria_SortOrder { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_Title
        /// <summary>
        /// <para>
        /// <para>Details on the finding title used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_Title { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_UpdatedAt
        /// <summary>
        /// <para>
        /// <para>Details on the date and time a finding was last updated at used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.DateFilter[] FilterCriteria_UpdatedAt { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_VendorSeverity
        /// <summary>
        /// <para>
        /// <para>Details on the vendor severity used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_VendorSeverity { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_VulnerabilityId
        /// <summary>
        /// <para>
        /// <para>Details on the vulnerability ID used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_VulnerabilityId { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_VulnerabilitySource
        /// <summary>
        /// <para>
        /// <para>Details on the vulnerability type used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.Inspector2.Model.StringFilter[] FilterCriteria_VulnerabilitySource { get; set; }
        #endregion
        
        #region Parameter FilterCriteria_VulnerablePackage
        /// <summary>
        /// <para>
        /// <para>Details on the vulnerable packages used to filter findings.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FilterCriteria_VulnerablePackages")]
        public Amazon.Inspector2.Model.PackageFilter[] FilterCriteria_VulnerablePackage { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The maximum number of results to return in the response.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>A token to use for paginating results that are returned in the response. Set the value
        /// of this parameter to null for the first request to a list action. For subsequent calls,
        /// use the <code>NextToken</code> value returned from the previous request to continue
        /// listing results after the first page.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Findings'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Inspector2.Model.ListFindingsResponse).
        /// Specifying the name of a property of type Amazon.Inspector2.Model.ListFindingsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Findings";
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Inspector2.Model.ListFindingsResponse, GetINS2FindingListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            if (this.FilterCriteria_AwsAccountId != null)
            {
                context.FilterCriteria_AwsAccountId = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_AwsAccountId);
            }
            if (this.FilterCriteria_ComponentId != null)
            {
                context.FilterCriteria_ComponentId = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_ComponentId);
            }
            if (this.FilterCriteria_ComponentType != null)
            {
                context.FilterCriteria_ComponentType = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_ComponentType);
            }
            if (this.FilterCriteria_Ec2InstanceImageId != null)
            {
                context.FilterCriteria_Ec2InstanceImageId = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_Ec2InstanceImageId);
            }
            if (this.FilterCriteria_Ec2InstanceSubnetId != null)
            {
                context.FilterCriteria_Ec2InstanceSubnetId = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_Ec2InstanceSubnetId);
            }
            if (this.FilterCriteria_Ec2InstanceVpcId != null)
            {
                context.FilterCriteria_Ec2InstanceVpcId = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_Ec2InstanceVpcId);
            }
            if (this.FilterCriteria_EcrImageArchitecture != null)
            {
                context.FilterCriteria_EcrImageArchitecture = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_EcrImageArchitecture);
            }
            if (this.FilterCriteria_EcrImageHash != null)
            {
                context.FilterCriteria_EcrImageHash = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_EcrImageHash);
            }
            if (this.FilterCriteria_EcrImagePushedAt != null)
            {
                context.FilterCriteria_EcrImagePushedAt = new List<Amazon.Inspector2.Model.DateFilter>(this.FilterCriteria_EcrImagePushedAt);
            }
            if (this.FilterCriteria_EcrImageRegistry != null)
            {
                context.FilterCriteria_EcrImageRegistry = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_EcrImageRegistry);
            }
            if (this.FilterCriteria_EcrImageRepositoryName != null)
            {
                context.FilterCriteria_EcrImageRepositoryName = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_EcrImageRepositoryName);
            }
            if (this.FilterCriteria_EcrImageTag != null)
            {
                context.FilterCriteria_EcrImageTag = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_EcrImageTag);
            }
            if (this.FilterCriteria_FindingArn != null)
            {
                context.FilterCriteria_FindingArn = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_FindingArn);
            }
            if (this.FilterCriteria_FindingStatus != null)
            {
                context.FilterCriteria_FindingStatus = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_FindingStatus);
            }
            if (this.FilterCriteria_FindingType != null)
            {
                context.FilterCriteria_FindingType = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_FindingType);
            }
            if (this.FilterCriteria_FirstObservedAt != null)
            {
                context.FilterCriteria_FirstObservedAt = new List<Amazon.Inspector2.Model.DateFilter>(this.FilterCriteria_FirstObservedAt);
            }
            if (this.FilterCriteria_InspectorScore != null)
            {
                context.FilterCriteria_InspectorScore = new List<Amazon.Inspector2.Model.NumberFilter>(this.FilterCriteria_InspectorScore);
            }
            if (this.FilterCriteria_LastObservedAt != null)
            {
                context.FilterCriteria_LastObservedAt = new List<Amazon.Inspector2.Model.DateFilter>(this.FilterCriteria_LastObservedAt);
            }
            if (this.FilterCriteria_NetworkProtocol != null)
            {
                context.FilterCriteria_NetworkProtocol = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_NetworkProtocol);
            }
            if (this.FilterCriteria_PortRange != null)
            {
                context.FilterCriteria_PortRange = new List<Amazon.Inspector2.Model.PortRangeFilter>(this.FilterCriteria_PortRange);
            }
            if (this.FilterCriteria_RelatedVulnerability != null)
            {
                context.FilterCriteria_RelatedVulnerability = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_RelatedVulnerability);
            }
            if (this.FilterCriteria_ResourceId != null)
            {
                context.FilterCriteria_ResourceId = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_ResourceId);
            }
            if (this.FilterCriteria_ResourceTag != null)
            {
                context.FilterCriteria_ResourceTag = new List<Amazon.Inspector2.Model.MapFilter>(this.FilterCriteria_ResourceTag);
            }
            if (this.FilterCriteria_ResourceType != null)
            {
                context.FilterCriteria_ResourceType = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_ResourceType);
            }
            if (this.FilterCriteria_Severity != null)
            {
                context.FilterCriteria_Severity = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_Severity);
            }
            if (this.FilterCriteria_Title != null)
            {
                context.FilterCriteria_Title = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_Title);
            }
            if (this.FilterCriteria_UpdatedAt != null)
            {
                context.FilterCriteria_UpdatedAt = new List<Amazon.Inspector2.Model.DateFilter>(this.FilterCriteria_UpdatedAt);
            }
            if (this.FilterCriteria_VendorSeverity != null)
            {
                context.FilterCriteria_VendorSeverity = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_VendorSeverity);
            }
            if (this.FilterCriteria_VulnerabilityId != null)
            {
                context.FilterCriteria_VulnerabilityId = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_VulnerabilityId);
            }
            if (this.FilterCriteria_VulnerabilitySource != null)
            {
                context.FilterCriteria_VulnerabilitySource = new List<Amazon.Inspector2.Model.StringFilter>(this.FilterCriteria_VulnerabilitySource);
            }
            if (this.FilterCriteria_VulnerablePackage != null)
            {
                context.FilterCriteria_VulnerablePackage = new List<Amazon.Inspector2.Model.PackageFilter>(this.FilterCriteria_VulnerablePackage);
            }
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            context.SortCriteria_Field = this.SortCriteria_Field;
            context.SortCriteria_SortOrder = this.SortCriteria_SortOrder;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.Inspector2.Model.ListFindingsRequest();
            
            
             // populate FilterCriteria
            var requestFilterCriteriaIsNull = true;
            request.FilterCriteria = new Amazon.Inspector2.Model.FilterCriteria();
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_AwsAccountId = null;
            if (cmdletContext.FilterCriteria_AwsAccountId != null)
            {
                requestFilterCriteria_filterCriteria_AwsAccountId = cmdletContext.FilterCriteria_AwsAccountId;
            }
            if (requestFilterCriteria_filterCriteria_AwsAccountId != null)
            {
                request.FilterCriteria.AwsAccountId = requestFilterCriteria_filterCriteria_AwsAccountId;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_ComponentId = null;
            if (cmdletContext.FilterCriteria_ComponentId != null)
            {
                requestFilterCriteria_filterCriteria_ComponentId = cmdletContext.FilterCriteria_ComponentId;
            }
            if (requestFilterCriteria_filterCriteria_ComponentId != null)
            {
                request.FilterCriteria.ComponentId = requestFilterCriteria_filterCriteria_ComponentId;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_ComponentType = null;
            if (cmdletContext.FilterCriteria_ComponentType != null)
            {
                requestFilterCriteria_filterCriteria_ComponentType = cmdletContext.FilterCriteria_ComponentType;
            }
            if (requestFilterCriteria_filterCriteria_ComponentType != null)
            {
                request.FilterCriteria.ComponentType = requestFilterCriteria_filterCriteria_ComponentType;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_Ec2InstanceImageId = null;
            if (cmdletContext.FilterCriteria_Ec2InstanceImageId != null)
            {
                requestFilterCriteria_filterCriteria_Ec2InstanceImageId = cmdletContext.FilterCriteria_Ec2InstanceImageId;
            }
            if (requestFilterCriteria_filterCriteria_Ec2InstanceImageId != null)
            {
                request.FilterCriteria.Ec2InstanceImageId = requestFilterCriteria_filterCriteria_Ec2InstanceImageId;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_Ec2InstanceSubnetId = null;
            if (cmdletContext.FilterCriteria_Ec2InstanceSubnetId != null)
            {
                requestFilterCriteria_filterCriteria_Ec2InstanceSubnetId = cmdletContext.FilterCriteria_Ec2InstanceSubnetId;
            }
            if (requestFilterCriteria_filterCriteria_Ec2InstanceSubnetId != null)
            {
                request.FilterCriteria.Ec2InstanceSubnetId = requestFilterCriteria_filterCriteria_Ec2InstanceSubnetId;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_Ec2InstanceVpcId = null;
            if (cmdletContext.FilterCriteria_Ec2InstanceVpcId != null)
            {
                requestFilterCriteria_filterCriteria_Ec2InstanceVpcId = cmdletContext.FilterCriteria_Ec2InstanceVpcId;
            }
            if (requestFilterCriteria_filterCriteria_Ec2InstanceVpcId != null)
            {
                request.FilterCriteria.Ec2InstanceVpcId = requestFilterCriteria_filterCriteria_Ec2InstanceVpcId;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_EcrImageArchitecture = null;
            if (cmdletContext.FilterCriteria_EcrImageArchitecture != null)
            {
                requestFilterCriteria_filterCriteria_EcrImageArchitecture = cmdletContext.FilterCriteria_EcrImageArchitecture;
            }
            if (requestFilterCriteria_filterCriteria_EcrImageArchitecture != null)
            {
                request.FilterCriteria.EcrImageArchitecture = requestFilterCriteria_filterCriteria_EcrImageArchitecture;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_EcrImageHash = null;
            if (cmdletContext.FilterCriteria_EcrImageHash != null)
            {
                requestFilterCriteria_filterCriteria_EcrImageHash = cmdletContext.FilterCriteria_EcrImageHash;
            }
            if (requestFilterCriteria_filterCriteria_EcrImageHash != null)
            {
                request.FilterCriteria.EcrImageHash = requestFilterCriteria_filterCriteria_EcrImageHash;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.DateFilter> requestFilterCriteria_filterCriteria_EcrImagePushedAt = null;
            if (cmdletContext.FilterCriteria_EcrImagePushedAt != null)
            {
                requestFilterCriteria_filterCriteria_EcrImagePushedAt = cmdletContext.FilterCriteria_EcrImagePushedAt;
            }
            if (requestFilterCriteria_filterCriteria_EcrImagePushedAt != null)
            {
                request.FilterCriteria.EcrImagePushedAt = requestFilterCriteria_filterCriteria_EcrImagePushedAt;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_EcrImageRegistry = null;
            if (cmdletContext.FilterCriteria_EcrImageRegistry != null)
            {
                requestFilterCriteria_filterCriteria_EcrImageRegistry = cmdletContext.FilterCriteria_EcrImageRegistry;
            }
            if (requestFilterCriteria_filterCriteria_EcrImageRegistry != null)
            {
                request.FilterCriteria.EcrImageRegistry = requestFilterCriteria_filterCriteria_EcrImageRegistry;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_EcrImageRepositoryName = null;
            if (cmdletContext.FilterCriteria_EcrImageRepositoryName != null)
            {
                requestFilterCriteria_filterCriteria_EcrImageRepositoryName = cmdletContext.FilterCriteria_EcrImageRepositoryName;
            }
            if (requestFilterCriteria_filterCriteria_EcrImageRepositoryName != null)
            {
                request.FilterCriteria.EcrImageRepositoryName = requestFilterCriteria_filterCriteria_EcrImageRepositoryName;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_EcrImageTag = null;
            if (cmdletContext.FilterCriteria_EcrImageTag != null)
            {
                requestFilterCriteria_filterCriteria_EcrImageTag = cmdletContext.FilterCriteria_EcrImageTag;
            }
            if (requestFilterCriteria_filterCriteria_EcrImageTag != null)
            {
                request.FilterCriteria.EcrImageTags = requestFilterCriteria_filterCriteria_EcrImageTag;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_FindingArn = null;
            if (cmdletContext.FilterCriteria_FindingArn != null)
            {
                requestFilterCriteria_filterCriteria_FindingArn = cmdletContext.FilterCriteria_FindingArn;
            }
            if (requestFilterCriteria_filterCriteria_FindingArn != null)
            {
                request.FilterCriteria.FindingArn = requestFilterCriteria_filterCriteria_FindingArn;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_FindingStatus = null;
            if (cmdletContext.FilterCriteria_FindingStatus != null)
            {
                requestFilterCriteria_filterCriteria_FindingStatus = cmdletContext.FilterCriteria_FindingStatus;
            }
            if (requestFilterCriteria_filterCriteria_FindingStatus != null)
            {
                request.FilterCriteria.FindingStatus = requestFilterCriteria_filterCriteria_FindingStatus;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_FindingType = null;
            if (cmdletContext.FilterCriteria_FindingType != null)
            {
                requestFilterCriteria_filterCriteria_FindingType = cmdletContext.FilterCriteria_FindingType;
            }
            if (requestFilterCriteria_filterCriteria_FindingType != null)
            {
                request.FilterCriteria.FindingType = requestFilterCriteria_filterCriteria_FindingType;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.DateFilter> requestFilterCriteria_filterCriteria_FirstObservedAt = null;
            if (cmdletContext.FilterCriteria_FirstObservedAt != null)
            {
                requestFilterCriteria_filterCriteria_FirstObservedAt = cmdletContext.FilterCriteria_FirstObservedAt;
            }
            if (requestFilterCriteria_filterCriteria_FirstObservedAt != null)
            {
                request.FilterCriteria.FirstObservedAt = requestFilterCriteria_filterCriteria_FirstObservedAt;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.NumberFilter> requestFilterCriteria_filterCriteria_InspectorScore = null;
            if (cmdletContext.FilterCriteria_InspectorScore != null)
            {
                requestFilterCriteria_filterCriteria_InspectorScore = cmdletContext.FilterCriteria_InspectorScore;
            }
            if (requestFilterCriteria_filterCriteria_InspectorScore != null)
            {
                request.FilterCriteria.InspectorScore = requestFilterCriteria_filterCriteria_InspectorScore;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.DateFilter> requestFilterCriteria_filterCriteria_LastObservedAt = null;
            if (cmdletContext.FilterCriteria_LastObservedAt != null)
            {
                requestFilterCriteria_filterCriteria_LastObservedAt = cmdletContext.FilterCriteria_LastObservedAt;
            }
            if (requestFilterCriteria_filterCriteria_LastObservedAt != null)
            {
                request.FilterCriteria.LastObservedAt = requestFilterCriteria_filterCriteria_LastObservedAt;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_NetworkProtocol = null;
            if (cmdletContext.FilterCriteria_NetworkProtocol != null)
            {
                requestFilterCriteria_filterCriteria_NetworkProtocol = cmdletContext.FilterCriteria_NetworkProtocol;
            }
            if (requestFilterCriteria_filterCriteria_NetworkProtocol != null)
            {
                request.FilterCriteria.NetworkProtocol = requestFilterCriteria_filterCriteria_NetworkProtocol;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.PortRangeFilter> requestFilterCriteria_filterCriteria_PortRange = null;
            if (cmdletContext.FilterCriteria_PortRange != null)
            {
                requestFilterCriteria_filterCriteria_PortRange = cmdletContext.FilterCriteria_PortRange;
            }
            if (requestFilterCriteria_filterCriteria_PortRange != null)
            {
                request.FilterCriteria.PortRange = requestFilterCriteria_filterCriteria_PortRange;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_RelatedVulnerability = null;
            if (cmdletContext.FilterCriteria_RelatedVulnerability != null)
            {
                requestFilterCriteria_filterCriteria_RelatedVulnerability = cmdletContext.FilterCriteria_RelatedVulnerability;
            }
            if (requestFilterCriteria_filterCriteria_RelatedVulnerability != null)
            {
                request.FilterCriteria.RelatedVulnerabilities = requestFilterCriteria_filterCriteria_RelatedVulnerability;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_ResourceId = null;
            if (cmdletContext.FilterCriteria_ResourceId != null)
            {
                requestFilterCriteria_filterCriteria_ResourceId = cmdletContext.FilterCriteria_ResourceId;
            }
            if (requestFilterCriteria_filterCriteria_ResourceId != null)
            {
                request.FilterCriteria.ResourceId = requestFilterCriteria_filterCriteria_ResourceId;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.MapFilter> requestFilterCriteria_filterCriteria_ResourceTag = null;
            if (cmdletContext.FilterCriteria_ResourceTag != null)
            {
                requestFilterCriteria_filterCriteria_ResourceTag = cmdletContext.FilterCriteria_ResourceTag;
            }
            if (requestFilterCriteria_filterCriteria_ResourceTag != null)
            {
                request.FilterCriteria.ResourceTags = requestFilterCriteria_filterCriteria_ResourceTag;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_ResourceType = null;
            if (cmdletContext.FilterCriteria_ResourceType != null)
            {
                requestFilterCriteria_filterCriteria_ResourceType = cmdletContext.FilterCriteria_ResourceType;
            }
            if (requestFilterCriteria_filterCriteria_ResourceType != null)
            {
                request.FilterCriteria.ResourceType = requestFilterCriteria_filterCriteria_ResourceType;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_Severity = null;
            if (cmdletContext.FilterCriteria_Severity != null)
            {
                requestFilterCriteria_filterCriteria_Severity = cmdletContext.FilterCriteria_Severity;
            }
            if (requestFilterCriteria_filterCriteria_Severity != null)
            {
                request.FilterCriteria.Severity = requestFilterCriteria_filterCriteria_Severity;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_Title = null;
            if (cmdletContext.FilterCriteria_Title != null)
            {
                requestFilterCriteria_filterCriteria_Title = cmdletContext.FilterCriteria_Title;
            }
            if (requestFilterCriteria_filterCriteria_Title != null)
            {
                request.FilterCriteria.Title = requestFilterCriteria_filterCriteria_Title;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.DateFilter> requestFilterCriteria_filterCriteria_UpdatedAt = null;
            if (cmdletContext.FilterCriteria_UpdatedAt != null)
            {
                requestFilterCriteria_filterCriteria_UpdatedAt = cmdletContext.FilterCriteria_UpdatedAt;
            }
            if (requestFilterCriteria_filterCriteria_UpdatedAt != null)
            {
                request.FilterCriteria.UpdatedAt = requestFilterCriteria_filterCriteria_UpdatedAt;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_VendorSeverity = null;
            if (cmdletContext.FilterCriteria_VendorSeverity != null)
            {
                requestFilterCriteria_filterCriteria_VendorSeverity = cmdletContext.FilterCriteria_VendorSeverity;
            }
            if (requestFilterCriteria_filterCriteria_VendorSeverity != null)
            {
                request.FilterCriteria.VendorSeverity = requestFilterCriteria_filterCriteria_VendorSeverity;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_VulnerabilityId = null;
            if (cmdletContext.FilterCriteria_VulnerabilityId != null)
            {
                requestFilterCriteria_filterCriteria_VulnerabilityId = cmdletContext.FilterCriteria_VulnerabilityId;
            }
            if (requestFilterCriteria_filterCriteria_VulnerabilityId != null)
            {
                request.FilterCriteria.VulnerabilityId = requestFilterCriteria_filterCriteria_VulnerabilityId;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.StringFilter> requestFilterCriteria_filterCriteria_VulnerabilitySource = null;
            if (cmdletContext.FilterCriteria_VulnerabilitySource != null)
            {
                requestFilterCriteria_filterCriteria_VulnerabilitySource = cmdletContext.FilterCriteria_VulnerabilitySource;
            }
            if (requestFilterCriteria_filterCriteria_VulnerabilitySource != null)
            {
                request.FilterCriteria.VulnerabilitySource = requestFilterCriteria_filterCriteria_VulnerabilitySource;
                requestFilterCriteriaIsNull = false;
            }
            List<Amazon.Inspector2.Model.PackageFilter> requestFilterCriteria_filterCriteria_VulnerablePackage = null;
            if (cmdletContext.FilterCriteria_VulnerablePackage != null)
            {
                requestFilterCriteria_filterCriteria_VulnerablePackage = cmdletContext.FilterCriteria_VulnerablePackage;
            }
            if (requestFilterCriteria_filterCriteria_VulnerablePackage != null)
            {
                request.FilterCriteria.VulnerablePackages = requestFilterCriteria_filterCriteria_VulnerablePackage;
                requestFilterCriteriaIsNull = false;
            }
             // determine if request.FilterCriteria should be set to null
            if (requestFilterCriteriaIsNull)
            {
                request.FilterCriteria = null;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            if (cmdletContext.NextToken != null)
            {
                request.NextToken = cmdletContext.NextToken;
            }
            
             // populate SortCriteria
            var requestSortCriteriaIsNull = true;
            request.SortCriteria = new Amazon.Inspector2.Model.SortCriteria();
            Amazon.Inspector2.SortField requestSortCriteria_sortCriteria_Field = null;
            if (cmdletContext.SortCriteria_Field != null)
            {
                requestSortCriteria_sortCriteria_Field = cmdletContext.SortCriteria_Field;
            }
            if (requestSortCriteria_sortCriteria_Field != null)
            {
                request.SortCriteria.Field = requestSortCriteria_sortCriteria_Field;
                requestSortCriteriaIsNull = false;
            }
            Amazon.Inspector2.SortOrder requestSortCriteria_sortCriteria_SortOrder = null;
            if (cmdletContext.SortCriteria_SortOrder != null)
            {
                requestSortCriteria_sortCriteria_SortOrder = cmdletContext.SortCriteria_SortOrder;
            }
            if (requestSortCriteria_sortCriteria_SortOrder != null)
            {
                request.SortCriteria.SortOrder = requestSortCriteria_sortCriteria_SortOrder;
                requestSortCriteriaIsNull = false;
            }
             // determine if request.SortCriteria should be set to null
            if (requestSortCriteriaIsNull)
            {
                request.SortCriteria = null;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Inspector2.Model.ListFindingsResponse CallAWSServiceOperation(IAmazonInspector2 client, Amazon.Inspector2.Model.ListFindingsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Inspector2", "ListFindings");
            try
            {
                #if DESKTOP
                return client.ListFindings(request);
                #elif CORECLR
                return client.ListFindingsAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_AwsAccountId { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_ComponentId { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_ComponentType { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_Ec2InstanceImageId { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_Ec2InstanceSubnetId { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_Ec2InstanceVpcId { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_EcrImageArchitecture { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_EcrImageHash { get; set; }
            public List<Amazon.Inspector2.Model.DateFilter> FilterCriteria_EcrImagePushedAt { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_EcrImageRegistry { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_EcrImageRepositoryName { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_EcrImageTag { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_FindingArn { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_FindingStatus { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_FindingType { get; set; }
            public List<Amazon.Inspector2.Model.DateFilter> FilterCriteria_FirstObservedAt { get; set; }
            public List<Amazon.Inspector2.Model.NumberFilter> FilterCriteria_InspectorScore { get; set; }
            public List<Amazon.Inspector2.Model.DateFilter> FilterCriteria_LastObservedAt { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_NetworkProtocol { get; set; }
            public List<Amazon.Inspector2.Model.PortRangeFilter> FilterCriteria_PortRange { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_RelatedVulnerability { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_ResourceId { get; set; }
            public List<Amazon.Inspector2.Model.MapFilter> FilterCriteria_ResourceTag { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_ResourceType { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_Severity { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_Title { get; set; }
            public List<Amazon.Inspector2.Model.DateFilter> FilterCriteria_UpdatedAt { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_VendorSeverity { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_VulnerabilityId { get; set; }
            public List<Amazon.Inspector2.Model.StringFilter> FilterCriteria_VulnerabilitySource { get; set; }
            public List<Amazon.Inspector2.Model.PackageFilter> FilterCriteria_VulnerablePackage { get; set; }
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public Amazon.Inspector2.SortField SortCriteria_Field { get; set; }
            public Amazon.Inspector2.SortOrder SortCriteria_SortOrder { get; set; }
            public System.Func<Amazon.Inspector2.Model.ListFindingsResponse, GetINS2FindingListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Findings;
        }
        
    }
}