using MediatR;

namespace UsersMicroservices.Domain.CQRS;

internal interface IQueryHandler<in TQuery, TResponse>
    : IRequestHandler<TQuery, TResponse>
    where TQuery: IQuery<TResponse>
    where TResponse : notnull
{
    
}