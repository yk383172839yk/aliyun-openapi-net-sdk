/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Iot.Model.V20170420;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20170420
{
    public class QueryTopicReverseRouteTableResponseUnmarshaller
    {
        public static QueryTopicReverseRouteTableResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTopicReverseRouteTableResponse queryTopicReverseRouteTableResponse = new QueryTopicReverseRouteTableResponse();

			queryTopicReverseRouteTableResponse.HttpResponse = context.HttpResponse;
			queryTopicReverseRouteTableResponse.RequestId = context.StringValue("QueryTopicReverseRouteTable.RequestId");
			queryTopicReverseRouteTableResponse.Success = context.BooleanValue("QueryTopicReverseRouteTable.Success");
			queryTopicReverseRouteTableResponse.Code = context.StringValue("QueryTopicReverseRouteTable.Code");
			queryTopicReverseRouteTableResponse.ErrorMessage = context.StringValue("QueryTopicReverseRouteTable.ErrorMessage");

			List<string> queryTopicReverseRouteTableResponse_srcTopics = new List<string>();
			for (int i = 0; i < context.Length("QueryTopicReverseRouteTable.SrcTopics.Length"); i++) {
				queryTopicReverseRouteTableResponse_srcTopics.Add(context.StringValue("QueryTopicReverseRouteTable.SrcTopics["+ i +"]"));
			}
			queryTopicReverseRouteTableResponse.SrcTopics = queryTopicReverseRouteTableResponse_srcTopics;
        
			return queryTopicReverseRouteTableResponse;
        }
    }
}