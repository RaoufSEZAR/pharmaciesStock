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

namespace VTYS_Proje_App
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="eczane")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKullanicilar(Kullanicilar instance);
    partial void UpdateKullanicilar(Kullanicilar instance);
    partial void DeleteKullanicilar(Kullanicilar instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::VTYS_Proje_App.Properties.Settings.Default.eczaneConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Kullanicilar> Kullanicilar
		{
			get
			{
				return this.GetTable<Kullanicilar>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Kullanicilar")]
	public partial class Kullanicilar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _KullaniciID;
		
		private string _KullaniciAd;
		
		private string _Sifre;
		
		private string _Ad;
		
		private string _SoyAd;
		
		private string _Yetki;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKullaniciIDChanging(int value);
    partial void OnKullaniciIDChanged();
    partial void OnKullaniciAdChanging(string value);
    partial void OnKullaniciAdChanged();
    partial void OnSifreChanging(string value);
    partial void OnSifreChanged();
    partial void OnAdChanging(string value);
    partial void OnAdChanged();
    partial void OnSoyAdChanging(string value);
    partial void OnSoyAdChanged();
    partial void OnYetkiChanging(string value);
    partial void OnYetkiChanged();
    #endregion
		
		public Kullanicilar()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KullaniciID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int KullaniciID
		{
			get
			{
				return this._KullaniciID;
			}
			set
			{
				if ((this._KullaniciID != value))
				{
					this.OnKullaniciIDChanging(value);
					this.SendPropertyChanging();
					this._KullaniciID = value;
					this.SendPropertyChanged("KullaniciID");
					this.OnKullaniciIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KullaniciAd", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string KullaniciAd
		{
			get
			{
				return this._KullaniciAd;
			}
			set
			{
				if ((this._KullaniciAd != value))
				{
					this.OnKullaniciAdChanging(value);
					this.SendPropertyChanging();
					this._KullaniciAd = value;
					this.SendPropertyChanged("KullaniciAd");
					this.OnKullaniciAdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sifre", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Sifre
		{
			get
			{
				return this._Sifre;
			}
			set
			{
				if ((this._Sifre != value))
				{
					this.OnSifreChanging(value);
					this.SendPropertyChanging();
					this._Sifre = value;
					this.SendPropertyChanged("Sifre");
					this.OnSifreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ad", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Ad
		{
			get
			{
				return this._Ad;
			}
			set
			{
				if ((this._Ad != value))
				{
					this.OnAdChanging(value);
					this.SendPropertyChanging();
					this._Ad = value;
					this.SendPropertyChanged("Ad");
					this.OnAdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoyAd", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string SoyAd
		{
			get
			{
				return this._SoyAd;
			}
			set
			{
				if ((this._SoyAd != value))
				{
					this.OnSoyAdChanging(value);
					this.SendPropertyChanging();
					this._SoyAd = value;
					this.SendPropertyChanged("SoyAd");
					this.OnSoyAdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Yetki", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Yetki
		{
			get
			{
				return this._Yetki;
			}
			set
			{
				if ((this._Yetki != value))
				{
					this.OnYetkiChanging(value);
					this.SendPropertyChanging();
					this._Yetki = value;
					this.SendPropertyChanged("Yetki");
					this.OnYetkiChanged();
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
