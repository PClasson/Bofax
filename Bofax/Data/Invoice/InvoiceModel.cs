using System.Collections.Generic;

namespace Bofax.Data.Invoice
{
    public class InvoiceModel
    {
        public Customer Customer { get; set; }
        public Sender Sender { get; set; }
        public string Month { get; set; }
        public string CreateDate { get; set; }
        public string DueDate { get; set; }
        public List<InvoiceRowModel> Rows { get; set; }
        public decimal Sum { get; set; }
        public decimal AmountToPay { get; set; }
    }

    public class InvoiceRowModel
    {
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
    }

    public enum Month
    {
        JANUARI = 1,
        FEBRUARI = 2,
        MARS = 3,
        APRIL = 4,
        MAJ = 5,
        JUNI = 6,
        JULI = 7,
        AUGUSTI = 8,
        SEPTEMBER = 9,
        OKTOBER = 10,
        NOVEMBER = 11,
        DECEMBER = 12
    }
}