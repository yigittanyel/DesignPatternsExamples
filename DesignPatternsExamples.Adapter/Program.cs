var transaction = new TransferTransaction() { Amount = 10, FromIBAN = "1", ToIBAN = "2" };
var jsonAdapter = new JsonBankApiAdapter();
var xmlAdapter = new XmlBankApiAdapter();

var result = jsonAdapter.ExecuteTransaction(transaction);

Console.WriteLine("Result: "+result);
Console.ReadLine();


interface IBankApi
{
    bool ExecuteTransaction(TransferTransaction transaction);
}

class XmlBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var xml = $"""
                <TransferTransaction>
                    <FromIBAN> {transaction.FromIBAN} </FromIBAN>
                    <ToIBAN> {transaction.ToIBAN} </ToIBAN>
                    <Amount> {transaction.Amount} </Amount>
                </TransferTransaction>
            """;

        Console.WriteLine($"{GetType().Name} worked");
        Console.WriteLine(xml);
        return true;
    }
}

class JsonBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var json = $$""""
                {
                    ""FromIBAN"": ""{{transaction.FromIBAN}}"",
                    ""ToIBAN"": ""{{transaction.ToIBAN}}"",
                    ""Amount"": ""{{transaction.Amount:C2}}""
                }
            """";


        Console.WriteLine($"{GetType().Name} worked");
        Console.WriteLine(json);
        return true;
    }
}

class JsonBankApiAdapter : IBankApi
{
    private readonly JsonBankApi _jsonBankApi;

    public JsonBankApiAdapter()
    {
        _jsonBankApi = new JsonBankApi();
    }
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return _jsonBankApi.ExecuteTransaction(transaction);
    }
}

class XmlBankApiAdapter : IBankApi
{
    private readonly XmlBankApi _xmlBankApi;

    public XmlBankApiAdapter()
    {
        _xmlBankApi = new XmlBankApi();
    }
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return _xmlBankApi.ExecuteTransaction(transaction);
    }
}

class TransferTransaction
{
    public string FromIBAN { get; set; }
    public string ToIBAN { get; set; }
    public decimal Amount { get; set; }
}
