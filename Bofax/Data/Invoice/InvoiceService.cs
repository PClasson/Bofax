using System;
using System.IO;
using Bofax.Data.Invoice;
using RazorEngine;
using RazorEngine.Templating;

public static class InvoiceService
{
    public static string RunCompile(InvoiceModel invoiceModel)
    {
        var relative = Path.Combine(Environment.CurrentDirectory, "Templates\\Invoice\\Invoice.cshtml");
        var templateSource = new LoadedTemplateSource(File.ReadAllText(relative), relative);
        return Engine.Razor.RunCompile(templateSource, "Invoice.cshtml", null, invoiceModel);
    }
}