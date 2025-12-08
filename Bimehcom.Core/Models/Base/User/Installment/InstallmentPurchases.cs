using System;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.User.Installment
{
    public class InstallmentPurchases
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string BranchTitle { get; set; }
        public string CompanyName { get; set; }
        public string PolicyOwnerFullName { get; set; }
        public string DurationTitle { get; set; }
        public DateTime? BuyDate { get; set; }
        public long PaymentAmount { get; set; }
        public long ActualAmount { get; set; }
        public string CurrentInstallmentNumber { get; set; }
        public string Plaque { get; set; }
        public string InsuranceRequestTrackingCode { get; set; }
        public List<InstallmentPurchases_Installment> Installments { get; set; }
    }

    public class InstallmentPurchases_Installment
    {
        public Guid InstallmentPaymentId { get; set; }
        public string Title { get; set; }
        public string DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public long Amount { get; set; }
        public bool Payed { get; set; }
        public string TrackingCode { get; set; }
        public string DebitFullName { get; set; }
        public int Number { get; set; }

    }
}
