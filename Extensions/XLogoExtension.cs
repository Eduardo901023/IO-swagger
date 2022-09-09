using System;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Writers;

namespace IO.Swagger.Extensions
{
    public class XLogoExtension : IOpenApiExtension
    {
        public XLogoExtension()
        {
        }

        public void Write(IOpenApiWriter writer, OpenApiSpecVersion specVersion)
        {
            writer.WriteProperty("url", "https://redocly.github.io/redoc/petstore-logo.png");
            writer.WriteProperty("alttext", "Petstore logo");
        }
    }
}
