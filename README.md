# Papers Please
It is one and only Authorization library for .NET


Lets say you are writing an enterprise level application (or any application a bit more complex then "Hello World"), where you would like some granular controls over permissions to user operations as well as data.  You will look for something made my MS first. You will find Identity/Memberhip framework that is pretty simple to get to work out of the box, but requires all kinda hacking for handling complex permission.  Then you will look for NuGet libs dealing wiht Authorization.  There are many projects that deal with Authentication, but somehow Authorization was left behind.  That is till PapersPlease.



# Sample usage

## Declaring Permission Set Template

First thing you want to do is declare a PermissionSetTemplate where you will define Modules, Resources and Operations for your system.


```
            var service = new PermissionSchemaService();
            service.Create(new PermissionSchema
            {
                Id = "UserTemplate",  //has all permissions
                Modules = new List<Module>
                {
                    new Module("Store",
                        new List<Resource>
                        {
                            new Resource("Product",
                                new List<Operation>
                                {
                                    new Operation(CommonOperation.Crud),
                                    new Operation("AddInventory")
                                }),

                            new Resource("Category",
                                new List<Operation>
                                {
                                    new Operation(CommonOperation.Crud)
                                }),

                            new Resource("Reports",
                                new List<Operation>
                                {
                                    new Operation(CommonOperation.Read)
                                })

                        })
                }
            });
            
```
