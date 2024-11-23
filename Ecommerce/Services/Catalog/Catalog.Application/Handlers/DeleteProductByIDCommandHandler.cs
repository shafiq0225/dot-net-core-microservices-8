using Catalog.Application.Commands;
using Catalog.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Handlers
{
    public class DeleteProductByIDCommandHandler : IRequestHandler<DeleteProductByIdCommand, bool>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductByIDCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(DeleteProductByIdCommand request, CancellationToken cancellationToken)
        {
            return await _productRepository.DeleteProduct(request.Id);
        }
    }
}
