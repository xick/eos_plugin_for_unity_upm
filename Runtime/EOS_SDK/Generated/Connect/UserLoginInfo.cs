// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Additional information about the local user.
	/// </summary>
	public struct UserLoginInfo
	{
		/// <summary>
		/// The user's display name on the identity provider systems as UTF-8 encoded null-terminated string.
		/// The length of the name can be at maximum up to <see cref="ConnectInterface.UserlogininfoDisplaynameMaxLength" /> bytes.
		/// 
		/// As the display name passed here is client-controlled and not part of user authentication tokens,
		/// it is only treated as non-authoritative informational data to be used by some of the feature services.
		/// For example displaying player names in Leaderboards rankings.
		/// </summary>
		public Utf8String DisplayName { get; set; }

		/// <summary>
		/// Nintendo Service Account ID Token (NSA ID).
		/// 
		/// This field is required to be set and only used when running on the Nintendo Switch device,
		/// and the user is being authenticated using any other credential type than <see cref="ExternalCredentialType.NintendoNsaIdToken" />.
		/// 
		/// In order to use the Lobbies and Sessions interfaces, a valid NSA ID Token is required to be provided
		/// for the active local Nintendo Switch user. Otherwise, attempting to use either of the Lobbies or
		/// Sessions interfaces will return the <see cref="Result.PermissionOnlinePlayRestricted" /> error result.
		/// </summary>
		public Utf8String NsaIdToken { get; set; }

		internal void Set(ref UserLoginInfoInternal other)
		{
			DisplayName = other.DisplayName;
			NsaIdToken = other.NsaIdToken;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct UserLoginInfoInternal : IGettable<UserLoginInfo>, ISettable<UserLoginInfo>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_DisplayName;
		private System.IntPtr m_NsaIdToken;

		public Utf8String DisplayName
		{
			get
			{
				Utf8String value;
				Helper.Get(m_DisplayName, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_DisplayName);
			}
		}

		public Utf8String NsaIdToken
		{
			get
			{
				Utf8String value;
				Helper.Get(m_NsaIdToken, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_NsaIdToken);
			}
		}

		public void Set(ref UserLoginInfo other)
		{
			m_ApiVersion = ConnectInterface.UserlogininfoApiLatest;
			DisplayName = other.DisplayName;
			NsaIdToken = other.NsaIdToken;
		}

		public void Set(ref UserLoginInfo? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = ConnectInterface.UserlogininfoApiLatest;
				DisplayName = other.Value.DisplayName;
				NsaIdToken = other.Value.NsaIdToken;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_DisplayName);
			Helper.Dispose(ref m_NsaIdToken);
		}

		public void Get(out UserLoginInfo output)
		{
			output = new UserLoginInfo();
			output.Set(ref this);
		}
	}
}