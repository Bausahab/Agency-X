namespace Models.Logic
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
        Returned,
        PaymentDue,
        Paid,
        AdvanceReceived,
        PostPayment,
        Cancelled
    }
    public enum QuantityType
    {
        Opening,
        Closing,
        Running

    }
    public enum StockAction
    {
        Purchase,
        Sale
    }
}