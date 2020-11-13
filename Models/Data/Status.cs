namespace Models.Data
{
    public enum Status
    {
       RecNo,
       Current,
       Discontinued
    }
    public enum TransitionType
    {
        Cash,
        Cheque,
        DigitalPaymentService
    }
    public enum InvoiceType
    {
        Regular,
        Paid,
        PaymentDue,
        AdvanceReceived,       
        Cancelled
    }
   
    public enum StockType
    {
        Running,
        SaleReturned,
        Damaged

    }
    public enum ActionType
    {
        Purchase,       
        Sale
    }
    public enum ContactType
    {
        Biller,
        Employee,
        Customer,
        Business
    }
}