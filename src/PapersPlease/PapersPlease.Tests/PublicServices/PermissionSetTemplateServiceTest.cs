using System.Collections.Generic;
using NUnit.Framework;
using PapersPlease.Entities;

namespace PapersPlease.Tests.PublicServices
{
    [TestFixture]
    public class PermissionSetTemplateServiceTest
    {

        [Test]
        public void Create_When_for_basic_user_Then_creates_and_saves()
        {
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
        }


        [Test]
        public void Create_When_for_category_manager_Then_creates_and_saves()
        {
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
        }
    }
}
