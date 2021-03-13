using System;
using GraphQL.Types;
using GraphQL.Utilities;

namespace GraphQl
{
    public class AppSchema:Schema
    {
        public AppSchema(IServiceProvider provider):base(provider)
        {
            Query=provider.GetRequiredService<AppQuery>();
        }
    }
}