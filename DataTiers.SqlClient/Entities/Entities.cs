
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTiers.SqlClient.Entities {


	public class Category : IEntity {

        private CategoryEntityData entityData;

        public Category() {
            entityData = new CategoryEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object CategoryID {
            get {
                return entityData.CategoryID;
            }
						
        }
		
        public object CategoryName {
            get {
                return entityData.CategoryName;
            }
			            set {
                entityData.CategoryName = value;
            }
						
        }
		
        public object Description {
            get {
                return entityData.Description;
            }
			            set {
                entityData.Description = value;
            }
						
        }
		
        public object Picture {
            get {
                return entityData.Picture;
            }
			            set {
                entityData.Picture = value;
            }
						
        }
				
	}
	
	public class CategoryEntityData : EntityDataBase {
				
		private object _CategoryID = null;

        public object CategoryID {
            get {
                return _CategoryID;
            }
            set {
                if (_CategoryID == value)
                    return;
                _CategoryID = value;
                OnDataChanged();
            }
        }
				
		private object _CategoryName = null;

        public object CategoryName {
            get {
                return _CategoryName;
            }
            set {
                if (_CategoryName == value)
                    return;
                _CategoryName = value;
                OnDataChanged();
            }
        }
				
		private object _Description = null;

        public object Description {
            get {
                return _Description;
            }
            set {
                if (_Description == value)
                    return;
                _Description = value;
                OnDataChanged();
            }
        }
				
		private object _Picture = null;

        public object Picture {
            get {
                return _Picture;
            }
            set {
                if (_Picture == value)
                    return;
                _Picture = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum CategoryColumn : int {
				CategoryID = 1, 		
				CategoryName = 2, 		
				Description = 3, 		
				Picture = 4		
				
    }

    public static class CategoryColumnsHelper {
        public static string GetColumnName(CategoryColumn column) {
            switch (column) {
								
				case CategoryColumn.CategoryID:
					return "CategoryID";				
								
				case CategoryColumn.CategoryName:
					return "CategoryName";				
								
				case CategoryColumn.Description:
					return "Description";				
								
				case CategoryColumn.Picture:
					return "Picture";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class CustomerCustomerDemo : IEntity {

        private CustomerCustomerDemoEntityData entityData;

        public CustomerCustomerDemo() {
            entityData = new CustomerCustomerDemoEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object CustomerID {
            get {
                return entityData.CustomerID;
            }
			            set {
                entityData.CustomerID = value;
            }
						
        }
		
        public object CustomerTypeID {
            get {
                return entityData.CustomerTypeID;
            }
			            set {
                entityData.CustomerTypeID = value;
            }
						
        }
				
	}
	
	public class CustomerCustomerDemoEntityData : EntityDataBase {
				
		private object _CustomerID = null;

        public object CustomerID {
            get {
                return _CustomerID;
            }
            set {
                if (_CustomerID == value)
                    return;
                _CustomerID = value;
                OnDataChanged();
            }
        }
				
		private object _CustomerTypeID = null;

        public object CustomerTypeID {
            get {
                return _CustomerTypeID;
            }
            set {
                if (_CustomerTypeID == value)
                    return;
                _CustomerTypeID = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum CustomerCustomerDemoColumn : int {
				CustomerID = 1, 		
				CustomerTypeID = 2		
				
    }

    public static class CustomerCustomerDemoColumnsHelper {
        public static string GetColumnName(CustomerCustomerDemoColumn column) {
            switch (column) {
								
				case CustomerCustomerDemoColumn.CustomerID:
					return "CustomerID";				
								
				case CustomerCustomerDemoColumn.CustomerTypeID:
					return "CustomerTypeID";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class CustomerDemographic : IEntity {

        private CustomerDemographicEntityData entityData;

        public CustomerDemographic() {
            entityData = new CustomerDemographicEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object CustomerTypeID {
            get {
                return entityData.CustomerTypeID;
            }
			            set {
                entityData.CustomerTypeID = value;
            }
						
        }
		
        public object CustomerDesc {
            get {
                return entityData.CustomerDesc;
            }
			            set {
                entityData.CustomerDesc = value;
            }
						
        }
				
	}
	
	public class CustomerDemographicEntityData : EntityDataBase {
				
		private object _CustomerTypeID = null;

        public object CustomerTypeID {
            get {
                return _CustomerTypeID;
            }
            set {
                if (_CustomerTypeID == value)
                    return;
                _CustomerTypeID = value;
                OnDataChanged();
            }
        }
				
		private object _CustomerDesc = null;

        public object CustomerDesc {
            get {
                return _CustomerDesc;
            }
            set {
                if (_CustomerDesc == value)
                    return;
                _CustomerDesc = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum CustomerDemographicColumn : int {
				CustomerTypeID = 1, 		
				CustomerDesc = 2		
				
    }

    public static class CustomerDemographicColumnsHelper {
        public static string GetColumnName(CustomerDemographicColumn column) {
            switch (column) {
								
				case CustomerDemographicColumn.CustomerTypeID:
					return "CustomerTypeID";				
								
				case CustomerDemographicColumn.CustomerDesc:
					return "CustomerDesc";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class Customer : IEntity {

        private CustomerEntityData entityData;

        public Customer() {
            entityData = new CustomerEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object CustomerID {
            get {
                return entityData.CustomerID;
            }
			            set {
                entityData.CustomerID = value;
            }
						
        }
		
        public object CompanyName {
            get {
                return entityData.CompanyName;
            }
			            set {
                entityData.CompanyName = value;
            }
						
        }
		
        public object ContactName {
            get {
                return entityData.ContactName;
            }
			            set {
                entityData.ContactName = value;
            }
						
        }
		
        public object ContactTitle {
            get {
                return entityData.ContactTitle;
            }
			            set {
                entityData.ContactTitle = value;
            }
						
        }
		
        public object Addres {
            get {
                return entityData.Addres;
            }
			            set {
                entityData.Addres = value;
            }
						
        }
		
        public object City {
            get {
                return entityData.City;
            }
			            set {
                entityData.City = value;
            }
						
        }
		
        public object Region {
            get {
                return entityData.Region;
            }
			            set {
                entityData.Region = value;
            }
						
        }
		
        public object PostalCode {
            get {
                return entityData.PostalCode;
            }
			            set {
                entityData.PostalCode = value;
            }
						
        }
		
        public object Country {
            get {
                return entityData.Country;
            }
			            set {
                entityData.Country = value;
            }
						
        }
		
        public object Phone {
            get {
                return entityData.Phone;
            }
			            set {
                entityData.Phone = value;
            }
						
        }
		
        public object Fax {
            get {
                return entityData.Fax;
            }
			            set {
                entityData.Fax = value;
            }
						
        }
				
	}
	
	public class CustomerEntityData : EntityDataBase {
				
		private object _CustomerID = null;

        public object CustomerID {
            get {
                return _CustomerID;
            }
            set {
                if (_CustomerID == value)
                    return;
                _CustomerID = value;
                OnDataChanged();
            }
        }
				
		private object _CompanyName = null;

        public object CompanyName {
            get {
                return _CompanyName;
            }
            set {
                if (_CompanyName == value)
                    return;
                _CompanyName = value;
                OnDataChanged();
            }
        }
				
		private object _ContactName = null;

        public object ContactName {
            get {
                return _ContactName;
            }
            set {
                if (_ContactName == value)
                    return;
                _ContactName = value;
                OnDataChanged();
            }
        }
				
		private object _ContactTitle = null;

        public object ContactTitle {
            get {
                return _ContactTitle;
            }
            set {
                if (_ContactTitle == value)
                    return;
                _ContactTitle = value;
                OnDataChanged();
            }
        }
				
		private object _Addres = null;

        public object Addres {
            get {
                return _Addres;
            }
            set {
                if (_Addres == value)
                    return;
                _Addres = value;
                OnDataChanged();
            }
        }
				
		private object _City = null;

        public object City {
            get {
                return _City;
            }
            set {
                if (_City == value)
                    return;
                _City = value;
                OnDataChanged();
            }
        }
				
		private object _Region = null;

        public object Region {
            get {
                return _Region;
            }
            set {
                if (_Region == value)
                    return;
                _Region = value;
                OnDataChanged();
            }
        }
				
		private object _PostalCode = null;

        public object PostalCode {
            get {
                return _PostalCode;
            }
            set {
                if (_PostalCode == value)
                    return;
                _PostalCode = value;
                OnDataChanged();
            }
        }
				
		private object _Country = null;

        public object Country {
            get {
                return _Country;
            }
            set {
                if (_Country == value)
                    return;
                _Country = value;
                OnDataChanged();
            }
        }
				
		private object _Phone = null;

        public object Phone {
            get {
                return _Phone;
            }
            set {
                if (_Phone == value)
                    return;
                _Phone = value;
                OnDataChanged();
            }
        }
				
		private object _Fax = null;

        public object Fax {
            get {
                return _Fax;
            }
            set {
                if (_Fax == value)
                    return;
                _Fax = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum CustomerColumn : int {
				CustomerID = 1, 		
				CompanyName = 2, 		
				ContactName = 3, 		
				ContactTitle = 4, 		
				Addres = 5, 		
				City = 6, 		
				Region = 7, 		
				PostalCode = 8, 		
				Country = 9, 		
				Phone = 10, 		
				Fax = 11		
				
    }

    public static class CustomerColumnsHelper {
        public static string GetColumnName(CustomerColumn column) {
            switch (column) {
								
				case CustomerColumn.CustomerID:
					return "CustomerID";				
								
				case CustomerColumn.CompanyName:
					return "CompanyName";				
								
				case CustomerColumn.ContactName:
					return "ContactName";				
								
				case CustomerColumn.ContactTitle:
					return "ContactTitle";				
								
				case CustomerColumn.Addres:
					return "Address";				
								
				case CustomerColumn.City:
					return "City";				
								
				case CustomerColumn.Region:
					return "Region";				
								
				case CustomerColumn.PostalCode:
					return "PostalCode";				
								
				case CustomerColumn.Country:
					return "Country";				
								
				case CustomerColumn.Phone:
					return "Phone";				
								
				case CustomerColumn.Fax:
					return "Fax";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class Employee : IEntity {

        private EmployeeEntityData entityData;

        public Employee() {
            entityData = new EmployeeEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object EmployeeID {
            get {
                return entityData.EmployeeID;
            }
						
        }
		
        public object LastName {
            get {
                return entityData.LastName;
            }
			            set {
                entityData.LastName = value;
            }
						
        }
		
        public object FirstName {
            get {
                return entityData.FirstName;
            }
			            set {
                entityData.FirstName = value;
            }
						
        }
		
        public object Title {
            get {
                return entityData.Title;
            }
			            set {
                entityData.Title = value;
            }
						
        }
		
        public object TitleOfCourtesy {
            get {
                return entityData.TitleOfCourtesy;
            }
			            set {
                entityData.TitleOfCourtesy = value;
            }
						
        }
		
        public object BirthDate {
            get {
                return entityData.BirthDate;
            }
			            set {
                entityData.BirthDate = value;
            }
						
        }
		
        public object HireDate {
            get {
                return entityData.HireDate;
            }
			            set {
                entityData.HireDate = value;
            }
						
        }
		
        public object Addres {
            get {
                return entityData.Addres;
            }
			            set {
                entityData.Addres = value;
            }
						
        }
		
        public object City {
            get {
                return entityData.City;
            }
			            set {
                entityData.City = value;
            }
						
        }
		
        public object Region {
            get {
                return entityData.Region;
            }
			            set {
                entityData.Region = value;
            }
						
        }
		
        public object PostalCode {
            get {
                return entityData.PostalCode;
            }
			            set {
                entityData.PostalCode = value;
            }
						
        }
		
        public object Country {
            get {
                return entityData.Country;
            }
			            set {
                entityData.Country = value;
            }
						
        }
		
        public object HomePhone {
            get {
                return entityData.HomePhone;
            }
			            set {
                entityData.HomePhone = value;
            }
						
        }
		
        public object Extension {
            get {
                return entityData.Extension;
            }
			            set {
                entityData.Extension = value;
            }
						
        }
		
        public object Photo {
            get {
                return entityData.Photo;
            }
			            set {
                entityData.Photo = value;
            }
						
        }
		
        public object Note {
            get {
                return entityData.Note;
            }
			            set {
                entityData.Note = value;
            }
						
        }
		
        public object ReportsTo {
            get {
                return entityData.ReportsTo;
            }
			            set {
                entityData.ReportsTo = value;
            }
						
        }
		
        public object PhotoPath {
            get {
                return entityData.PhotoPath;
            }
			            set {
                entityData.PhotoPath = value;
            }
						
        }
				
	}
	
	public class EmployeeEntityData : EntityDataBase {
				
		private object _EmployeeID = null;

        public object EmployeeID {
            get {
                return _EmployeeID;
            }
            set {
                if (_EmployeeID == value)
                    return;
                _EmployeeID = value;
                OnDataChanged();
            }
        }
				
		private object _LastName = null;

        public object LastName {
            get {
                return _LastName;
            }
            set {
                if (_LastName == value)
                    return;
                _LastName = value;
                OnDataChanged();
            }
        }
				
		private object _FirstName = null;

        public object FirstName {
            get {
                return _FirstName;
            }
            set {
                if (_FirstName == value)
                    return;
                _FirstName = value;
                OnDataChanged();
            }
        }
				
		private object _Title = null;

        public object Title {
            get {
                return _Title;
            }
            set {
                if (_Title == value)
                    return;
                _Title = value;
                OnDataChanged();
            }
        }
				
		private object _TitleOfCourtesy = null;

        public object TitleOfCourtesy {
            get {
                return _TitleOfCourtesy;
            }
            set {
                if (_TitleOfCourtesy == value)
                    return;
                _TitleOfCourtesy = value;
                OnDataChanged();
            }
        }
				
		private object _BirthDate = null;

        public object BirthDate {
            get {
                return _BirthDate;
            }
            set {
                if (_BirthDate == value)
                    return;
                _BirthDate = value;
                OnDataChanged();
            }
        }
				
		private object _HireDate = null;

        public object HireDate {
            get {
                return _HireDate;
            }
            set {
                if (_HireDate == value)
                    return;
                _HireDate = value;
                OnDataChanged();
            }
        }
				
		private object _Addres = null;

        public object Addres {
            get {
                return _Addres;
            }
            set {
                if (_Addres == value)
                    return;
                _Addres = value;
                OnDataChanged();
            }
        }
				
		private object _City = null;

        public object City {
            get {
                return _City;
            }
            set {
                if (_City == value)
                    return;
                _City = value;
                OnDataChanged();
            }
        }
				
		private object _Region = null;

        public object Region {
            get {
                return _Region;
            }
            set {
                if (_Region == value)
                    return;
                _Region = value;
                OnDataChanged();
            }
        }
				
		private object _PostalCode = null;

        public object PostalCode {
            get {
                return _PostalCode;
            }
            set {
                if (_PostalCode == value)
                    return;
                _PostalCode = value;
                OnDataChanged();
            }
        }
				
		private object _Country = null;

        public object Country {
            get {
                return _Country;
            }
            set {
                if (_Country == value)
                    return;
                _Country = value;
                OnDataChanged();
            }
        }
				
		private object _HomePhone = null;

        public object HomePhone {
            get {
                return _HomePhone;
            }
            set {
                if (_HomePhone == value)
                    return;
                _HomePhone = value;
                OnDataChanged();
            }
        }
				
		private object _Extension = null;

        public object Extension {
            get {
                return _Extension;
            }
            set {
                if (_Extension == value)
                    return;
                _Extension = value;
                OnDataChanged();
            }
        }
				
		private object _Photo = null;

        public object Photo {
            get {
                return _Photo;
            }
            set {
                if (_Photo == value)
                    return;
                _Photo = value;
                OnDataChanged();
            }
        }
				
		private object _Note = null;

        public object Note {
            get {
                return _Note;
            }
            set {
                if (_Note == value)
                    return;
                _Note = value;
                OnDataChanged();
            }
        }
				
		private object _ReportsTo = null;

        public object ReportsTo {
            get {
                return _ReportsTo;
            }
            set {
                if (_ReportsTo == value)
                    return;
                _ReportsTo = value;
                OnDataChanged();
            }
        }
				
		private object _PhotoPath = null;

        public object PhotoPath {
            get {
                return _PhotoPath;
            }
            set {
                if (_PhotoPath == value)
                    return;
                _PhotoPath = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum EmployeeColumn : int {
				EmployeeID = 1, 		
				LastName = 2, 		
				FirstName = 3, 		
				Title = 4, 		
				TitleOfCourtesy = 5, 		
				BirthDate = 6, 		
				HireDate = 7, 		
				Addres = 8, 		
				City = 9, 		
				Region = 10, 		
				PostalCode = 11, 		
				Country = 12, 		
				HomePhone = 13, 		
				Extension = 14, 		
				Photo = 15, 		
				Note = 16, 		
				ReportsTo = 17, 		
				PhotoPath = 18		
				
    }

    public static class EmployeeColumnsHelper {
        public static string GetColumnName(EmployeeColumn column) {
            switch (column) {
								
				case EmployeeColumn.EmployeeID:
					return "EmployeeID";				
								
				case EmployeeColumn.LastName:
					return "LastName";				
								
				case EmployeeColumn.FirstName:
					return "FirstName";				
								
				case EmployeeColumn.Title:
					return "Title";				
								
				case EmployeeColumn.TitleOfCourtesy:
					return "TitleOfCourtesy";				
								
				case EmployeeColumn.BirthDate:
					return "BirthDate";				
								
				case EmployeeColumn.HireDate:
					return "HireDate";				
								
				case EmployeeColumn.Addres:
					return "Address";				
								
				case EmployeeColumn.City:
					return "City";				
								
				case EmployeeColumn.Region:
					return "Region";				
								
				case EmployeeColumn.PostalCode:
					return "PostalCode";				
								
				case EmployeeColumn.Country:
					return "Country";				
								
				case EmployeeColumn.HomePhone:
					return "HomePhone";				
								
				case EmployeeColumn.Extension:
					return "Extension";				
								
				case EmployeeColumn.Photo:
					return "Photo";				
								
				case EmployeeColumn.Note:
					return "Notes";				
								
				case EmployeeColumn.ReportsTo:
					return "ReportsTo";				
								
				case EmployeeColumn.PhotoPath:
					return "PhotoPath";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class EmployeeTerritory : IEntity {

        private EmployeeTerritoryEntityData entityData;

        public EmployeeTerritory() {
            entityData = new EmployeeTerritoryEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object EmployeeID {
            get {
                return entityData.EmployeeID;
            }
			            set {
                entityData.EmployeeID = value;
            }
						
        }
		
        public object TerritoryID {
            get {
                return entityData.TerritoryID;
            }
			            set {
                entityData.TerritoryID = value;
            }
						
        }
				
	}
	
	public class EmployeeTerritoryEntityData : EntityDataBase {
				
		private object _EmployeeID = null;

        public object EmployeeID {
            get {
                return _EmployeeID;
            }
            set {
                if (_EmployeeID == value)
                    return;
                _EmployeeID = value;
                OnDataChanged();
            }
        }
				
		private object _TerritoryID = null;

        public object TerritoryID {
            get {
                return _TerritoryID;
            }
            set {
                if (_TerritoryID == value)
                    return;
                _TerritoryID = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum EmployeeTerritoryColumn : int {
				EmployeeID = 1, 		
				TerritoryID = 2		
				
    }

    public static class EmployeeTerritoryColumnsHelper {
        public static string GetColumnName(EmployeeTerritoryColumn column) {
            switch (column) {
								
				case EmployeeTerritoryColumn.EmployeeID:
					return "EmployeeID";				
								
				case EmployeeTerritoryColumn.TerritoryID:
					return "TerritoryID";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class OrderDetail : IEntity {

        private OrderDetailEntityData entityData;

        public OrderDetail() {
            entityData = new OrderDetailEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object OrderID {
            get {
                return entityData.OrderID;
            }
			            set {
                entityData.OrderID = value;
            }
						
        }
		
        public object ProductID {
            get {
                return entityData.ProductID;
            }
			            set {
                entityData.ProductID = value;
            }
						
        }
		
        public object UnitPrice {
            get {
                return entityData.UnitPrice;
            }
			            set {
                entityData.UnitPrice = value;
            }
						
        }
		
        public object Quantity {
            get {
                return entityData.Quantity;
            }
			            set {
                entityData.Quantity = value;
            }
						
        }
		
        public object Discount {
            get {
                return entityData.Discount;
            }
			            set {
                entityData.Discount = value;
            }
						
        }
				
	}
	
	public class OrderDetailEntityData : EntityDataBase {
				
		private object _OrderID = null;

        public object OrderID {
            get {
                return _OrderID;
            }
            set {
                if (_OrderID == value)
                    return;
                _OrderID = value;
                OnDataChanged();
            }
        }
				
		private object _ProductID = null;

        public object ProductID {
            get {
                return _ProductID;
            }
            set {
                if (_ProductID == value)
                    return;
                _ProductID = value;
                OnDataChanged();
            }
        }
				
		private object _UnitPrice = null;

        public object UnitPrice {
            get {
                return _UnitPrice;
            }
            set {
                if (_UnitPrice == value)
                    return;
                _UnitPrice = value;
                OnDataChanged();
            }
        }
				
		private object _Quantity = null;

        public object Quantity {
            get {
                return _Quantity;
            }
            set {
                if (_Quantity == value)
                    return;
                _Quantity = value;
                OnDataChanged();
            }
        }
				
		private object _Discount = null;

        public object Discount {
            get {
                return _Discount;
            }
            set {
                if (_Discount == value)
                    return;
                _Discount = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum OrderDetailColumn : int {
				OrderID = 1, 		
				ProductID = 2, 		
				UnitPrice = 3, 		
				Quantity = 4, 		
				Discount = 5		
				
    }

    public static class OrderDetailColumnsHelper {
        public static string GetColumnName(OrderDetailColumn column) {
            switch (column) {
								
				case OrderDetailColumn.OrderID:
					return "OrderID";				
								
				case OrderDetailColumn.ProductID:
					return "ProductID";				
								
				case OrderDetailColumn.UnitPrice:
					return "UnitPrice";				
								
				case OrderDetailColumn.Quantity:
					return "Quantity";				
								
				case OrderDetailColumn.Discount:
					return "Discount";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class Order : IEntity {

        private OrderEntityData entityData;

        public Order() {
            entityData = new OrderEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object OrderID {
            get {
                return entityData.OrderID;
            }
						
        }
		
        public object CustomerID {
            get {
                return entityData.CustomerID;
            }
			            set {
                entityData.CustomerID = value;
            }
						
        }
		
        public object EmployeeID {
            get {
                return entityData.EmployeeID;
            }
			            set {
                entityData.EmployeeID = value;
            }
						
        }
		
        public object OrderDate {
            get {
                return entityData.OrderDate;
            }
			            set {
                entityData.OrderDate = value;
            }
						
        }
		
        public object RequiredDate {
            get {
                return entityData.RequiredDate;
            }
			            set {
                entityData.RequiredDate = value;
            }
						
        }
		
        public object ShippedDate {
            get {
                return entityData.ShippedDate;
            }
			            set {
                entityData.ShippedDate = value;
            }
						
        }
		
        public object ShipVium {
            get {
                return entityData.ShipVium;
            }
			            set {
                entityData.ShipVium = value;
            }
						
        }
		
        public object Freight {
            get {
                return entityData.Freight;
            }
			            set {
                entityData.Freight = value;
            }
						
        }
		
        public object ShipName {
            get {
                return entityData.ShipName;
            }
			            set {
                entityData.ShipName = value;
            }
						
        }
		
        public object ShipAddres {
            get {
                return entityData.ShipAddres;
            }
			            set {
                entityData.ShipAddres = value;
            }
						
        }
		
        public object ShipCity {
            get {
                return entityData.ShipCity;
            }
			            set {
                entityData.ShipCity = value;
            }
						
        }
		
        public object ShipRegion {
            get {
                return entityData.ShipRegion;
            }
			            set {
                entityData.ShipRegion = value;
            }
						
        }
		
        public object ShipPostalCode {
            get {
                return entityData.ShipPostalCode;
            }
			            set {
                entityData.ShipPostalCode = value;
            }
						
        }
		
        public object ShipCountry {
            get {
                return entityData.ShipCountry;
            }
			            set {
                entityData.ShipCountry = value;
            }
						
        }
				
	}
	
	public class OrderEntityData : EntityDataBase {
				
		private object _OrderID = null;

        public object OrderID {
            get {
                return _OrderID;
            }
            set {
                if (_OrderID == value)
                    return;
                _OrderID = value;
                OnDataChanged();
            }
        }
				
		private object _CustomerID = null;

        public object CustomerID {
            get {
                return _CustomerID;
            }
            set {
                if (_CustomerID == value)
                    return;
                _CustomerID = value;
                OnDataChanged();
            }
        }
				
		private object _EmployeeID = null;

        public object EmployeeID {
            get {
                return _EmployeeID;
            }
            set {
                if (_EmployeeID == value)
                    return;
                _EmployeeID = value;
                OnDataChanged();
            }
        }
				
		private object _OrderDate = null;

        public object OrderDate {
            get {
                return _OrderDate;
            }
            set {
                if (_OrderDate == value)
                    return;
                _OrderDate = value;
                OnDataChanged();
            }
        }
				
		private object _RequiredDate = null;

        public object RequiredDate {
            get {
                return _RequiredDate;
            }
            set {
                if (_RequiredDate == value)
                    return;
                _RequiredDate = value;
                OnDataChanged();
            }
        }
				
		private object _ShippedDate = null;

        public object ShippedDate {
            get {
                return _ShippedDate;
            }
            set {
                if (_ShippedDate == value)
                    return;
                _ShippedDate = value;
                OnDataChanged();
            }
        }
				
		private object _ShipVium = null;

        public object ShipVium {
            get {
                return _ShipVium;
            }
            set {
                if (_ShipVium == value)
                    return;
                _ShipVium = value;
                OnDataChanged();
            }
        }
				
		private object _Freight = null;

        public object Freight {
            get {
                return _Freight;
            }
            set {
                if (_Freight == value)
                    return;
                _Freight = value;
                OnDataChanged();
            }
        }
				
		private object _ShipName = null;

        public object ShipName {
            get {
                return _ShipName;
            }
            set {
                if (_ShipName == value)
                    return;
                _ShipName = value;
                OnDataChanged();
            }
        }
				
		private object _ShipAddres = null;

        public object ShipAddres {
            get {
                return _ShipAddres;
            }
            set {
                if (_ShipAddres == value)
                    return;
                _ShipAddres = value;
                OnDataChanged();
            }
        }
				
		private object _ShipCity = null;

        public object ShipCity {
            get {
                return _ShipCity;
            }
            set {
                if (_ShipCity == value)
                    return;
                _ShipCity = value;
                OnDataChanged();
            }
        }
				
		private object _ShipRegion = null;

        public object ShipRegion {
            get {
                return _ShipRegion;
            }
            set {
                if (_ShipRegion == value)
                    return;
                _ShipRegion = value;
                OnDataChanged();
            }
        }
				
		private object _ShipPostalCode = null;

        public object ShipPostalCode {
            get {
                return _ShipPostalCode;
            }
            set {
                if (_ShipPostalCode == value)
                    return;
                _ShipPostalCode = value;
                OnDataChanged();
            }
        }
				
		private object _ShipCountry = null;

        public object ShipCountry {
            get {
                return _ShipCountry;
            }
            set {
                if (_ShipCountry == value)
                    return;
                _ShipCountry = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum OrderColumn : int {
				OrderID = 1, 		
				CustomerID = 2, 		
				EmployeeID = 3, 		
				OrderDate = 4, 		
				RequiredDate = 5, 		
				ShippedDate = 6, 		
				ShipVium = 7, 		
				Freight = 8, 		
				ShipName = 9, 		
				ShipAddres = 10, 		
				ShipCity = 11, 		
				ShipRegion = 12, 		
				ShipPostalCode = 13, 		
				ShipCountry = 14		
				
    }

    public static class OrderColumnsHelper {
        public static string GetColumnName(OrderColumn column) {
            switch (column) {
								
				case OrderColumn.OrderID:
					return "OrderID";				
								
				case OrderColumn.CustomerID:
					return "CustomerID";				
								
				case OrderColumn.EmployeeID:
					return "EmployeeID";				
								
				case OrderColumn.OrderDate:
					return "OrderDate";				
								
				case OrderColumn.RequiredDate:
					return "RequiredDate";				
								
				case OrderColumn.ShippedDate:
					return "ShippedDate";				
								
				case OrderColumn.ShipVium:
					return "ShipVia";				
								
				case OrderColumn.Freight:
					return "Freight";				
								
				case OrderColumn.ShipName:
					return "ShipName";				
								
				case OrderColumn.ShipAddres:
					return "ShipAddress";				
								
				case OrderColumn.ShipCity:
					return "ShipCity";				
								
				case OrderColumn.ShipRegion:
					return "ShipRegion";				
								
				case OrderColumn.ShipPostalCode:
					return "ShipPostalCode";				
								
				case OrderColumn.ShipCountry:
					return "ShipCountry";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class Product : IEntity {

        private ProductEntityData entityData;

        public Product() {
            entityData = new ProductEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object ProductID {
            get {
                return entityData.ProductID;
            }
						
        }
		
        public object ProductName {
            get {
                return entityData.ProductName;
            }
			            set {
                entityData.ProductName = value;
            }
						
        }
		
        public object SupplierID {
            get {
                return entityData.SupplierID;
            }
			            set {
                entityData.SupplierID = value;
            }
						
        }
		
        public object CategoryID {
            get {
                return entityData.CategoryID;
            }
			            set {
                entityData.CategoryID = value;
            }
						
        }
		
        public object QuantityPerUnit {
            get {
                return entityData.QuantityPerUnit;
            }
			            set {
                entityData.QuantityPerUnit = value;
            }
						
        }
		
        public object UnitPrice {
            get {
                return entityData.UnitPrice;
            }
			            set {
                entityData.UnitPrice = value;
            }
						
        }
		
        public object UnitsInStock {
            get {
                return entityData.UnitsInStock;
            }
			            set {
                entityData.UnitsInStock = value;
            }
						
        }
		
        public object UnitsOnOrder {
            get {
                return entityData.UnitsOnOrder;
            }
			            set {
                entityData.UnitsOnOrder = value;
            }
						
        }
		
        public object ReorderLevel {
            get {
                return entityData.ReorderLevel;
            }
			            set {
                entityData.ReorderLevel = value;
            }
						
        }
		
        public object Discontinued {
            get {
                return entityData.Discontinued;
            }
			            set {
                entityData.Discontinued = value;
            }
						
        }
				
	}
	
	public class ProductEntityData : EntityDataBase {
				
		private object _ProductID = null;

        public object ProductID {
            get {
                return _ProductID;
            }
            set {
                if (_ProductID == value)
                    return;
                _ProductID = value;
                OnDataChanged();
            }
        }
				
		private object _ProductName = null;

        public object ProductName {
            get {
                return _ProductName;
            }
            set {
                if (_ProductName == value)
                    return;
                _ProductName = value;
                OnDataChanged();
            }
        }
				
		private object _SupplierID = null;

        public object SupplierID {
            get {
                return _SupplierID;
            }
            set {
                if (_SupplierID == value)
                    return;
                _SupplierID = value;
                OnDataChanged();
            }
        }
				
		private object _CategoryID = null;

        public object CategoryID {
            get {
                return _CategoryID;
            }
            set {
                if (_CategoryID == value)
                    return;
                _CategoryID = value;
                OnDataChanged();
            }
        }
				
		private object _QuantityPerUnit = null;

        public object QuantityPerUnit {
            get {
                return _QuantityPerUnit;
            }
            set {
                if (_QuantityPerUnit == value)
                    return;
                _QuantityPerUnit = value;
                OnDataChanged();
            }
        }
				
		private object _UnitPrice = null;

        public object UnitPrice {
            get {
                return _UnitPrice;
            }
            set {
                if (_UnitPrice == value)
                    return;
                _UnitPrice = value;
                OnDataChanged();
            }
        }
				
		private object _UnitsInStock = null;

        public object UnitsInStock {
            get {
                return _UnitsInStock;
            }
            set {
                if (_UnitsInStock == value)
                    return;
                _UnitsInStock = value;
                OnDataChanged();
            }
        }
				
		private object _UnitsOnOrder = null;

        public object UnitsOnOrder {
            get {
                return _UnitsOnOrder;
            }
            set {
                if (_UnitsOnOrder == value)
                    return;
                _UnitsOnOrder = value;
                OnDataChanged();
            }
        }
				
		private object _ReorderLevel = null;

        public object ReorderLevel {
            get {
                return _ReorderLevel;
            }
            set {
                if (_ReorderLevel == value)
                    return;
                _ReorderLevel = value;
                OnDataChanged();
            }
        }
				
		private object _Discontinued = null;

        public object Discontinued {
            get {
                return _Discontinued;
            }
            set {
                if (_Discontinued == value)
                    return;
                _Discontinued = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum ProductColumn : int {
				ProductID = 1, 		
				ProductName = 2, 		
				SupplierID = 3, 		
				CategoryID = 4, 		
				QuantityPerUnit = 5, 		
				UnitPrice = 6, 		
				UnitsInStock = 7, 		
				UnitsOnOrder = 8, 		
				ReorderLevel = 9, 		
				Discontinued = 10		
				
    }

    public static class ProductColumnsHelper {
        public static string GetColumnName(ProductColumn column) {
            switch (column) {
								
				case ProductColumn.ProductID:
					return "ProductID";				
								
				case ProductColumn.ProductName:
					return "ProductName";				
								
				case ProductColumn.SupplierID:
					return "SupplierID";				
								
				case ProductColumn.CategoryID:
					return "CategoryID";				
								
				case ProductColumn.QuantityPerUnit:
					return "QuantityPerUnit";				
								
				case ProductColumn.UnitPrice:
					return "UnitPrice";				
								
				case ProductColumn.UnitsInStock:
					return "UnitsInStock";				
								
				case ProductColumn.UnitsOnOrder:
					return "UnitsOnOrder";				
								
				case ProductColumn.ReorderLevel:
					return "ReorderLevel";				
								
				case ProductColumn.Discontinued:
					return "Discontinued";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class Region : IEntity {

        private RegionEntityData entityData;

        public Region() {
            entityData = new RegionEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object RegionID {
            get {
                return entityData.RegionID;
            }
			            set {
                entityData.RegionID = value;
            }
						
        }
		
        public object RegionDescription {
            get {
                return entityData.RegionDescription;
            }
			            set {
                entityData.RegionDescription = value;
            }
						
        }
				
	}
	
	public class RegionEntityData : EntityDataBase {
				
		private object _RegionID = null;

        public object RegionID {
            get {
                return _RegionID;
            }
            set {
                if (_RegionID == value)
                    return;
                _RegionID = value;
                OnDataChanged();
            }
        }
				
		private object _RegionDescription = null;

        public object RegionDescription {
            get {
                return _RegionDescription;
            }
            set {
                if (_RegionDescription == value)
                    return;
                _RegionDescription = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum RegionColumn : int {
				RegionID = 1, 		
				RegionDescription = 2		
				
    }

    public static class RegionColumnsHelper {
        public static string GetColumnName(RegionColumn column) {
            switch (column) {
								
				case RegionColumn.RegionID:
					return "RegionID";				
								
				case RegionColumn.RegionDescription:
					return "RegionDescription";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class Shipper : IEntity {

        private ShipperEntityData entityData;

        public Shipper() {
            entityData = new ShipperEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object ShipperID {
            get {
                return entityData.ShipperID;
            }
						
        }
		
        public object CompanyName {
            get {
                return entityData.CompanyName;
            }
			            set {
                entityData.CompanyName = value;
            }
						
        }
		
        public object Phone {
            get {
                return entityData.Phone;
            }
			            set {
                entityData.Phone = value;
            }
						
        }
				
	}
	
	public class ShipperEntityData : EntityDataBase {
				
		private object _ShipperID = null;

        public object ShipperID {
            get {
                return _ShipperID;
            }
            set {
                if (_ShipperID == value)
                    return;
                _ShipperID = value;
                OnDataChanged();
            }
        }
				
		private object _CompanyName = null;

        public object CompanyName {
            get {
                return _CompanyName;
            }
            set {
                if (_CompanyName == value)
                    return;
                _CompanyName = value;
                OnDataChanged();
            }
        }
				
		private object _Phone = null;

        public object Phone {
            get {
                return _Phone;
            }
            set {
                if (_Phone == value)
                    return;
                _Phone = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum ShipperColumn : int {
				ShipperID = 1, 		
				CompanyName = 2, 		
				Phone = 3		
				
    }

    public static class ShipperColumnsHelper {
        public static string GetColumnName(ShipperColumn column) {
            switch (column) {
								
				case ShipperColumn.ShipperID:
					return "ShipperID";				
								
				case ShipperColumn.CompanyName:
					return "CompanyName";				
								
				case ShipperColumn.Phone:
					return "Phone";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class Supplier : IEntity {

        private SupplierEntityData entityData;

        public Supplier() {
            entityData = new SupplierEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object SupplierID {
            get {
                return entityData.SupplierID;
            }
						
        }
		
        public object CompanyName {
            get {
                return entityData.CompanyName;
            }
			            set {
                entityData.CompanyName = value;
            }
						
        }
		
        public object ContactName {
            get {
                return entityData.ContactName;
            }
			            set {
                entityData.ContactName = value;
            }
						
        }
		
        public object ContactTitle {
            get {
                return entityData.ContactTitle;
            }
			            set {
                entityData.ContactTitle = value;
            }
						
        }
		
        public object Addres {
            get {
                return entityData.Addres;
            }
			            set {
                entityData.Addres = value;
            }
						
        }
		
        public object City {
            get {
                return entityData.City;
            }
			            set {
                entityData.City = value;
            }
						
        }
		
        public object Region {
            get {
                return entityData.Region;
            }
			            set {
                entityData.Region = value;
            }
						
        }
		
        public object PostalCode {
            get {
                return entityData.PostalCode;
            }
			            set {
                entityData.PostalCode = value;
            }
						
        }
		
        public object Country {
            get {
                return entityData.Country;
            }
			            set {
                entityData.Country = value;
            }
						
        }
		
        public object Phone {
            get {
                return entityData.Phone;
            }
			            set {
                entityData.Phone = value;
            }
						
        }
		
        public object Fax {
            get {
                return entityData.Fax;
            }
			            set {
                entityData.Fax = value;
            }
						
        }
		
        public object HomePage {
            get {
                return entityData.HomePage;
            }
			            set {
                entityData.HomePage = value;
            }
						
        }
				
	}
	
	public class SupplierEntityData : EntityDataBase {
				
		private object _SupplierID = null;

        public object SupplierID {
            get {
                return _SupplierID;
            }
            set {
                if (_SupplierID == value)
                    return;
                _SupplierID = value;
                OnDataChanged();
            }
        }
				
		private object _CompanyName = null;

        public object CompanyName {
            get {
                return _CompanyName;
            }
            set {
                if (_CompanyName == value)
                    return;
                _CompanyName = value;
                OnDataChanged();
            }
        }
				
		private object _ContactName = null;

        public object ContactName {
            get {
                return _ContactName;
            }
            set {
                if (_ContactName == value)
                    return;
                _ContactName = value;
                OnDataChanged();
            }
        }
				
		private object _ContactTitle = null;

        public object ContactTitle {
            get {
                return _ContactTitle;
            }
            set {
                if (_ContactTitle == value)
                    return;
                _ContactTitle = value;
                OnDataChanged();
            }
        }
				
		private object _Addres = null;

        public object Addres {
            get {
                return _Addres;
            }
            set {
                if (_Addres == value)
                    return;
                _Addres = value;
                OnDataChanged();
            }
        }
				
		private object _City = null;

        public object City {
            get {
                return _City;
            }
            set {
                if (_City == value)
                    return;
                _City = value;
                OnDataChanged();
            }
        }
				
		private object _Region = null;

        public object Region {
            get {
                return _Region;
            }
            set {
                if (_Region == value)
                    return;
                _Region = value;
                OnDataChanged();
            }
        }
				
		private object _PostalCode = null;

        public object PostalCode {
            get {
                return _PostalCode;
            }
            set {
                if (_PostalCode == value)
                    return;
                _PostalCode = value;
                OnDataChanged();
            }
        }
				
		private object _Country = null;

        public object Country {
            get {
                return _Country;
            }
            set {
                if (_Country == value)
                    return;
                _Country = value;
                OnDataChanged();
            }
        }
				
		private object _Phone = null;

        public object Phone {
            get {
                return _Phone;
            }
            set {
                if (_Phone == value)
                    return;
                _Phone = value;
                OnDataChanged();
            }
        }
				
		private object _Fax = null;

        public object Fax {
            get {
                return _Fax;
            }
            set {
                if (_Fax == value)
                    return;
                _Fax = value;
                OnDataChanged();
            }
        }
				
		private object _HomePage = null;

        public object HomePage {
            get {
                return _HomePage;
            }
            set {
                if (_HomePage == value)
                    return;
                _HomePage = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum SupplierColumn : int {
				SupplierID = 1, 		
				CompanyName = 2, 		
				ContactName = 3, 		
				ContactTitle = 4, 		
				Addres = 5, 		
				City = 6, 		
				Region = 7, 		
				PostalCode = 8, 		
				Country = 9, 		
				Phone = 10, 		
				Fax = 11, 		
				HomePage = 12		
				
    }

    public static class SupplierColumnsHelper {
        public static string GetColumnName(SupplierColumn column) {
            switch (column) {
								
				case SupplierColumn.SupplierID:
					return "SupplierID";				
								
				case SupplierColumn.CompanyName:
					return "CompanyName";				
								
				case SupplierColumn.ContactName:
					return "ContactName";				
								
				case SupplierColumn.ContactTitle:
					return "ContactTitle";				
								
				case SupplierColumn.Addres:
					return "Address";				
								
				case SupplierColumn.City:
					return "City";				
								
				case SupplierColumn.Region:
					return "Region";				
								
				case SupplierColumn.PostalCode:
					return "PostalCode";				
								
				case SupplierColumn.Country:
					return "Country";				
								
				case SupplierColumn.Phone:
					return "Phone";				
								
				case SupplierColumn.Fax:
					return "Fax";				
								
				case SupplierColumn.HomePage:
					return "HomePage";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

	public class Territory : IEntity {

        private TerritoryEntityData entityData;

        public Territory() {
            entityData = new TerritoryEntityData();
        }
			
		IEntityData IEntity.EntityData {
            get { return entityData; }
        }
		
		
        public object TerritoryID {
            get {
                return entityData.TerritoryID;
            }
			            set {
                entityData.TerritoryID = value;
            }
						
        }
		
        public object TerritoryDescription {
            get {
                return entityData.TerritoryDescription;
            }
			            set {
                entityData.TerritoryDescription = value;
            }
						
        }
		
        public object RegionID {
            get {
                return entityData.RegionID;
            }
			            set {
                entityData.RegionID = value;
            }
						
        }
				
	}
	
	public class TerritoryEntityData : EntityDataBase {
				
		private object _TerritoryID = null;

        public object TerritoryID {
            get {
                return _TerritoryID;
            }
            set {
                if (_TerritoryID == value)
                    return;
                _TerritoryID = value;
                OnDataChanged();
            }
        }
				
		private object _TerritoryDescription = null;

        public object TerritoryDescription {
            get {
                return _TerritoryDescription;
            }
            set {
                if (_TerritoryDescription == value)
                    return;
                _TerritoryDescription = value;
                OnDataChanged();
            }
        }
				
		private object _RegionID = null;

        public object RegionID {
            get {
                return _RegionID;
            }
            set {
                if (_RegionID == value)
                    return;
                _RegionID = value;
                OnDataChanged();
            }
        }
				
	}
	
	[Serializable]
    public enum TerritoryColumn : int {
				TerritoryID = 1, 		
				TerritoryDescription = 2, 		
				RegionID = 3		
				
    }

    public static class TerritoryColumnsHelper {
        public static string GetColumnName(TerritoryColumn column) {
            switch (column) {
								
				case TerritoryColumn.TerritoryID:
					return "TerritoryID";				
								
				case TerritoryColumn.TerritoryDescription:
					return "TerritoryDescription";				
								
				case TerritoryColumn.RegionID:
					return "RegionID";				
								
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }

}