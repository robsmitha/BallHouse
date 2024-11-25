﻿using Elysian.Application.Exceptions;
using Elysian.Application.Features.Merchants.Commands;
using Elysian.Application.Features.Merchants.Models;
using Elysian.Application.Features.Merchants.Queries;
using ElysianFunctions.Middleware;
using MediatR;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace ElysianFunctions
{
    public class ProductFunctions(IMediator mediator)
    {
        [Function("GetProducts")]
        public async Task<HttpResponseData> GetProducts([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var products = await mediator.Send(new GetProductsQuery());
            return await req.WriteJsonResponseAsync(products);
        }

        [Function("GetProduct")]
        public async Task<HttpResponseData> GetProduct([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            if (!int.TryParse(req.Query["productId"], out var productId))
            {
                throw new CustomValidationException();
            }

            var (product, images) = await mediator.Send(new GetProductQuery(productId));

            return product == null
                ? throw new NotFoundException()
                : await req.WriteJsonResponseAsync(new
                {
                    product,
                    images
                });
        }

        [Function("GetProductBySerialNumber")]
        public async Task<HttpResponseData> GetProductBySerialNumber([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var serialNumber = req.Query["serialNumber"];

            var (product, imageUris) = await mediator.Send(new GetProductBySerialNumberQuery(serialNumber));

            return product == null
                ? throw new NotFoundException()
                : await req.WriteJsonResponseAsync(new
                {
                    product,
                    imageUris
                });
        }

        [Function("SaveProduct")]
        public async Task<HttpResponseData> SaveProduct([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestData req)
        {
            var saveProduct = await req.DeserializeBodyAsync<SaveProductRequest>();
            var product = await mediator.Send(new SaveProductCommand(saveProduct));

            return await req.WriteJsonResponseAsync(product);
        }
        public record DeleteProductRequest(int ProductId);
        [Function("DeleteProduct")]
        public async Task<HttpResponseData> DeleteProduct([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestData req)
        {
            var deleteProduct = await req.DeserializeBodyAsync<DeleteProductRequest>();

            await mediator.Send(new DeleteProductCommand(deleteProduct.ProductId));

            // TODO: Create timer trigger that deletes images from azure

            return await req.WriteJsonResponseAsync(new
            {
                success = true
            });
        }
        public record DeleteProductImageRequest(int ProductImageId);
        [Function("DeleteProductImage")]
        public async Task<HttpResponseData> DeleteProductImage([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestData req)
        {
            var deleteProductImage = await req.DeserializeBodyAsync<DeleteProductImageRequest>();

            await mediator.Send(new DeleteProductImageCommand(deleteProductImage.ProductImageId));

            return await req.WriteJsonResponseAsync(new
            {
                success = true
            });
        }
    }
}
