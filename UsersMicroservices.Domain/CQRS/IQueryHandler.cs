﻿using MediatR;

namespace UsersMicroservices.Domain.CQRS;

public interface IQueryHandler<in TQuery, TResponse>
    : IRequestHandler<TQuery, TResponse>
    where TQuery: IQuery<TResponse>
    where TResponse : notnull
{
    
}