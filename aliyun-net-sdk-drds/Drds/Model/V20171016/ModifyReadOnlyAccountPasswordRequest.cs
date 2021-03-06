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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Drds.Transform;
using Aliyun.Acs.Drds.Transform.V20171016;
using System.Collections.Generic;

namespace Aliyun.Acs.Drds.Model.V20171016
{
    public class ModifyReadOnlyAccountPasswordRequest : RpcAcsRequest<ModifyReadOnlyAccountPasswordResponse>
    {
        public ModifyReadOnlyAccountPasswordRequest()
            : base("Drds", "2017-10-16", "ModifyReadOnlyAccountPassword")
        {
        }

		private string newPasswd;

		private string dbName;

		private string accountName;

		private string originPassword;

		private string action;

		private string drdsInstanceId;

		private string accessKeyId;

		public string NewPasswd
		{
			get
			{
				return newPasswd;
			}
			set	
			{
				newPasswd = value;
				DictionaryUtil.Add(QueryParameters, "NewPasswd", value);
			}
		}

		public string DbName
		{
			get
			{
				return dbName;
			}
			set	
			{
				dbName = value;
				DictionaryUtil.Add(QueryParameters, "DbName", value);
			}
		}

		public string AccountName
		{
			get
			{
				return accountName;
			}
			set	
			{
				accountName = value;
				DictionaryUtil.Add(QueryParameters, "AccountName", value);
			}
		}

		public string OriginPassword
		{
			get
			{
				return originPassword;
			}
			set	
			{
				originPassword = value;
				DictionaryUtil.Add(QueryParameters, "OriginPassword", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string DrdsInstanceId
		{
			get
			{
				return drdsInstanceId;
			}
			set	
			{
				drdsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DrdsInstanceId", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override ModifyReadOnlyAccountPasswordResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyReadOnlyAccountPasswordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}