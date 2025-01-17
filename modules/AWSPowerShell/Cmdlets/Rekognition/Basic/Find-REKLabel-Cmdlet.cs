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
using Amazon.Rekognition;
using Amazon.Rekognition.Model;

namespace Amazon.PowerShell.Cmdlets.REK
{
    /// <summary>
    /// Detects instances of real-world entities within an image (JPEG or PNG) provided as
    /// input. This includes objects like flower, tree, and table; events like wedding, graduation,
    /// and birthday party; and concepts like landscape, evening, and nature. 
    /// 
    ///  
    /// <para>
    /// For an example, see Analyzing images stored in an Amazon S3 bucket in the Amazon Rekognition
    /// Developer Guide.
    /// </para><note><para><code>DetectLabels</code> does not support the detection of activities. However,
    /// activity detection is supported for label detection in videos. For more information,
    /// see StartLabelDetection in the Amazon Rekognition Developer Guide.
    /// </para></note><para>
    /// You pass the input image as base64-encoded image bytes or as a reference to an image
    /// in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
    /// passing image bytes is not supported. The image must be either a PNG or JPEG formatted
    /// file. 
    /// </para><para>
    ///  For each object, scene, and concept the API returns one or more labels. Each label
    /// provides the object name, and the level of confidence that the image contains the
    /// object. For example, suppose the input image has a lighthouse, the sea, and a rock.
    /// The response includes all three labels, one for each object. 
    /// </para><para><code>{Name: lighthouse, Confidence: 98.4629}</code></para><para><code>{Name: rock,Confidence: 79.2097}</code></para><para><code> {Name: sea,Confidence: 75.061}</code></para><para>
    /// In the preceding example, the operation returns one label for each of the three objects.
    /// The operation can also return multiple labels for the same object in the image. For
    /// example, if the input image shows a flower (for example, a tulip), the operation might
    /// return the following three labels. 
    /// </para><para><code>{Name: flower,Confidence: 99.0562}</code></para><para><code>{Name: plant,Confidence: 99.0562}</code></para><para><code>{Name: tulip,Confidence: 99.0562}</code></para><para>
    /// In this example, the detection algorithm more precisely identifies the flower as a
    /// tulip.
    /// </para><para>
    /// In response, the API returns an array of labels. In addition, the response also includes
    /// the orientation correction. Optionally, you can specify <code>MinConfidence</code>
    /// to control the confidence threshold for the labels returned. The default is 55%. You
    /// can also add the <code>MaxLabels</code> parameter to limit the number of labels returned.
    /// 
    /// </para><note><para>
    /// If the object detected is a person, the operation doesn't provide the same facial
    /// details that the <a>DetectFaces</a> operation provides.
    /// </para></note><para><code>DetectLabels</code> returns bounding boxes for instances of common object labels
    /// in an array of <a>Instance</a> objects. An <code>Instance</code> object contains a
    /// <a>BoundingBox</a> object, for the location of the label on the image. It also includes
    /// the confidence by which the bounding box was detected.
    /// </para><para><code>DetectLabels</code> also returns a hierarchical taxonomy of detected labels.
    /// For example, a detected car might be assigned the label <i>car</i>. The label <i>car</i>
    /// has two parent labels: <i>Vehicle</i> (its parent) and <i>Transportation</i> (its
    /// grandparent). The response returns the entire list of ancestors for a label. Each
    /// ancestor is a unique label in the response. In the previous example, <i>Car</i>, <i>Vehicle</i>,
    /// and <i>Transportation</i> are returned as unique labels in the response. 
    /// </para><para>
    /// This is a stateless API operation. That is, the operation does not persist any data.
    /// </para><para>
    /// This operation requires permissions to perform the <code>rekognition:DetectLabels</code>
    /// action. 
    /// </para>
    /// </summary>
    [Cmdlet("Find", "REKLabel")]
    [OutputType("Amazon.Rekognition.Model.DetectLabelsResponse")]
    [AWSCmdlet("Calls the Amazon Rekognition DetectLabels API operation.", Operation = new[] {"DetectLabels"}, SelectReturnType = typeof(Amazon.Rekognition.Model.DetectLabelsResponse))]
    [AWSCmdletOutput("Amazon.Rekognition.Model.DetectLabelsResponse",
        "This cmdlet returns an Amazon.Rekognition.Model.DetectLabelsResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class FindREKLabelCmdlet : AmazonRekognitionClientCmdlet, IExecutor
    {
        
        #region Parameter ImageBucket
        /// <summary>
        /// <para>
        /// <para>Name of the S3 bucket.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ImageBucket { get; set; }
        #endregion
        
        #region Parameter ImageContent
        /// <summary>
        /// <para>
        /// <para>Blob of image bytes up to 5 MBs.</para>
        /// </para>
        /// <para>The cmdlet will automatically convert the supplied parameter of type string, string[], System.IO.FileInfo or System.IO.Stream to byte[] before supplying it to the service.</para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Amazon.PowerShell.Common.MemoryStreamParameterConverter]
        public byte[] ImageContent { get; set; }
        #endregion
        
        #region Parameter MaxLabel
        /// <summary>
        /// <para>
        /// <para>Maximum number of labels you want the service to return in the response. The service
        /// returns the specified number of highest confidence labels. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxLabels")]
        public System.Int32? MaxLabel { get; set; }
        #endregion
        
        #region Parameter MinConfidence
        /// <summary>
        /// <para>
        /// <para>Specifies the minimum confidence level for the labels to return. Amazon Rekognition
        /// doesn't return any labels with confidence lower than this specified value.</para><para>If <code>MinConfidence</code> is not specified, the operation returns labels with
        /// a confidence values greater than or equal to 55 percent.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Single? MinConfidence { get; set; }
        #endregion
        
        #region Parameter ImageName
        /// <summary>
        /// <para>
        /// <para>S3 object key name.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ImageName { get; set; }
        #endregion
        
        #region Parameter ImageVersion
        /// <summary>
        /// <para>
        /// <para>If the bucket is versioning enabled, you can specify the object version. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ImageVersion { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Rekognition.Model.DetectLabelsResponse).
        /// Specifying the name of a property of type Amazon.Rekognition.Model.DetectLabelsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Rekognition.Model.DetectLabelsResponse, FindREKLabelCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.ImageContent = this.ImageContent;
            context.ImageBucket = this.ImageBucket;
            context.ImageName = this.ImageName;
            context.ImageVersion = this.ImageVersion;
            context.MaxLabel = this.MaxLabel;
            context.MinConfidence = this.MinConfidence;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            System.IO.MemoryStream _ImageContentStream = null;
            
            try
            {
                var cmdletContext = context as CmdletContext;
                // create request
                var request = new Amazon.Rekognition.Model.DetectLabelsRequest();
                
                
                 // populate Image
                var requestImageIsNull = true;
                request.Image = new Amazon.Rekognition.Model.Image();
                System.IO.MemoryStream requestImage_imageContent = null;
                if (cmdletContext.ImageContent != null)
                {
                    _ImageContentStream = new System.IO.MemoryStream(cmdletContext.ImageContent);
                    requestImage_imageContent = _ImageContentStream;
                }
                if (requestImage_imageContent != null)
                {
                    request.Image.Bytes = requestImage_imageContent;
                    requestImageIsNull = false;
                }
                Amazon.Rekognition.Model.S3Object requestImage_image_S3Object = null;
                
                 // populate S3Object
                var requestImage_image_S3ObjectIsNull = true;
                requestImage_image_S3Object = new Amazon.Rekognition.Model.S3Object();
                System.String requestImage_image_S3Object_imageBucket = null;
                if (cmdletContext.ImageBucket != null)
                {
                    requestImage_image_S3Object_imageBucket = cmdletContext.ImageBucket;
                }
                if (requestImage_image_S3Object_imageBucket != null)
                {
                    requestImage_image_S3Object.Bucket = requestImage_image_S3Object_imageBucket;
                    requestImage_image_S3ObjectIsNull = false;
                }
                System.String requestImage_image_S3Object_imageName = null;
                if (cmdletContext.ImageName != null)
                {
                    requestImage_image_S3Object_imageName = cmdletContext.ImageName;
                }
                if (requestImage_image_S3Object_imageName != null)
                {
                    requestImage_image_S3Object.Name = requestImage_image_S3Object_imageName;
                    requestImage_image_S3ObjectIsNull = false;
                }
                System.String requestImage_image_S3Object_imageVersion = null;
                if (cmdletContext.ImageVersion != null)
                {
                    requestImage_image_S3Object_imageVersion = cmdletContext.ImageVersion;
                }
                if (requestImage_image_S3Object_imageVersion != null)
                {
                    requestImage_image_S3Object.Version = requestImage_image_S3Object_imageVersion;
                    requestImage_image_S3ObjectIsNull = false;
                }
                 // determine if requestImage_image_S3Object should be set to null
                if (requestImage_image_S3ObjectIsNull)
                {
                    requestImage_image_S3Object = null;
                }
                if (requestImage_image_S3Object != null)
                {
                    request.Image.S3Object = requestImage_image_S3Object;
                    requestImageIsNull = false;
                }
                 // determine if request.Image should be set to null
                if (requestImageIsNull)
                {
                    request.Image = null;
                }
                if (cmdletContext.MaxLabel != null)
                {
                    request.MaxLabels = cmdletContext.MaxLabel.Value;
                }
                if (cmdletContext.MinConfidence != null)
                {
                    request.MinConfidence = cmdletContext.MinConfidence.Value;
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
            finally
            {
                if( _ImageContentStream != null)
                {
                    _ImageContentStream.Dispose();
                }
            }
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Rekognition.Model.DetectLabelsResponse CallAWSServiceOperation(IAmazonRekognition client, Amazon.Rekognition.Model.DetectLabelsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Rekognition", "DetectLabels");
            try
            {
                #if DESKTOP
                return client.DetectLabels(request);
                #elif CORECLR
                return client.DetectLabelsAsync(request).GetAwaiter().GetResult();
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
            public byte[] ImageContent { get; set; }
            public System.String ImageBucket { get; set; }
            public System.String ImageName { get; set; }
            public System.String ImageVersion { get; set; }
            public System.Int32? MaxLabel { get; set; }
            public System.Single? MinConfidence { get; set; }
            public System.Func<Amazon.Rekognition.Model.DetectLabelsResponse, FindREKLabelCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
