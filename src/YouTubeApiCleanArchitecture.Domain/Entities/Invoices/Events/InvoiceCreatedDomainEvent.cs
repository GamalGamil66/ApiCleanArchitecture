﻿using YouTubeApiCleanArchitecture.Domain.Abstraction.DomainEvents;

namespace YouTubeApiCleanArchitecture.Domain.Entities.Invoices.Events;
public record InvoiceCreatedDomainEvent(
    Guid InvoiceId) : IDomainEvent;