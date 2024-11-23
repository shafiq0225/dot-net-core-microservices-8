using Catalog.Core.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Catalog.Application.Commands
{
    public class DeleteProductByIdCommand : IRequest<bool>
    {
        public string Id { get; set; }

        public DeleteProductByIdCommand(string id)
        {
            Id = id;
        }
    }
}
