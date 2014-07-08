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

namespace EntityFrameworkTest
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ContactsDb : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ContactsDb object using the connection string found in the 'ContactsDb' section of the application configuration file.
        /// </summary>
        public ContactsDb() : base("name=ContactsDb", "ContactsDb")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ContactsDb object.
        /// </summary>
        public ContactsDb(string connectionString) : base(connectionString, "ContactsDb")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ContactsDb object.
        /// </summary>
        public ContactsDb(EntityConnection connection) : base(connection, "ContactsDb")
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
        public ObjectSet<Contact> Contacts
        {
            get
            {
                if ((_Contacts == null))
                {
                    _Contacts = base.CreateObjectSet<Contact>("Contacts");
                }
                return _Contacts;
            }
        }
        private ObjectSet<Contact> _Contacts;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Contacts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContacts(Contact contact)
        {
            base.AddObject("Contacts", contact);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Contact")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Contact : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Contact object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        public static Contact CreateContact(global::System.Int32 id)
        {
            Contact contact = new Contact();
            contact.id = id;
            return contact;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String fname
        {
            get
            {
                return _fname;
            }
            set
            {
                OnfnameChanging(value);
                ReportPropertyChanging("fname");
                _fname = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("fname");
                OnfnameChanged();
            }
        }
        private global::System.String _fname;
        partial void OnfnameChanging(global::System.String value);
        partial void OnfnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String lname
        {
            get
            {
                return _lname;
            }
            set
            {
                OnlnameChanging(value);
                ReportPropertyChanging("lname");
                _lname = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("lname");
                OnlnameChanged();
            }
        }
        private global::System.String _lname;
        partial void OnlnameChanging(global::System.String value);
        partial void OnlnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String phone
        {
            get
            {
                return _phone;
            }
            set
            {
                OnphoneChanging(value);
                ReportPropertyChanging("phone");
                _phone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("phone");
                OnphoneChanged();
            }
        }
        private global::System.String _phone;
        partial void OnphoneChanging(global::System.String value);
        partial void OnphoneChanged();

        #endregion
    
    }

    #endregion
    
}
