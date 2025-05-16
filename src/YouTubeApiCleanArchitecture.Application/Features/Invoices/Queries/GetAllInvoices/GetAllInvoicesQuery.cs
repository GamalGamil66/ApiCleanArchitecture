﻿using YouTubeApiCleanArchitecture.Application.Abstraction.Messaging.Queries;

namespace YouTubeApiCleanArchitecture.Application.Features.Invoices.Queries.GetAllInvoices;
public record GetAllInvoicesQuery : IQuery<InvoiceResponseCollection>;