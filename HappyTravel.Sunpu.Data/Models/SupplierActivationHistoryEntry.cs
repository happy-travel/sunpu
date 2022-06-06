﻿namespace HappyTravel.Sunpu.Data.Models;

public class SupplierActivationHistoryEntry
{
    public int Id { get; set; }
    public int SupplierId { get; set; }
    public EnablementState EnablementState { get; set; }
    public string Reason { get; set; } = string.Empty;
    public DateTimeOffset Created { get; set; }
}
