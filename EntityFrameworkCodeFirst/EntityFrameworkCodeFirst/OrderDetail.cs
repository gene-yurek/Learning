//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkCodeFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int LineID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string CCACSKU { get; set; }
        public int Quantity { get; set; }
        public Nullable<bool> GSTPayable { get; set; }
        public decimal GST_Amount { get; set; }
        public bool PSTPayable { get; set; }
        public decimal PST_Amount { get; set; }
        public decimal SellingPrice_ { get; set; }
        public Nullable<decimal> CostPrice_ { get; set; }
        public Nullable<int> BOQty { get; set; }
        public Nullable<System.DateTime> BOExpectedDate { get; set; }
        public Nullable<System.DateTime> BODeliveryDate { get; set; }
        public string BOReason { get; set; }
        public string BONewInvoiceNo { get; set; }
        public Nullable<System.DateTime> BONewInvoiceDate { get; set; }
        public Nullable<int> CCACLineID { get; set; }
        public Nullable<bool> ConfirmationFlag { get; set; }
        public Nullable<bool> BackOrderFlag { get; set; }
        public string OrderDetailComments { get; set; }
        public string ItemUnitCode { get; set; }
        public string OrderDetailClass { get; set; }
        public Nullable<System.DateTime> DateDelivered { get; set; }
        public string PMIOrderType { get; set; }
        public string BillingTag { get; set; }
        public string BillingStatus { get; set; }
        public Nullable<int> BillInvoiceRef { get; set; }
        public Nullable<bool> ynNotCollectible { get; set; }
        public string SAFReasonCode { get; set; }
        public Nullable<int> PMILinkID { get; set; }
        public Nullable<decimal> MinRentalDetail { get; set; }
        public string PMIRecordType { get; set; }
        public string CCACRARef { get; set; }
        public Nullable<decimal> TotalPaid { get; set; }
        public Nullable<System.DateTime> RAProcessDate { get; set; }
        public Nullable<bool> RentalCapped { get; set; }
        public Nullable<System.DateTime> SPPaymentDate { get; set; }
        public Nullable<bool> ynPaySP { get; set; }
        public Nullable<System.DateTime> dtShipmentExport { get; set; }
    }
}