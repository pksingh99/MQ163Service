﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MQ163Service.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MQ163")]
	public partial class MQ163DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProspect(Prospect instance);
    partial void UpdateProspect(Prospect instance);
    partial void DeleteProspect(Prospect instance);
    partial void InsertMerchandizeOffer(MerchandizeOffer instance);
    partial void UpdateMerchandizeOffer(MerchandizeOffer instance);
    partial void DeleteMerchandizeOffer(MerchandizeOffer instance);
    #endregion
		
		public MQ163DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MQ163ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MQ163DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MQ163DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MQ163DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MQ163DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Prospect> Prospects
		{
			get
			{
				return this.GetTable<Prospect>();
			}
		}
		
		public System.Data.Linq.Table<MerchandizeOffer> MerchandizeOffers
		{
			get
			{
				return this.GetTable<MerchandizeOffer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Prospect")]
	public partial class Prospect : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FullName;
		
		private string _email;
		
		private bool _IsCustomer;
		
		private string _Car;
		
		private string _Features;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnIsCustomerChanging(bool value);
    partial void OnIsCustomerChanged();
    partial void OnCarChanging(string value);
    partial void OnCarChanged();
    partial void OnFeaturesChanging(string value);
    partial void OnFeaturesChanged();
    #endregion
		
		public Prospect()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsCustomer", DbType="Bit NOT NULL")]
		public bool IsCustomer
		{
			get
			{
				return this._IsCustomer;
			}
			set
			{
				if ((this._IsCustomer != value))
				{
					this.OnIsCustomerChanging(value);
					this.SendPropertyChanging();
					this._IsCustomer = value;
					this.SendPropertyChanged("IsCustomer");
					this.OnIsCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Car", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Car
		{
			get
			{
				return this._Car;
			}
			set
			{
				if ((this._Car != value))
				{
					this.OnCarChanging(value);
					this.SendPropertyChanging();
					this._Car = value;
					this.SendPropertyChanged("Car");
					this.OnCarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Features", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Features
		{
			get
			{
				return this._Features;
			}
			set
			{
				if ((this._Features != value))
				{
					this.OnFeaturesChanging(value);
					this.SendPropertyChanging();
					this._Features = value;
					this.SendPropertyChanged("Features");
					this.OnFeaturesChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MerchandizeOffer")]
	public partial class MerchandizeOffer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Details;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDetailsChanging(string value);
    partial void OnDetailsChanged();
    #endregion
		
		public MerchandizeOffer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Details", DbType="NVarChar(256)")]
		public string Details
		{
			get
			{
				return this._Details;
			}
			set
			{
				if ((this._Details != value))
				{
					this.OnDetailsChanging(value);
					this.SendPropertyChanging();
					this._Details = value;
					this.SendPropertyChanged("Details");
					this.OnDetailsChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
