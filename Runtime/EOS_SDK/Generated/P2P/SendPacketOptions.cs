// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about the data being sent and to which player
	/// </summary>
	public struct SendPacketOptions
	{
		/// <summary>
		/// The Product User ID of the local user who is sending this packet
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The Product User ID of the Peer you would like to send a packet to
		/// </summary>
		public ProductUserId RemoteUserId { get; set; }

		/// <summary>
		/// The socket ID for data you are sending in this packet
		/// </summary>
		public SocketId? SocketId { get; set; }

		/// <summary>
		/// Channel associated with this data
		/// </summary>
		public byte Channel { get; set; }

		/// <summary>
		/// The data to be sent to the RemoteUser
		/// </summary>
		public System.ArraySegment<byte> Data { get; set; }

		/// <summary>
		/// If false and we do not already have an established connection to the peer, this data will be dropped
		/// </summary>
		public bool AllowDelayedDelivery { get; set; }

		/// <summary>
		/// Setting to control the delivery reliability of this packet
		/// </summary>
		public PacketReliability Reliability { get; set; }

		/// <summary>
		/// If set to <see langword="true" />, <see cref="P2PInterface.SendPacket" /> will not automatically establish a connection with the RemoteUserId and will require explicit calls to
		/// <see cref="P2PInterface.AcceptConnection" /> first whenever the connection is closed. If set to <see langword="false" />, <see cref="P2PInterface.SendPacket" /> will automatically accept and start
		/// the connection any time it is called and the connection is not already open.
		/// </summary>
		public bool DisableAutoAcceptConnection { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SendPacketOptionsInternal : ISettable<SendPacketOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RemoteUserId;
		private System.IntPtr m_SocketId;
		private byte m_Channel;
		private uint m_DataLengthBytes;
		private System.IntPtr m_Data;
		private int m_AllowDelayedDelivery;
		private PacketReliability m_Reliability;
		private int m_DisableAutoAcceptConnection;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public ProductUserId RemoteUserId
		{
			set
			{
				Helper.Set(value, ref m_RemoteUserId);
			}
		}

		public SocketId? SocketId
		{
			set
			{
				Helper.Set<SocketId, SocketIdInternal>(ref value, ref m_SocketId);
			}
		}

		public byte Channel
		{
			set
			{
				m_Channel = value;
			}
		}

		public System.ArraySegment<byte> Data
		{
			set
			{
				Helper.Set(value, ref m_Data, out m_DataLengthBytes);
			}
		}

		public bool AllowDelayedDelivery
		{
			set
			{
				Helper.Set(value, ref m_AllowDelayedDelivery);
			}
		}

		public PacketReliability Reliability
		{
			set
			{
				m_Reliability = value;
			}
		}

		public bool DisableAutoAcceptConnection
		{
			set
			{
				Helper.Set(value, ref m_DisableAutoAcceptConnection);
			}
		}

		public void Set(ref SendPacketOptions other)
		{
			m_ApiVersion = P2PInterface.SendpacketApiLatest;
			LocalUserId = other.LocalUserId;
			RemoteUserId = other.RemoteUserId;
			SocketId = other.SocketId;
			Channel = other.Channel;
			Data = other.Data;
			AllowDelayedDelivery = other.AllowDelayedDelivery;
			Reliability = other.Reliability;
			DisableAutoAcceptConnection = other.DisableAutoAcceptConnection;
		}

		public void Set(ref SendPacketOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = P2PInterface.SendpacketApiLatest;
				LocalUserId = other.Value.LocalUserId;
				RemoteUserId = other.Value.RemoteUserId;
				SocketId = other.Value.SocketId;
				Channel = other.Value.Channel;
				Data = other.Value.Data;
				AllowDelayedDelivery = other.Value.AllowDelayedDelivery;
				Reliability = other.Value.Reliability;
				DisableAutoAcceptConnection = other.Value.DisableAutoAcceptConnection;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_RemoteUserId);
			Helper.Dispose(ref m_SocketId);
			Helper.Dispose(ref m_Data);
		}
	}
}