﻿using System;

namespace FoundFlow.Application.Common.Feature.Transactions.Create;

public sealed class CreateTransactionResponse
{
    public CreateTransactionResponse(Guid transactionId, bool succeeded = true)
    {
        Succeeded = succeeded;
        TransactionId = transactionId;
    }

    public Guid TransactionId { get; }
    public bool Succeeded { get; }
}
