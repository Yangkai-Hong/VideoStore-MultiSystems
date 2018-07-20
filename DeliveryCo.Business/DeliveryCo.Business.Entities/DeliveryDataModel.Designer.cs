﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace DeliveryCo.Business.Entities
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DeliveryDataModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DeliveryDataModelContainer object using the connection string found in the 'DeliveryDataModelContainer' section of the application configuration file.
        /// </summary>
        public DeliveryDataModelContainer() : base("name=DeliveryDataModelContainer", "DeliveryDataModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DeliveryDataModelContainer object.
        /// </summary>
        public DeliveryDataModelContainer(string connectionString) : base(connectionString, "DeliveryDataModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DeliveryDataModelContainer object.
        /// </summary>
        public DeliveryDataModelContainer(EntityConnection connection) : base(connection, "DeliveryDataModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<DeliveryInfo> DeliveryInfoes
        {
            get
            {
                if ((_DeliveryInfoes == null))
                {
                    _DeliveryInfoes = base.CreateObjectSet<DeliveryInfo>("DeliveryInfoes");
                }
                return _DeliveryInfoes;
            }
        }
        private ObjectSet<DeliveryInfo> _DeliveryInfoes;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the DeliveryInfoes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDeliveryInfoes(DeliveryInfo deliveryInfo)
        {
            base.AddObject("DeliveryInfoes", deliveryInfo);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DeliveryDataModel", Name="DeliveryInfo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class DeliveryInfo : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new DeliveryInfo object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="sourceAddress">Initial value of the SourceAddress property.</param>
        /// <param name="destinationAddress">Initial value of the DestinationAddress property.</param>
        /// <param name="orderNumber">Initial value of the OrderNumber property.</param>
        /// <param name="deliveryIdentifier">Initial value of the DeliveryIdentifier property.</param>
        /// <param name="deliveryNotificationAddress">Initial value of the DeliveryNotificationAddress property.</param>
        /// <param name="status">Initial value of the Status property.</param>
        public static DeliveryInfo CreateDeliveryInfo(global::System.Int32 id, global::System.String sourceAddress, global::System.String destinationAddress, global::System.String orderNumber, global::System.Guid deliveryIdentifier, global::System.String deliveryNotificationAddress, global::System.Int32 status)
        {
            DeliveryInfo deliveryInfo = new DeliveryInfo();
            deliveryInfo.Id = id;
            deliveryInfo.SourceAddress = sourceAddress;
            deliveryInfo.DestinationAddress = destinationAddress;
            deliveryInfo.OrderNumber = orderNumber;
            deliveryInfo.DeliveryIdentifier = deliveryIdentifier;
            deliveryInfo.DeliveryNotificationAddress = deliveryNotificationAddress;
            deliveryInfo.Status = status;
            return deliveryInfo;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SourceAddress
        {
            get
            {
                return _SourceAddress;
            }
            set
            {
                OnSourceAddressChanging(value);
                ReportPropertyChanging("SourceAddress");
                _SourceAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SourceAddress");
                OnSourceAddressChanged();
            }
        }
        private global::System.String _SourceAddress;
        partial void OnSourceAddressChanging(global::System.String value);
        partial void OnSourceAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DestinationAddress
        {
            get
            {
                return _DestinationAddress;
            }
            set
            {
                OnDestinationAddressChanging(value);
                ReportPropertyChanging("DestinationAddress");
                _DestinationAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DestinationAddress");
                OnDestinationAddressChanged();
            }
        }
        private global::System.String _DestinationAddress;
        partial void OnDestinationAddressChanging(global::System.String value);
        partial void OnDestinationAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OrderNumber
        {
            get
            {
                return _OrderNumber;
            }
            set
            {
                OnOrderNumberChanging(value);
                ReportPropertyChanging("OrderNumber");
                _OrderNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("OrderNumber");
                OnOrderNumberChanged();
            }
        }
        private global::System.String _OrderNumber;
        partial void OnOrderNumberChanging(global::System.String value);
        partial void OnOrderNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid DeliveryIdentifier
        {
            get
            {
                return _DeliveryIdentifier;
            }
            set
            {
                OnDeliveryIdentifierChanging(value);
                ReportPropertyChanging("DeliveryIdentifier");
                _DeliveryIdentifier = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DeliveryIdentifier");
                OnDeliveryIdentifierChanged();
            }
        }
        private global::System.Guid _DeliveryIdentifier;
        partial void OnDeliveryIdentifierChanging(global::System.Guid value);
        partial void OnDeliveryIdentifierChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DeliveryNotificationAddress
        {
            get
            {
                return _DeliveryNotificationAddress;
            }
            set
            {
                OnDeliveryNotificationAddressChanging(value);
                ReportPropertyChanging("DeliveryNotificationAddress");
                _DeliveryNotificationAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DeliveryNotificationAddress");
                OnDeliveryNotificationAddressChanged();
            }
        }
        private global::System.String _DeliveryNotificationAddress;
        partial void OnDeliveryNotificationAddressChanging(global::System.String value);
        partial void OnDeliveryNotificationAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.Int32 _Status;
        partial void OnStatusChanging(global::System.Int32 value);
        partial void OnStatusChanged();

        #endregion
    
    }

    #endregion
    
}
