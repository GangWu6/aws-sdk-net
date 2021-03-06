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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the EnableMetricsCollection operation.
    /// Enables monitoring of the specified metrics for the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// You can only enable metrics collection if <code>InstanceMonitoring</code> in the launch
    /// configuration for the group is set to <code>True</code>.
    /// </para>
    /// </summary>
    public partial class EnableMetricsCollectionRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private string _granularity;
        private List<string> _metrics = new List<string>();

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name or ARN of the Auto Scaling group.
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The granularity to associate with the metrics to collect. The only valid value is
        /// <code>1Minute</code>.
        /// </para>
        /// </summary>
        public string Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// One or more metrics. If you omit this parameter, all metrics are enabled.
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <code>GroupMinSize</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupMaxSize</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupDesiredCapacity</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupInServiceInstances</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupPendingInstances</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupStandbyInstances</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupTerminatingInstances</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupTotalInstances</code>
        /// </para>
        /// </li> </ul> 
        /// <para>
        /// Note that the <code>GroupStandbyInstances</code> metric is not enabled by default.
        /// You must explicitly request this metric.
        /// </para>
        /// </summary>
        public List<string> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

    }
}