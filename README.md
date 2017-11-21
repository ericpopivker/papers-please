# Papers Please
It is one and only Authorization library for .NET


Lets say you are writing an enterprise level application (or any application a bit more complex then "Hello World"), where you would like some granular controls over permissions to user operations as well as data.  You will look for something made my MS first. You will find Identity/Memberhip framework that is pretty simple to get to work out of the box, but requires all kinda hacking for handling complex permission.  Then you will look for NuGet libs dealing wiht Authorization.  There are many projects that deal with Authentication, but somehow Authorization was left behind.  That is till PapersPlease.



# Sample usage

## Declaring Permission Set Template

First thing you want to do is declare a PermissionSetTemplate where you will define Modules, Resources and Operations for your system.


```
    
    var permissionSetTemplateDto = 
      new PermissionSetTemplateDto
      {
                      
                      
      }
   }
                      
    
    
    _permissionSetTemplateService(PermissionSetTemplateDto permissionSetTemplateDto);
    
     

```

        PermissionSetTemplateService.Create(PermissionSetTemplateDto );

       PermissionSetTemplateDto
                     Id (optional will generate)
                     Module
                                Id
                                Name

                                Resources
                                        Id        (must be unique withn Module)
                                        Name

                                        Operations
                                                  Id               (must be unique within Resource)
                                                  Name


        PermissionSetService.Create(new PermissionSet());
                  Id (pass or it will generate one)
                  List OperationPermissions(ModuleId, ResourceId, OperationId)
                  List DataPermissions(ModuleId, ResourceId, ResourceEntityId)


                  PermissionSetTemplateId
}

[OperationAuthorize("Store", "Product")]
ProductController()

MVC COntroller
[DataAuthorize("Store", "Product")]
{
          look for any value like productId and validate it
}

Query EF

ResourceQuery

