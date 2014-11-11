/// Copyright (C) 2012-2014 Soomla Inc.
///
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///      http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.
using System;
using UnityEngine;
using System.Collections.Generic;

namespace Soomla.Profile
{
	public class GPSocialProvider : SocialProvider
	{
		private static string TAG = "SOOMLA GPSocialProvider";

		/// <summary>
		/// See docs in <see cref="SoomlaProfile.UpdateStatus"/>
		/// </summary>
		public override void UpdateStatus(string status, SocialActionSuccess success, SocialActionFailed fail) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.UpdateStory"/>
		/// </summary>
		public override void UpdateStory(string message, string name, string caption, 
		                        string link, string pictureUrl, SocialActionSuccess success, SocialActionFailed fail, SocialActionCancel cancel) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.UploadImage"/>
		/// </summary>
		public override void UploadImage(Texture2D tex2D, string fileName, string message, SocialActionSuccess success, SocialActionFailed fail, SocialActionCancel cancel) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.GetContacts"/>
		/// </summary>
		public override void GetContacts(ContactsSuccess success, ContactsFailed fail) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.Logout"/>
		/// </summary>
		public override void Logout(LogoutSuccess success, LogoutFailed fail) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.Login"/>
		/// </summary>
		public override void Login(LoginSuccess success, LoginFailed fail, LoginCancelled cancel) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.IsLoggedIn"/>
		/// </summary>
		public override bool IsLoggedIn() {
			return false;
		}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.AppRequest"/>
		/// </summary>
		public override void AppRequest(string message, string[] to, string extraData, string dialogTitle, AppRequestSuccess success, AppRequestFailed fail) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.Like"/>
		/// </summary>
		public override void Like(string pageName) {
			SoomlaUtils.LogDebug (TAG, "Like");
			Application.OpenURL("https://plus.google.com/+" + pageName);
		}

		public override bool IsNativelyImplemented(){
			return true;
		}
	}
}


