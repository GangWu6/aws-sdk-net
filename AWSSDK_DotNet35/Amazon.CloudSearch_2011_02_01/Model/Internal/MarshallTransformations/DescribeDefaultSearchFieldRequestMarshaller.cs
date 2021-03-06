/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearch_2011_02_01.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudSearch_2011_02_01.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeDefaultSearchField Request Marshaller
    /// </summary>       
    public class DescribeDefaultSearchFieldRequestMarshaller : IMarshaller<IRequest, DescribeDefaultSearchFieldRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeDefaultSearchFieldRequest)input);
        }
    
        public IRequest Marshall(DescribeDefaultSearchFieldRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudSearch_2011_02_01");
            request.Parameters.Add("Action", "DescribeDefaultSearchField");
            request.Parameters.Add("Version", "2011-02-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDomainName())
                {
                    request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
                }
            }
            return request;
        }
    }
}