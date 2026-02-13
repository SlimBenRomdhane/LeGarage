 using LeGarage.Core.Common;
 using System;
 using System.Collections.Generic;

 namespace LeGarage.Core.Entities;

 public class PaymentAllocation : BaseEntity
 {
    public int InvoiceId { get; set; }

    public int PaymentId { get; set; }

    public int PaymentAllocationId { get; set; }

    public decimal? AmountAllocated { get; set; }

     public Invoice? Invoice { get; set; }

     public Payment? Payment { get; set; }
 }
