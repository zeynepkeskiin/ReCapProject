using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public  static string Maintenancetime = "Sistem bakımda.";
        public static string CarsListed= "Ürünler Listelendi";
        public static string BuyReject="Satış kabul edildi";
        public static string BuyAccepted = "Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.";
        public static string ColorUpdated;

        public static string ColorListed { get; internal set; }
        public static string  ColorDeleted { get; internal set; }
        public static string ColorAdded { get; internal set; }
        public static string BrandAdded { get; internal set; }
        public static string BrandDeleted { get; internal set; }
        public static string BrandListed { get; internal set; }
        public static string BrandUpdated { get; internal set; }
        public static string RentalDetailsListed { get; internal set; }
        public static string RentalListed { get; internal set; }
        public static string CarDeleted { get; internal set; }
        public static string CarUpdated { get; internal set; }
    }
}
