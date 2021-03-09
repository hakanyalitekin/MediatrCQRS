using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrCQRS.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            // DB'den Product'ın getirilmesi işlemleri.

            var viewModel = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
            return Task.FromResult(viewModel);
        }
    }
}
