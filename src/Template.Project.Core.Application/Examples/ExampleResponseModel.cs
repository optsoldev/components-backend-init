using System;
using Optsol.Components.Application.DataTransferObjects;

namespace Template.Project.Core.Application.Examples;

public class ExampleResponseModel: BaseModel
{
    public Guid Id { get; set; }
    
    public override void Validate()
    {
        //TODO: Validations
    }
}