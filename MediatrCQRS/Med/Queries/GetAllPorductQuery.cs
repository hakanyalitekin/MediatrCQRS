using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrCQRS.Med.Queries
{
    public class GetAllPorductQuery : IRequest<List<GetProductViewModel>>
    {

        public class GetAllPorductQueryHandler : IRequestHandler<GetAllPorductQuery, List<GetProductViewModel>>
        {
            public Task<List<GetProductViewModel>> Handle(GetAllPorductQuery request, CancellationToken cancellationToken)
            {
                List<GetProductViewModel> model = new List<GetProductViewModel>
                {
                    new GetProductViewModel(){ Id = Guid.NewGuid(), Name = "Monitör" },
                    new GetProductViewModel(){ Id = Guid.NewGuid(), Name = "Klavye" }
                };

                return Task.FromResult(model);
            }

        }
    }
}

