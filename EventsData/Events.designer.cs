﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventsData
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Events")]
	public partial class EventsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public EventsDataContext() : 
				base(global::EventsData.Properties.Settings.Default.EventsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EventsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EventsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EventsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EventsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EventTable2> EventTable2s
		{
			get
			{
				return this.GetTable<EventTable2>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EventTable2")]
	public partial class EventTable2
	{
		
		private System.Nullable<byte> _ID;
		
		private string _EventName;
		
		private System.Nullable<System.DateTime> _EventStart;
		
		private System.Nullable<System.DateTime> _EventEnd;
		
		private string _EventOrganiser;
		
		private string _EventParticipants;
		
		private System.Nullable<byte> _EventRoomNumber;
		
		public EventTable2()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="TinyInt")]
		public System.Nullable<byte> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventName", DbType="VarChar(50)")]
		public string EventName
		{
			get
			{
				return this._EventName;
			}
			set
			{
				if ((this._EventName != value))
				{
					this._EventName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventStart", DbType="DateTime")]
		public System.Nullable<System.DateTime> EventStart
		{
			get
			{
				return this._EventStart;
			}
			set
			{
				if ((this._EventStart != value))
				{
					this._EventStart = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventEnd", DbType="DateTime")]
		public System.Nullable<System.DateTime> EventEnd
		{
			get
			{
				return this._EventEnd;
			}
			set
			{
				if ((this._EventEnd != value))
				{
					this._EventEnd = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventOrganiser", DbType="VarChar(50)")]
		public string EventOrganiser
		{
			get
			{
				return this._EventOrganiser;
			}
			set
			{
				if ((this._EventOrganiser != value))
				{
					this._EventOrganiser = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventParticipants", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EventParticipants
		{
			get
			{
				return this._EventParticipants;
			}
			set
			{
				if ((this._EventParticipants != value))
				{
					this._EventParticipants = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventRoomNumber", DbType="TinyInt")]
		public System.Nullable<byte> EventRoomNumber
		{
			get
			{
				return this._EventRoomNumber;
			}
			set
			{
				if ((this._EventRoomNumber != value))
				{
					this._EventRoomNumber = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
