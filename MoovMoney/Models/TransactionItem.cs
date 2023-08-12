using System;

namespace MoovMoney.Models;

public class TransactionItem
{
    public string TransactionTarget { get; set; }
    public DateTime TransactionTime { get; set; }
    public TransactionType TransactionType { get; set; }
    public int Value { get; set; }
}

public enum TransactionType
{
    MoneyTransfer ,
    TopUpCredit,
    CashIn,
    CashOut
}
