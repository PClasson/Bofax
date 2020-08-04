﻿using System.ComponentModel.DataAnnotations;
using Blazor.IndexedDB.Framework;
using Microsoft.JSInterop;

namespace Bofax.Data
{
    public class BofaxDb : IndexedDb
    {
        public BofaxDb(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version) { }

        public IndexedSet<Customer> Customers { get; set; }
        public IndexedSet<Sender> Senders { get; set; }
        public IndexedSet<InvoiceRow> InvoiceRows { get; set; }
    }

    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
    }

    public class Sender
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceSubTitle { get; set; }
    }

    public class InvoiceRow
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal CalculatedPrice
        {
            get
            {
                return UnitPrice * Amount;
            }
        }

        [Required]
        public int CustomerId { get; set; }
    }
}