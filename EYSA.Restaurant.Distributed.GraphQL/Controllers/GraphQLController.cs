using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using Common.Distributed.GraphQL;
using Common.Distributed.GraphQL.Models;

namespace EYSA.Restaurant.Distributed.GraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphQLController : GraphQLControllerBase
    {
        public GraphQLController(IDocumentExecuter documentExecuter, ISchema schema) : base(documentExecuter, schema)
        {

        }
    }
}
