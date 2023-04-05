using E_Commerce.Data.Enums;
using E_Commerce.Models;

namespace E_Commerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicescope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


              
                //Computers

                if (!context.Computer.Any())
                {
                    context.Computer.AddRange(new List<ComputerModel>()
                    {
                        new ComputerModel()
                        {
                            Name = "Desktops 1",
                            SeriesPictureURL = "http",
                            Description = "This was some",
                            ImageURL = "http"

                        },
                        new ComputerModel()
                        {
                            Name = "NoteBooks 1",
                            SeriesPictureURL = "http",
                            Description = "This was some",
                            ImageURL = "http"
                        }
                    });
                    context.SaveChanges();
                }

                //Computer Series

                if (!context.ComputerSeries.Any())
                {
                    context.ComputerSeries.AddRange(new List<ComputerSeriesModel>()
                    {
                        new ComputerSeriesModel()
                        {
                            Name = "Business Plus 1",
                            Description = "This was some"

                        },
                        new ComputerSeriesModel()
                        {
                            Name = "Home Premium 1",
                            Description = "This was some"
                        }
                    });
                    context.SaveChanges();
                }

                //Configuration

                if (!context.Configuration.Any())
                {
                    context.Configuration.AddRange(new List<ConfigurationModel>()
                    { 
                         new ConfigurationModel()
                         {
                             Name = "Antivirus Software 1",
                             Description = "This was some",
                             Price = 100,

                         },
                        new ConfigurationModel()
                        {
                            Name = "OS 1",
                            Description = "This was some",
                            Price = 200
                        }
                    });
                context.SaveChanges();
                }

                //Customer

                if (!context.Customer.Any())
                {
                    context.Customer.AddRange(new List<CustomerModel>()

                    {
                        new CustomerModel()
                        {
                            Email = "Muhammedhshaheer13@gmail.com",
                            Password = 123,
                            FirstName = "Muhammedh",
                            LastName = "Shaheer",
                            PhoneNumber = "123"

                        },
                        new CustomerModel()
                        {
                            Email = "Zeenathilmara34@gmail.com",
                            Password = 123,
                            FirstName = "Zeenath",
                            LastName = "Ilma",
                            PhoneNumber = "123"
                        }
                    });
                    context.SaveChanges();
                }

                    //Order

                if (!context.Order.Any())
                {
                    context.Order.AddRange(new List<OrderModel>()

                    { 
                        new OrderModel()
                        {
                            OrderDate = "DayOfWeek.Monday",
                            ShippingAddress = " blacc",
                            BillingAddress = " blacc",
                            ShippingMethod = " jdsf",
                            Price = 100,
                            OrderStatusId = 1,
                            CustomerId = 1,
                            ComputerModelId = 2,
                            CustomerName = "asjdbh"



                        },
                        new OrderModel()
                        {
                            OrderDate = "DayOfWeek.Monday",
                            ShippingAddress = " blacc",
                            BillingAddress = " blacc",
                            ShippingMethod = " jdsf",
                            Price = 100,
                            OrderStatusId = 1,
                            CustomerId = 1,
                            ComputerModelId = 2,
                            CustomerName = "asjdbh"
                        }
                    });
                context.SaveChanges();
                }

                //Order Status

               if (!context.OrderStatus.Any())
                {
                    context.OrderStatus.AddRange(new List<OrderStatusModel>()

                        {
                         new OrderStatusModel()
                         {
                             Name = "Success",
                             Description = "This was some"
                             

                         },
                        new OrderStatusModel()
                        {
                            Name = "Delivered",
                            Description = "This was some"
                           
                        }
                    });
                    context.SaveChanges();
                }

                //Product

                if (!context.ProductCategories.Any())
                {
                    context.ProductCategories.AddRange(new List<ProductCategoryModel>()

                        {
                         new ProductCategoryModel()
                         {
                            Name = "bla 1",
                            ImageURL = "http",
                            Description = "This was some",
                            ProductCategory = ProductCategory.Computers
                         },
                        new ProductCategoryModel()
                        {
                            Name = "bla 2",
                            ImageURL = "http",
                            Description = "This was some",
                            ProductCategory = ProductCategory.Motherbords
                        },
                        new ProductCategoryModel()
                        {
                            Name = "bla 3",
                            ImageURL = "http",
                            Description = "This was some",
                            ProductCategory = ProductCategory.Memory
                        },
                        new ProductCategoryModel()
                        {
                            Name = "bla 4",
                            ImageURL = "http",
                            Description = "This was some",
                            ProductCategory = ProductCategory.Processors
                        },
                        new ProductCategoryModel()
                        {
                            Name = "bla 5",
                            ImageURL = "http",
                            Description = "This was some",
                            ProductCategory = ProductCategory.AntivirusSoftwares
                        }
                    });
                    context.SaveChanges();

                }

                    //ComputersModelsModel

                    if (!context.ComputerModels.Any())
                    {
                        context.ComputerModels.AddRange(new List<ComputerModelsModel>()
                    {
                        new ComputerModelsModel()
                        {
                            ComputerCategoryId = 1,
                            ComputerSeriesId = 2,
                            ComputerModelId = 3,
                            OrderStatusId = 4,
                            CustomerId = 5
                        },
                        new ComputerModelsModel()
                        {
                            ComputerCategoryId = 2,
                            ComputerSeriesId = 3,
                            ComputerModelId = 4,
                            OrderStatusId = 5,
                            CustomerId = 6
                        }
                    });


                        context.SaveChanges();
                    }

                }

            }
        }
    }
   