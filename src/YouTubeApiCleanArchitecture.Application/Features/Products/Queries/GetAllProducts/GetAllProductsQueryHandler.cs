﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using YouTubeApiCleanArchitecture.Application.Abstraction.Messaging.Queries;
using YouTubeApiCleanArchitecture.Domain.Abstraction;
using YouTubeApiCleanArchitecture.Domain.Abstraction.ResultPattern;
using YouTubeApiCleanArchitecture.Domain.Entities.Products;

namespace YouTubeApiCleanArchitecture.Application.Features.Products.Queries.GetAllProducts;
internal sealed class GetAllProductsQueryHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper) : IQueryHandler<GetAllProductsQuery, ProductResponseCollection>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<ProductResponseCollection>> Handle(
        GetAllProductsQuery request,
        CancellationToken cancellationToken)
    {
        var products = await _unitOfWork.Repository<Product>()
            .GetAllAsync<ProductResponse>(
                enableTracking: false,
                mapper: _mapper,
                cancellationToken: cancellationToken);
         
        var response = new ProductResponseCollection
        {
            Products = products.AsReadOnly()
        };

        return Result<ProductResponseCollection>
            .Success(response, 200);
    }
}
