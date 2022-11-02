using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Items;
using MAS_WinFormsApp.Models.Order;
using MAS_WinFormsApp.Models.Persons;
using MAS_WinFormsApp.Models.Warehouses;
using System.Data.Entity;
using Monitor = MAS_WinFormsApp.Models.Items.Monitor;

namespace MAS_WinFormsApp.Services
{
    public class EShopDBInitializer : DropCreateDatabaseAlways<EShopContext>
    {
        protected override void Seed(EShopContext context)
        {
            //1. Address
            Address address1 = new Address("Poland", "Warsaw", "Koszykowa", "80", "00-000");
            Address address2 = new Address("Poland", "Krakow", "Koszykowa", "89", "00-001");

            //2.Person
            //2.1 Person as Customer
            var personAscustomer1
                = new Person("Robert", "Smith", DateTime.Now.AddYears(-35), "+48732489006" , "email@gmail.com", "12345678", address1, 123456789101237L);
            var personAscustomer2
                = new Person("Thomas", "Martinson", DateTime.Now.AddYears(-27), "+48732481006" , "2email2@gmail.com", "12345678", address2, 123456789101237L);
            var customer1 = personAscustomer1.IndividualCustomer;


            //3. Items
            var tower = new ComputerTower("123456789012", "HP Slim Desktop", 433.5, "AMD Athlon Gold 3150U", 8);
            var monitor = new Monitor("223456789012", "LG 22MK430H-B", 117.9, 21.6, "Laptop with 4k screen");
            var monitor2 = new Monitor("993934789012", "LG 34WP65C-B", 486.99, 34, "Curved UltraWide QHD (3440x1440) VA Display with sRGB 99% Color Gamut");
            var monitor3 = new Monitor("777934789012", "Fiodio", 460.0, 35, "Curved Gaming Monitor with 2xHDMI 2xDisplay Ports, 178° Wide-Viewing Eye Care, Home Office and Gaming (2022 Version)");
            var keyboard = new Keyboard("323456789015", "Logitech MK570", 90, "USB");
            var keyboard2 = new Keyboard("333456789015", "Microsoft 4000", 399, "Wired", "Ergonomic Keyboard 4000 for Business. Palm lift promotes a relaxed, natural angle for your wrist.");
            var keyboard3 = new Keyboard("180456789015", "EVGA Z15 RGB", 154.89, "USB", "Powered by a 32-bit Arm Cortex-M33 core USB microprocessor supporting 4,000Hz polling rate.Offering the most advanced gaming keyboard experience");


            //4. Warehouses
            var warehouse1 = new Warehouse(address2);
            var warehouse2 = new Warehouse(address1, "HouseNowa");

            //5. Wrehouse Items
            var warehouseItem1 = new WarehouseItem(warehouse1, monitor, 50);
            var warehouseItem2 = new WarehouseItem(warehouse1, tower, 30);
            var warehouseItem3 = new WarehouseItem(warehouse2, monitor, 150);
            var warehouseItem4 = new WarehouseItem(warehouse2, tower, 300);
            var warehouseItem5 = new WarehouseItem(warehouse2, keyboard, 100);
            var warehouseItem6 = new WarehouseItem(warehouse1, keyboard2, 5);
            var warehouseItem7 = new WarehouseItem(warehouse2, keyboard3, 12);
            var warehouseItem8 = new WarehouseItem(warehouse2, monitor2, 10);
            var warehouseItem9 = new WarehouseItem(warehouse2, monitor3, 2);

            //6. Orders
            var newOrder = new CustomerOrder(customer1);
            var newOrder2 = new CustomerOrder(customer1);
            var orderLine1 = OrderLine.CreateOrderLine(newOrder2, tower, 20);
            var orderLine2 = OrderLine.CreateOrderLine(newOrder2, monitor, 30);
            newOrder.CancelOrder();
            newOrder2.PlaceOrder();


            context.Persons.Add(personAscustomer1);
            context.Persons.Add(personAscustomer2);
            context.Warehouses.Add(warehouse1);
            context.Warehouses.Add(warehouse2);
            context.Items.Add(tower);
            context.Items.Add(monitor);
            context.Items.Add(monitor2);
            context.Items.Add(monitor3);
            context.Items.Add(keyboard);
            context.Items.Add(keyboard2);
            context.Items.Add(keyboard3);

            base.Seed(context);
        }
    }
}
