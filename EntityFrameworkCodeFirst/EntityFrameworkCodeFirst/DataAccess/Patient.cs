//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkCodeFirst.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public Patient()
        {
            this.tblOrders = new HashSet<Order>();
        }
    
        public int PatientID { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string TrackingNo { get; set; }
        public int CCACID { get; set; }
        public Nullable<int> PatCWId { get; set; }
        public Nullable<int> FHTId { get; set; }
        public Nullable<int> Demographic1ID { get; set; }
        public Nullable<int> Demographic2ID { get; set; }
        public string DrugCard { get; set; }
        public string PatientOHIP { get; set; }
        public string Salutation { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public Nullable<System.DateTime> PatientSince { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string SpecialInstructions { get; set; }
        public string Status { get; set; }
        public string Diagnosis { get; set; }
        public Nullable<int> DeliveryAreaID { get; set; }
        public string DeliveryNote { get; set; }
        public string NotificationMethod { get; set; }
        public string EmailAddress { get; set; }
    
        public virtual ICollection<Order> tblOrders { get; set; }
    }
}