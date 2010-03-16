﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30128.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCommon.Data.LinqToSql.Tests.OrdersDomain
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DevelopmentDB")]
	public partial class OrdersDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertOrderItem(OrderItem instance);
    partial void UpdateOrderItem(OrderItem instance);
    partial void DeleteOrderItem(OrderItem instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertMonthlySalesSummary(MonthlySalesSummary instance);
    partial void UpdateMonthlySalesSummary(MonthlySalesSummary instance);
    partial void DeleteMonthlySalesSummary(MonthlySalesSummary instance);
    #endregion
		
		public OrdersDataDataContext() : 
				base(global::NCommon.Data.LinqToSql.Tests.OrdersDomain.Properties.Settings.Default.DevelopmentDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<OrderItem> OrderItems
		{
			get
			{
				return this.GetTable<OrderItem>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<MonthlySalesSummary> MonthlySalesSummaries
		{
			get
			{
				return this.GetTable<MonthlySalesSummary>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private string _StreetAddress1;
		
		private string _StreetAddress2;
		
		private string _City;
		
		private string _State;
		
		private string _ZipCode;
		
		private string _FirstName;
		
		private string _LastName;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnStreetAddress1Changing(string value);
    partial void OnStreetAddress1Changed();
    partial void OnStreetAddress2Changing(string value);
    partial void OnStreetAddress2Changed();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    #endregion
		
		public Customer()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetAddress1", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string StreetAddress1
		{
			get
			{
				return this._StreetAddress1;
			}
			set
			{
				if ((this._StreetAddress1 != value))
				{
					this.OnStreetAddress1Changing(value);
					this.SendPropertyChanging();
					this._StreetAddress1 = value;
					this.SendPropertyChanged("StreetAddress1");
					this.OnStreetAddress1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetAddress2", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string StreetAddress2
		{
			get
			{
				return this._StreetAddress2;
			}
			set
			{
				if ((this._StreetAddress2 != value))
				{
					this.OnStreetAddress2Changing(value);
					this.SendPropertyChanging();
					this._StreetAddress2 = value;
					this.SendPropertyChanged("StreetAddress2");
					this.OnStreetAddress2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Orders", ThisKey="CustomerID", OtherKey="CustomerId")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
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
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderItems")]
	public partial class OrderItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderItemID;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<int> _Quantity;
		
		private string _Store;
		
		private System.Nullable<int> _ProductId;
		
		private System.Nullable<int> _OrderId;
		
		private EntityRef<Order> _Order;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderItemIDChanging(int value);
    partial void OnOrderItemIDChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnStoreChanging(string value);
    partial void OnStoreChanged();
    partial void OnProductIdChanging(System.Nullable<int> value);
    partial void OnProductIdChanged();
    partial void OnOrderIdChanging(System.Nullable<int> value);
    partial void OnOrderIdChanged();
    #endregion
		
		public OrderItem()
		{
			this._Order = default(EntityRef<Order>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderItemID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int OrderItemID
		{
			get
			{
				return this._OrderItemID;
			}
			set
			{
				if ((this._OrderItemID != value))
				{
					this.OnOrderItemIDChanging(value);
					this.SendPropertyChanging();
					this._OrderItemID = value;
					this.SendPropertyChanged("OrderItemID");
					this.OnOrderItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(19,5)", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Store", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string Store
		{
			get
			{
				return this._Store;
			}
			set
			{
				if ((this._Store != value))
				{
					this.OnStoreChanging(value);
					this.SendPropertyChanging();
					this._Store = value;
					this.SendPropertyChanged("Store");
					this.OnStoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderItem", Storage="_Order", ThisKey="OrderId", OtherKey="OrderID", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.OrderItems.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.OrderItems.Add(this);
						this._OrderId = value.OrderID;
					}
					else
					{
						this._OrderId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Order");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderItem", Storage="_Product", ThisKey="ProductId", OtherKey="ProductID", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.OrderItems.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.OrderItems.Add(this);
						this._ProductId = value.ProductID;
					}
					else
					{
						this._ProductId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderID;
		
		private System.Nullable<System.DateTime> _OrderDate;
		
		private System.Nullable<System.DateTime> _ShipDate;
		
		private System.Nullable<int> _CustomerId;
		
		private EntitySet<OrderItem> _OrderItems;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrderDateChanged();
    partial void OnShipDateChanging(System.Nullable<System.DateTime> value);
    partial void OnShipDateChanged();
    partial void OnCustomerIdChanging(System.Nullable<int> value);
    partial void OnCustomerIdChanged();
    #endregion
		
		public Order()
		{
			this._OrderItems = new EntitySet<OrderItem>(new Action<OrderItem>(this.attach_OrderItems), new Action<OrderItem>(this.detach_OrderItems));
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipDate", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> ShipDate
		{
			get
			{
				return this._ShipDate;
			}
			set
			{
				if ((this._ShipDate != value))
				{
					this.OnShipDateChanging(value);
					this.SendPropertyChanging();
					this._ShipDate = value;
					this.SendPropertyChanged("ShipDate");
					this.OnShipDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderItem", Storage="_OrderItems", ThisKey="OrderID", OtherKey="OrderId")]
		public EntitySet<OrderItem> OrderItems
		{
			get
			{
				return this._OrderItems;
			}
			set
			{
				this._OrderItems.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Customer", ThisKey="CustomerId", OtherKey="CustomerID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._CustomerId = value.CustomerID;
					}
					else
					{
						this._CustomerId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Customer");
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
		
		private void attach_OrderItems(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_OrderItems(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _Name;
		
		private string _Description;
		
		private EntitySet<OrderItem> _OrderItems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Product()
		{
			this._OrderItems = new EntitySet<OrderItem>(new Action<OrderItem>(this.attach_OrderItems), new Action<OrderItem>(this.detach_OrderItems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderItem", Storage="_OrderItems", ThisKey="ProductID", OtherKey="ProductId")]
		public EntitySet<OrderItem> OrderItems
		{
			get
			{
				return this._OrderItems;
			}
			set
			{
				this._OrderItems.Assign(value);
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
		
		private void attach_OrderItems(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_OrderItems(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MonthlySalesSummary")]
	public partial class MonthlySalesSummary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Year;
		
		private int _Month;
		
		private int _SalesPersonId;
		
		private System.Nullable<decimal> _Amount;
		
		private string _Currency;
		
		private string _SalesPersonFirstName;
		
		private string _SalesPersonLastName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnYearChanging(int value);
    partial void OnYearChanged();
    partial void OnMonthChanging(int value);
    partial void OnMonthChanged();
    partial void OnSalesPersonIdChanging(int value);
    partial void OnSalesPersonIdChanged();
    partial void OnAmountChanging(System.Nullable<decimal> value);
    partial void OnAmountChanged();
    partial void OnCurrencyChanging(string value);
    partial void OnCurrencyChanged();
    partial void OnSalesPersonFirstNameChanging(string value);
    partial void OnSalesPersonFirstNameChanged();
    partial void OnSalesPersonLastNameChanging(string value);
    partial void OnSalesPersonLastNameChanged();
    #endregion
		
		public MonthlySalesSummary()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Month", DbType="Int NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public int Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				if ((this._Month != value))
				{
					this.OnMonthChanging(value);
					this.SendPropertyChanging();
					this._Month = value;
					this.SendPropertyChanged("Month");
					this.OnMonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesPersonId", DbType="Int NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public int SalesPersonId
		{
			get
			{
				return this._SalesPersonId;
			}
			set
			{
				if ((this._SalesPersonId != value))
				{
					this.OnSalesPersonIdChanging(value);
					this.SendPropertyChanging();
					this._SalesPersonId = value;
					this.SendPropertyChanged("SalesPersonId");
					this.OnSalesPersonIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Decimal(19,5)", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<decimal> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Currency", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string Currency
		{
			get
			{
				return this._Currency;
			}
			set
			{
				if ((this._Currency != value))
				{
					this.OnCurrencyChanging(value);
					this.SendPropertyChanging();
					this._Currency = value;
					this.SendPropertyChanged("Currency");
					this.OnCurrencyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesPersonFirstName", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string SalesPersonFirstName
		{
			get
			{
				return this._SalesPersonFirstName;
			}
			set
			{
				if ((this._SalesPersonFirstName != value))
				{
					this.OnSalesPersonFirstNameChanging(value);
					this.SendPropertyChanging();
					this._SalesPersonFirstName = value;
					this.SendPropertyChanged("SalesPersonFirstName");
					this.OnSalesPersonFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesPersonLastName", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string SalesPersonLastName
		{
			get
			{
				return this._SalesPersonLastName;
			}
			set
			{
				if ((this._SalesPersonLastName != value))
				{
					this.OnSalesPersonLastNameChanging(value);
					this.SendPropertyChanging();
					this._SalesPersonLastName = value;
					this.SendPropertyChanged("SalesPersonLastName");
					this.OnSalesPersonLastNameChanged();
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