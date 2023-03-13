using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebApp.DevExtreme.Models;

namespace TestWebApp_DevExtreme.Models {

    public class SampleOrderWithDeliveryData
    {
        public static readonly IEnumerable<OrderWithDelivery> OrdersWithDelivery = new[] {
            new OrderWithDelivery {
                ID = 1,
                OrderNumber = 35703,
                OrderDate = DateTime.Parse("2017/04/10"),
                DeliveryDate = DateTime.Parse("2017/04/13 9:00"),
                SaleAmount = 11800,
                Terms = "15 Days",
                CustomerStoreCity = "Los Angeles, CA",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 4,
                OrderNumber = 35711,
                OrderDate = DateTime.Parse("2017/01/12"),
                DeliveryDate = DateTime.Parse("2017/01/13 9:00"),
                SaleAmount = 16050,
                Terms = "15 Days",
                CustomerStoreCity = "San Jose, CA",
                Employee = "Jim Packard"
            },
            new OrderWithDelivery {
                ID = 5,
                OrderNumber = 35714,
                OrderDate = DateTime.Parse("2017/01/22"),
                DeliveryDate = DateTime.Parse("2017/01/27 9:00"),
                SaleAmount = 14750,
                Terms = "15 Days",
                CustomerStoreCity = "Las Vegas, NV",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 7,
                OrderNumber = 35983,
                OrderDate = DateTime.Parse("2017/02/07"),
                DeliveryDate = DateTime.Parse("2017/02/10 13:00"),
                SaleAmount = 3725,
                Terms = "15 Days",
                CustomerStoreCity = "Denver, CO",
                Employee = "Todd Hoffman"
            },
            new OrderWithDelivery {
                ID = 11,
                OrderNumber = 38466,
                OrderDate = DateTime.Parse("2017/03/01"),
                DeliveryDate = DateTime.Parse("2017/03/03 17:45"),
                SaleAmount = 7800,
                Terms = "15 Days",
                CustomerStoreCity = "Los Angeles, CA",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 14,
                OrderNumber = 39420,
                OrderDate = DateTime.Parse("2017/02/15"),
                DeliveryDate = DateTime.Parse("2017/02/17 11:45"),
                SaleAmount = 20500,
                Terms = "15 Days",
                CustomerStoreCity = "San Jose, CA",
                Employee = "Jim Packard"
            },
            new OrderWithDelivery {
                ID = 15,
                OrderNumber = 39874,
                OrderDate = DateTime.Parse("2017/02/04"),
                DeliveryDate = DateTime.Parse("2017/02/10 15:00"),
                SaleAmount = 9050,
                Terms = "30 Days",
                CustomerStoreCity = "Las Vegas, NV",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 18,
                OrderNumber = 42847,
                OrderDate = DateTime.Parse("2017/02/15"),
                DeliveryDate = DateTime.Parse("2017/02/17 8:30"),
                SaleAmount = 20400,
                Terms = "30 Days",
                CustomerStoreCity = "Casper, WY",
                Employee = "Todd Hoffman"
            },
            new OrderWithDelivery {
                ID = 30,
                OrderNumber = 57429,
                OrderDate = DateTime.Parse("2017/05/16"),
                DeliveryDate = DateTime.Parse("2017/05/19 11:45"),
                SaleAmount = 11050,
                Terms = "30 Days",
                CustomerStoreCity = "Phoenix, AZ",
                Employee = "Clark Morgan"
            },
            new OrderWithDelivery {
                ID = 32,
                OrderNumber = 58292,
                OrderDate = DateTime.Parse("2017/05/13"),
                DeliveryDate = DateTime.Parse("2017/05/19 14:30"),
                SaleAmount = 13500,
                Terms = "15 Days",
                CustomerStoreCity = "Los Angeles, CA",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 36,
                OrderNumber = 62427,
                OrderDate = DateTime.Parse("2017/01/27"),
                DeliveryDate = DateTime.Parse("2017/02/03 18:00"),
                SaleAmount = 23500,
                Terms = "15 Days",
                CustomerStoreCity = "Las Vegas, NV",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 39,
                OrderNumber = 65977,
                OrderDate = DateTime.Parse("2017/02/05"),
                DeliveryDate = DateTime.Parse("2017/02/10 13:15"),
                SaleAmount = 2550,
                Terms = "15 Days",
                CustomerStoreCity = "Casper, WY",
                Employee = "Todd Hoffman"
            },
            new OrderWithDelivery {
                ID = 42,
                OrderNumber = 68428,
                OrderDate = DateTime.Parse("2017/04/10"),
                DeliveryDate = DateTime.Parse("2017/04/14 11:30"),
                SaleAmount = 10500,
                Terms = "15 Days",
                CustomerStoreCity = "Los Angeles, CA",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 43,
                OrderNumber = 69477,
                OrderDate = DateTime.Parse("2017/03/09"),
                DeliveryDate = DateTime.Parse("2017/03/10 12:00"),
                SaleAmount = 14200,
                Terms = "15 Days",
                CustomerStoreCity = "Anaheim, CA",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 46,
                OrderNumber = 72947,
                OrderDate = DateTime.Parse("2017/01/14"),
                DeliveryDate = DateTime.Parse("2017/01/20 9:00"),
                SaleAmount = 13350,
                Terms = "30 Days",
                CustomerStoreCity = "Las Vegas, NV",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 47,
                OrderNumber = 73088,
                OrderDate = DateTime.Parse("2017/03/25"),
                DeliveryDate = DateTime.Parse("2017/03/31 17:15"),
                SaleAmount = 8600,
                Terms = "30 Days",
                CustomerStoreCity = "Reno, NV",
                Employee = "Clark Morgan"
            },
            new OrderWithDelivery {
                ID = 51,
                OrderNumber = 77297,
                OrderDate = DateTime.Parse("2017/04/30"),
                DeliveryDate = DateTime.Parse("2017/05/05 18:00"),
                SaleAmount = 10850,
                Terms = "30 Days",
                CustomerStoreCity = "Phoenix, AZ",
                Employee = "Clark Morgan"
            },
            new OrderWithDelivery {
                ID = 56,
                OrderNumber = 84744,
                OrderDate = DateTime.Parse("2017/02/10"),
                DeliveryDate = DateTime.Parse("2017/02/17 14:00"),
                SaleAmount = 4650,
                Terms = "30 Days",
                CustomerStoreCity = "Las Vegas, NV",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 57,
                OrderNumber = 85028,
                OrderDate = DateTime.Parse("2017/05/17"),
                DeliveryDate = DateTime.Parse("2017/05/19 12:00"),
                SaleAmount = 2575,
                Terms = "30 Days",
                CustomerStoreCity = "Reno, NV",
                Employee = "Clark Morgan"
            },
            new OrderWithDelivery {
                ID = 59,
                OrderNumber = 87297,
                OrderDate = DateTime.Parse("2017/04/21"),
                DeliveryDate = DateTime.Parse("2017/04/28 9:00"),
                SaleAmount = 14200,
                Terms = "30 Days",
                CustomerStoreCity = "Casper, WY",
                Employee = "Todd Hoffman"
            },
            new OrderWithDelivery {
                ID = 65,
                OrderNumber = 94726,
                OrderDate = DateTime.Parse("2017/05/22"),
                DeliveryDate = DateTime.Parse("2017/05/26 13:30"),
                SaleAmount = 20500,
                Terms = "15 Days",
                CustomerStoreCity = "San Jose, CA",
                Employee = "Jim Packard"
            },
            new OrderWithDelivery {
                ID = 66,
                OrderNumber = 95266,
                OrderDate = DateTime.Parse("2017/03/10"),
                DeliveryDate = DateTime.Parse("2017/03/17 11:45"),
                SaleAmount = 9050,
                Terms = "15 Days",
                CustomerStoreCity = "Las Vegas, NV",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 69,
                OrderNumber = 98477,
                OrderDate = DateTime.Parse("2017/01/01"),
                DeliveryDate = DateTime.Parse("2017/01/06 9:00"),
                SaleAmount = 23500,
                Terms = "15 Days",
                CustomerStoreCity = "Casper, WY",
                Employee = "Todd Hoffman"
            },
            new OrderWithDelivery {
                ID = 78,
                OrderNumber = 174884,
                OrderDate = DateTime.Parse("2017/04/10"),
                DeliveryDate = DateTime.Parse("2017/04/14 8:30"),
                SaleAmount = 7200,
                Terms = "30 Days",
                CustomerStoreCity = "Denver, CO",
                Employee = "Todd Hoffman"
            },
            new OrderWithDelivery {
                ID = 81,
                OrderNumber = 188877,
                OrderDate = DateTime.Parse("2017/02/11"),
                DeliveryDate = DateTime.Parse("2017/02/17 16:00"),
                SaleAmount = 8750,
                Terms = "30 Days",
                CustomerStoreCity = "Phoenix, AZ",
                Employee = "Clark Morgan"
            },
            new OrderWithDelivery {
                ID = 82,
                OrderNumber = 191883,
                OrderDate = DateTime.Parse("2017/02/05"),
                DeliveryDate = DateTime.Parse("2017/02/10 18:30"),
                SaleAmount = 9900,
                Terms = "30 Days",
                CustomerStoreCity = "Los Angeles, CA",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 83,
                OrderNumber = 192474,
                OrderDate = DateTime.Parse("2017/01/21"),
                DeliveryDate = DateTime.Parse("2017/01/27 12:45"),
                SaleAmount = 12800,
                Terms = "30 Days",
                CustomerStoreCity = "Anaheim, CA",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 84,
                OrderNumber = 193847,
                OrderDate = DateTime.Parse("2017/03/21"),
                DeliveryDate = DateTime.Parse("2017/03/24 9:00"),
                SaleAmount = 14100,
                Terms = "30 Days",
                CustomerStoreCity = "San Diego, CA",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 85,
                OrderNumber = 194877,
                OrderDate = DateTime.Parse("2017/03/06"),
                DeliveryDate = DateTime.Parse("2017/03/10 18:15"),
                SaleAmount = 4750,
                Terms = "30 Days",
                CustomerStoreCity = "San Jose, CA",
                Employee = "Jim Packard"
            },
            new OrderWithDelivery {
                ID = 86,
                OrderNumber = 195746,
                OrderDate = DateTime.Parse("2017/05/26"),
                DeliveryDate = DateTime.Parse("2017/06/02 17:00"),
                SaleAmount = 9050,
                Terms = "30 Days",
                CustomerStoreCity = "Las Vegas, NV",
                Employee = "Harv Mudd"
            },
            new OrderWithDelivery {
                ID = 87,
                OrderNumber = 197474,
                OrderDate = DateTime.Parse("2017/03/02"),
                DeliveryDate = DateTime.Parse("2017/03/03 11:00"),
                SaleAmount = 6400,
                Terms = "30 Days",
                CustomerStoreCity = "Reno, NV",
                Employee = "Clark Morgan"
            },
            new OrderWithDelivery {
                ID = 88,
                OrderNumber = 198746,
                OrderDate = DateTime.Parse("2017/05/09"),
                DeliveryDate = DateTime.Parse("2017/05/12 15:45"),
                SaleAmount = 15700,
                Terms = "30 Days",
                CustomerStoreCity = "Denver, CO",
                Employee = "Todd Hoffman"
            },
            new OrderWithDelivery {
                ID = 91,
                OrderNumber = 214222,
                OrderDate = DateTime.Parse("2017/02/08"),
                DeliveryDate = DateTime.Parse("2017/02/10 9:45"),
                SaleAmount = 11050,
                Terms = "30 Days",
                CustomerStoreCity = "Phoenix, AZ",
                Employee = "Clark Morgan"
            }
        };


    }





    static class SampleData {
        public static List<SampleOrder> Orders = new List<SampleOrder>() {
            new SampleOrder {
                OrderID = 10248,
                OrderDate = new DateTime(1996, 7, 4),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10249,
                OrderDate = new DateTime(1996, 7, 5),
                ShipCountry = "Germany",
                ShipCity = "Münster",
                CustomerName = "Karin Josephs"
            },
            new SampleOrder {
                OrderID = 10250,
                OrderDate = new DateTime(1996, 7, 8),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Mario Pontes"
            },
            new SampleOrder {
                OrderID = 10251,
                OrderDate = new DateTime(1996, 7, 8),
                ShipCountry = "France",
                ShipCity = "Lyon",
                CustomerName = "Mary Saveley"
            },
            new SampleOrder {
                OrderID = 10252,
                OrderDate = new DateTime(1996, 7, 9),
                ShipCountry = "Belgium",
                ShipCity = "Charleroi",
                CustomerName = "Pascale Cartrain"
            },
            new SampleOrder {
                OrderID = 10253,
                OrderDate = new DateTime(1996, 7, 10),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Mario Pontes"
            },
            new SampleOrder {
                OrderID = 10254,
                OrderDate = new DateTime(1996, 7, 11),
                ShipCountry = "Switzerland",
                ShipCity = "Bern",
                CustomerName = "Yang Wang"
            },
            new SampleOrder {
                OrderID = 10255,
                OrderDate = new DateTime(1996, 7, 12),
                ShipCountry = "Switzerland",
                ShipCity = "Genève",
                CustomerName = "Michael Holz"
            },
            new SampleOrder {
                OrderID = 10256,
                OrderDate = new DateTime(1996, 7, 15),
                ShipCountry = "Brazil",
                ShipCity = "Resende",
                CustomerName = "Paula Parente"
            },
            new SampleOrder {
                OrderID = 10257,
                OrderDate = new DateTime(1996, 7, 16),
                ShipCountry = "Venezuela",
                ShipCity = "San Cristóbal",
                CustomerName = "Carlos Hernández"
            },
            new SampleOrder {
                OrderID = 10258,
                OrderDate = new DateTime(1996, 7, 17),
                ShipCountry = "Austria",
                ShipCity = "Graz",
                CustomerName = "Roland Mendel"
            },
            new SampleOrder {
                OrderID = 10259,
                OrderDate = new DateTime(1996, 7, 18),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Francisco Chang"
            },
            new SampleOrder {
                OrderID = 10260,
                OrderDate = new DateTime(1996, 7, 19),
                ShipCountry = "Germany",
                ShipCity = "Köln",
                CustomerName = "Henriette Pfalzheim"
            },
            new SampleOrder {
                OrderID = 10261,
                OrderDate = new DateTime(1996, 7, 19),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Bernardo Batista"
            },
            new SampleOrder {
                OrderID = 10262,
                OrderDate = new DateTime(1996, 7, 22),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderID = 10263,
                OrderDate = new DateTime(1996, 7, 23),
                ShipCountry = "Austria",
                ShipCity = "Graz",
                CustomerName = "Roland Mendel"
            },
            new SampleOrder {
                OrderID = 10264,
                OrderDate = new DateTime(1996, 7, 24),
                ShipCountry = "Sweden",
                ShipCity = "Bräcke",
                CustomerName = "Maria Larsson"
            },
            new SampleOrder {
                OrderID = 10265,
                OrderDate = new DateTime(1996, 7, 25),
                ShipCountry = "France",
                ShipCity = "Strasbourg",
                CustomerName = "Frédérique Citeaux"
            },
            new SampleOrder {
                OrderID = 10266,
                OrderDate = new DateTime(1996, 7, 26),
                ShipCountry = "Finland",
                ShipCity = "Oulu",
                CustomerName = "Pirkko Koskitalo"
            },
            new SampleOrder {
                OrderID = 10267,
                OrderDate = new DateTime(1996, 7, 29),
                ShipCountry = "Germany",
                ShipCity = "München",
                CustomerName = "Peter Franken"
            },
            new SampleOrder {
                OrderID = 10268,
                OrderDate = new DateTime(1996, 7, 30),
                ShipCountry = "Venezuela",
                ShipCity = "Caracas",
                CustomerName = "Manuel Pereira"
            },
            new SampleOrder {
                OrderID = 10269,
                OrderDate = new DateTime(1996, 7, 31),
                ShipCountry = "USA",
                ShipCity = "Seattle",
                CustomerName = "Karl Jablonski"
            },
            new SampleOrder {
                OrderID = 10270,
                OrderDate = new DateTime(1996, 8, 1),
                ShipCountry = "Finland",
                ShipCity = "Oulu",
                CustomerName = "Pirkko Koskitalo"
            },
            new SampleOrder {
                OrderID = 10271,
                OrderDate = new DateTime(1996, 8, 1),
                ShipCountry = "USA",
                ShipCity = "Lander",
                CustomerName = "Art Braunschweiger"
            },
            new SampleOrder {
                OrderID = 10272,
                OrderDate = new DateTime(1996, 8, 2),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderID = 10273,
                OrderDate = new DateTime(1996, 8, 5),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderID = 10274,
                OrderDate = new DateTime(1996, 8, 6),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10275,
                OrderDate = new DateTime(1996, 8, 7),
                ShipCountry = "Italy",
                ShipCity = "Bergamo",
                CustomerName = "Giovanni Rovelli"
            },
            new SampleOrder {
                OrderID = 10276,
                OrderDate = new DateTime(1996, 8, 8),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Miguel Angel Paolino"
            },
            new SampleOrder {
                OrderID = 10277,
                OrderDate = new DateTime(1996, 8, 9),
                ShipCountry = "Germany",
                ShipCity = "Leipzig",
                CustomerName = "Alexander Feuer"
            },
            new SampleOrder {
                OrderID = 10278,
                OrderDate = new DateTime(1996, 8, 12),
                ShipCountry = "Sweden",
                ShipCity = "Luleå",
                CustomerName = "Christina Berglund"
            },
            new SampleOrder {
                OrderID = 10279,
                OrderDate = new DateTime(1996, 8, 13),
                ShipCountry = "Germany",
                ShipCity = "Frankfurt a.M.",
                CustomerName = "Renate Messner"
            },
            new SampleOrder {
                OrderID = 10280,
                OrderDate = new DateTime(1996, 8, 14),
                ShipCountry = "Sweden",
                ShipCity = "Luleå",
                CustomerName = "Christina Berglund"
            },
            new SampleOrder {
                OrderID = 10281,
                OrderDate = new DateTime(1996, 8, 14),
                ShipCountry = "Spain",
                ShipCity = "Madrid",
                CustomerName = "Alejandra Camino"
            },
            new SampleOrder {
                OrderID = 10282,
                OrderDate = new DateTime(1996, 8, 15),
                ShipCountry = "Spain",
                ShipCity = "Madrid",
                CustomerName = "Alejandra Camino"
            },
            new SampleOrder {
                OrderID = 10283,
                OrderDate = new DateTime(1996, 8, 16),
                ShipCountry = "Venezuela",
                ShipCity = "Barquisimeto",
                CustomerName = "Carlos González"
            },
            new SampleOrder {
                OrderID = 10284,
                OrderDate = new DateTime(1996, 8, 19),
                ShipCountry = "Germany",
                ShipCity = "Frankfurt a.M.",
                CustomerName = "Renate Messner"
            },
            new SampleOrder {
                OrderID = 10285,
                OrderDate = new DateTime(1996, 8, 20),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderID = 10286,
                OrderDate = new DateTime(1996, 8, 21),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderID = 10287,
                OrderDate = new DateTime(1996, 8, 22),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Janete Limeira"
            },
            new SampleOrder {
                OrderID = 10288,
                OrderDate = new DateTime(1996, 8, 23),
                ShipCountry = "Italy",
                ShipCity = "Reggio Emilia",
                CustomerName = "Maurizio Moroni"
            },
            new SampleOrder {
                OrderID = 10289,
                OrderDate = new DateTime(1996, 8, 26),
                ShipCountry = "UK",
                ShipCity = "London",
                CustomerName = "Victoria Ashworth"
            },
            new SampleOrder {
                OrderID = 10290,
                OrderDate = new DateTime(1996, 8, 27),
                ShipCountry = "Brazil",
                ShipCity = "Sao Paulo",
                CustomerName = "Pedro Afonso"
            },
            new SampleOrder {
                OrderID = 10291,
                OrderDate = new DateTime(1996, 8, 27),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Bernardo Batista"
            },
            new SampleOrder {
                OrderID = 10292,
                OrderDate = new DateTime(1996, 8, 28),
                ShipCountry = "Brazil",
                ShipCity = "Sao Paulo",
                CustomerName = "Anabela Domingues"
            },
            new SampleOrder {
                OrderID = 10293,
                OrderDate = new DateTime(1996, 8, 29),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Miguel Angel Paolino"
            },
            new SampleOrder {
                OrderID = 10294,
                OrderDate = new DateTime(1996, 8, 30),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderID = 10295,
                OrderDate = new DateTime(1996, 9, 2),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10296,
                OrderDate = new DateTime(1996, 9, 3),
                ShipCountry = "Venezuela",
                ShipCity = "Barquisimeto",
                CustomerName = "Carlos González"
            },
            new SampleOrder {
                OrderID = 10297,
                OrderDate = new DateTime(1996, 9, 4),
                ShipCountry = "France",
                ShipCity = "Strasbourg",
                CustomerName = "Frédérique Citeaux"
            }
        };
    }
}
