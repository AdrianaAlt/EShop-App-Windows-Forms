using MAS_WinFormsApp.DTO;
using MAS_WinFormsApp.Models.Items;
using MAS_WinFormsApp.Models.Order;
using System.Data.Entity.Validation;

namespace MAS_WinFormsApp.Services
{
    public class EShopDBRepository
    {
        private EShopContext _context;

        public EShopDBRepository()
        {
            _context = new EShopContext();
            GetCustomer("email@gmail.com");
        }

        /*
        public ICustomerDTO? GetCustomer(int id)
        {
            var customer = _context.Customers.Include("DeliveryAddress").Where(customer => customer.CustomerId == id).SingleOrDefault();
            if (customer == null) throw new System.Exception($"[System] Wrong operation: There is no customers with id = {id}");

            return new CustomerDTO()
            {
                CustomerId = customer.CustomerId,
                CustomerName = customer.CustomerName,
                Email = customer.Email,
                Password = customer.Password,
                Status = customer.CurrentCustomerStatus,
                DeliveryAddress = new AddressDTO()
                {
                    Id = customer.DeliveryAddress.Id,
                    City = customer.DeliveryAddress.City,
                    Country = customer.DeliveryAddress.Country,
                    Street = customer.DeliveryAddress.Street,
                    StreetNumber = customer.DeliveryAddress.StreetNumber,
                    PostalCode = customer.DeliveryAddress.Postcode
                },
                CustomerOrders = customer.Orders.Select(o => new OrderDTO()
                {
                    Id = o.Id,
                    Status = o.Status,
                    OrderDate = o.OrderDate
                }).ToHashSet(),
            };
        }*/
        // find customer by email (unique required property)
        public ICustomerDTO? GetCustomer(string email)
        {
            var customer = _context.Customers.Include("DeliveryAddress").Include("Orders").SingleOrDefault(c => c.Email.ToLower().Equals(email.ToLower()));
            if (customer == null) return null;

            return new CustomerDTO()
            {
                CustomerId = customer.CustomerId,
                CustomerName = customer.CustomerName,
                Email = customer.Email,
                Status = customer.CurrentCustomerStatus,
                DeliveryAddress = new AddressDTO()
                {
                    Id = customer.DeliveryAddress.Id,
                    City = customer.DeliveryAddress.City,
                    Country = customer.DeliveryAddress.Country,
                    Street = customer.DeliveryAddress.Street,
                    StreetNumber = customer.DeliveryAddress.StreetNumber,
                    PostalCode = customer.DeliveryAddress.Postcode
                },
                CustomerOrders = customer.Orders.Select(o => new OrderDTO()
                {
                    Id = o.Id,
                    Status = o.Status,
                    OrderDate = o.OrderDate
                }).ToHashSet(),
            };
        }
        // customer try to login
        public ICustomerDTO? GetCustomer(string email, string password)
        {
            var customer = _context.Customers.Include("DeliveryAddress").Include("Orders").SingleOrDefault(c => c.Email.ToLower().Equals(email.ToLower()) && c.Password.Equals(password));
            // if found customer's log in attempt will be accepted
            if (customer == null) return null;

            return new CustomerDTO()
            {
                CustomerId = customer.CustomerId,
                Email = customer.Email,
                Password = customer.Password,
                Status = customer.CurrentCustomerStatus,
                DeliveryAddress = new AddressDTO()
                {
                    Id = customer.DeliveryAddress.Id,
                    City = customer.DeliveryAddress.City,
                    Country = customer.DeliveryAddress.Country,
                    Street = customer.DeliveryAddress.Street,
                    StreetNumber = customer.DeliveryAddress.StreetNumber,
                    PostalCode = customer.DeliveryAddress.Postcode
                },
                CustomerName = customer.CustomerName,
                CustomerOrders = customer.Orders.Select(o => new OrderDTO()
                {
                    Id = o.Id,
                    Status = o.Status,
                    OrderDate = o.OrderDate
                }).ToHashSet(),
            };
        }

        // get all items from the items list
        public ICollection<ItemDTO> GetItems()
        {
            var items = _context.Items.Include("WarehouseItems").ToList();
            return items
                .Select(item => new ItemDTO()
                {
                    Id = item.Id,
                    UpcCode = item.UpcCode,
                    ItemType = item.Type,
                    ItemName = item.ItemName,
                    Description = item.Description,
                    UnitPrice = item.UnitPrice,
                    SpecificInfo = item.SpecificInfo,
                    WarehouseItems = item.WarehouseItems.Select(wi => new WarehouseItemDTO()
                    {
                        Id = wi.Id,
                        Quantity = wi.ItemQuantity
                    }).ToList(),
                }).ToList();
        }
        // get item by UPC (unique property)
        public ItemDTO GetItem(string upcCode)
        {
            var item = _context.Items.Include("WarehouseItems").FirstOrDefault(i => i.UpcCode.Equals(upcCode));
            // check if item with upc code doesn't exist
            if (item == null)
                throw new System.Exception($"[System] Wrong operation: There is no item with upc = {upcCode}");
            return new ItemDTO()
            {
                Id = item.Id,
                UpcCode = item.UpcCode,
                ItemType = item.Type,
                SpecificInfo = item.SpecificInfo,
                ItemName = item.ItemName,
                Description = item.Description,
                UnitPrice = item.UnitPrice,
                WarehouseItems = item.WarehouseItems.Select(wi => new WarehouseItemDTO()
                {
                    Id = wi.Id,
                    Quantity = wi.ItemQuantity
                }).ToList(),
            };
        }

        // get items with quantity (count items stored in warehouses) > 0
        public ICollection<ItemDTO> GetAvailableItems()
        {
            var allItems = GetItems();
            var availableItems = allItems
                .Where(item => item.CommonQuantity > 0)
                .ToList();
            return availableItems;
        }

        // get customer order history
        public ICollection<OrderDTO> GetOrders(ICustomerDTO customer)
        {
            var orders = _context.Orders.Include("OrderLines").Where(c => c.CustomerId == customer.CustomerId).ToList();
    
            var res = orders.Select(order =>
                new OrderDTO()
                {
                    Id = order.Id,
                    OrderDate = order.OrderDate,
                    Status = order.Status,
                    OrderLines = order.OrderLines.Select(ol => new OrderLineDTO()
                    {
                        Id = ol.Id,
                        Item = new ItemDTO()
                        {
                            Id = ol.Item.Id,
                            ItemName = ol.Item.ItemName,
                            ItemType = ol.Item.Type,
                            UnitPrice = ol.Item.UnitPrice,
                            UpcCode = ol.Item.UpcCode,
                            Description = ol.Item.Description,
                            SpecificInfo = ol.Item.SpecificInfo
                        },
                        Order = new OrderDTO()
                        {
                            Id = ol.Order.Id,
                            OrderDate = ol.Order.OrderDate,
                            Status = ol.Order.Status,
                        },
                        ItemQuantity = ol.Quantity
                    }).ToList(),
                }
            ).ToList();
            return res;
        }

        // get order by ID
        public OrderDTO GetOrder(int id)
        {
            var order = _context.Orders
                .Include("OrderLines")
                .Include("Orderlines.Item")
                .Include("Customer")
                .Include("Customer.DeliveryAddress")
                .SingleOrDefault(c => c.Id == id);
            if (order == null)
                throw new System.Exception($"[System] Wrong operation: There is no orders with id = {id}");
            return new OrderDTO()
            {
                Id = order.Id,
                Customer = new CustomerDTO()
                {
                    CustomerId = order.CustomerId,
                    Email = order.Customer.Email,
                    Status = order.Customer.CurrentCustomerStatus,
                    CustomerName = order.Customer.CustomerName,
                    DeliveryAddress = new AddressDTO()
                    {
                        Id = order.Customer.DeliveryAddress.Id,
                        City = order.Customer.DeliveryAddress.City,
                        Country = order.Customer.DeliveryAddress.Country,
                        Street = order.Customer.DeliveryAddress.Street,
                        StreetNumber = order.Customer.DeliveryAddress.StreetNumber,
                        PostalCode = order.Customer.DeliveryAddress.Postcode
                    },

                },
                OrderDate = order.OrderDate, 
                Status = order.Status,
                OrderLines = order.OrderLines.Select(ol => new OrderLineDTO()
                {
                    Id = ol.Id,
                    Item = new ItemDTO()
                    {
                        Id = ol.Item.Id,
                        ItemName = ol.Item.ItemName,
                        ItemType = ol.Item.Type,
                        UnitPrice = ol.Item.UnitPrice,
                        UpcCode = ol.Item.UpcCode,
                        Description = ol.Item.Description,
                        SpecificInfo = ol.Item.SpecificInfo
                    },
                    ItemQuantity = ol.Quantity
                }).ToList(),
            };
        }
        // creation of empty order 
        public OrderDTO CreateOrder(ICustomerDTO orderOwner)
        {
            var customer = _context.Customers.Where(c => c.CustomerId == orderOwner.CustomerId).SingleOrDefault();
            if (customer == null)
                throw new Exception($"[System] Wrong operation: There is no customers with id = {orderOwner.CustomerId}");
            var order = new CustomerOrder(customer);

            _context.Orders.Add(order);
            _context.SaveChanges();

            return new OrderDTO()
            {
                Id = order.Id,
                OrderDate = null,
                Customer = orderOwner,
                OrderLines = new List<OrderLineDTO>()
            };
        }
        // order placement after adding of at least one order line
        public bool PlaceOrder(OrderDTO order)
        {
            try
            {
                var orderToUpdate = _context.Orders.Include("OrderLines").Include("OrderLines.Item").Include("OrderLines.Item.WarehouseItems").Include("OrderLines.Item.WarehouseItems.WarehouseStorage").SingleOrDefault(o => o.Id == order.Id);
                orderToUpdate.PlaceOrder();

                _context.WarehouseItems.RemoveRange(_context.WarehouseItems.ToList().Where(wi => wi.WarehouseStorage == null || wi.StoredItem == null).ToList());
                _context.SaveChanges();

                order.Status = orderToUpdate.Status;
                order.OrderDate = orderToUpdate.OrderDate;
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
                return false;
            }
        }

        // all created but not placed orders must be cancelled after customers leave order creation form
        public bool CancelOrder(OrderDTO order)
        {
            var orderToCancel = _context.Orders.SingleOrDefault(o => o.Id == order.Id);
            if (orderToCancel == null) return false;

            orderToCancel.CancelOrder();
            order.Status = OrderStatus.Cancelled;
            _context.SaveChanges();
            return true;
        }

        //order line creation
        public bool AddItemToOrder(OrderDTO order, ItemDTO item, int quantity)
        {
            try
            {
                var orderToUpdate = _context.Orders
                    .SingleOrDefault(o => o.Id == order.Id);
                var itemToAdd = _context.Items.Include("WarehouseItems")
                    .SingleOrDefault(i => i.Id == item.Id);

                if (itemToAdd.WarehouseItems.Sum(el => el.ItemQuantity) < quantity) return false;

                if (!orderToUpdate.OrderLines.Any(el => el.Item.UpcCode.Equals(itemToAdd.UpcCode)))
                {
                    // create new order line if not exists
                    var ol = OrderLine.CreateOrderLine(orderToUpdate, itemToAdd, quantity);
                    _context.SaveChanges();
                    order.OrderLines.Add(new OrderLineDTO()
                    {
                        Id = ol.Id,
                        Item = new ItemDTO()
                        {
                            Id = ol.Item.Id,
                            ItemName = ol.Item.ItemName,
                            ItemType = ol.Item.Type,
                            UnitPrice = ol.Item.UnitPrice,
                            UpcCode = ol.Item.UpcCode,
                            Description = ol.Item.Description,
                            SpecificInfo = ol.Item.SpecificInfo
                        },
                        Order = new OrderDTO()
                        {
                            Id = ol.Order.Id,
                            OrderDate = ol.Order.OrderDate,
                            Status = ol.Order.Status,
                        },
                        ItemQuantity = ol.Quantity
                    });
                }
                else
                {
                    // update order line, because this item has already been added: change item's quantity
                    var orderLineToUpdate = orderToUpdate.OrderLines.SingleOrDefault(el => el.Item.UpcCode.Equals(itemToAdd.UpcCode));
                    orderLineToUpdate.Quantity = quantity;
                    _context.SaveChanges();

                    order.OrderLines.SingleOrDefault(el => el.Item.UpcCode.Equals(item.UpcCode)).ItemQuantity = quantity;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool RemoveItemFromOrder(OrderDTO order, OrderLineDTO orderLine)
        {
            try
            {
                var orderToUpdate = _context.Orders.Include("OrderLines").SingleOrDefault(o => o.Id == order.Id);
                var orderLineToRemove = _context.OrderLines.Include("Order").SingleOrDefault(ol => ol.OrderId == order.Id && ol.ItemId == orderLine.Item.Id );

                orderToUpdate.RemoveOrderLine(orderLineToRemove);
                _context.OrderLines.Remove(orderLineToRemove);
                _context.SaveChanges();
                order.OrderLines.Remove(orderLine);

                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
