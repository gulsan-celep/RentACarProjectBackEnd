using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Araba silindi.";

        public static string BrandAdded = "Brand eklendi.";
        public static string BrandUpdated = "Brand güncellendi.";
        public static string BrandDeleted = "Brand silindi.";

        public static string ColorAdded = "Color eklendi.";
        public static string ColorUpdated = "Color güncellendi.";
        public static string ColorDeleted = "Color silindi.";

        public static string CustomerAdded = "Customer eklendi.";
        public static string CustomerUpdated = "Customer güncellendi.";
        public static string CustomerDeleted = "Customer silindi.";

        public static string UserAdded = "User eklendi.";
        public static string UserUpdated = "User güncellendi.";
        public static string UserDeleted = "User silindi.";

        public static string RentalAdded = "Araba kiralandı.";
        public static string RentalUpdated = "Rental güncellendi.";
        public static string RentalDeleted = "Rental silindi.";
        public static string CarNotReturn = "Araba şu anda kiralık olarak kullanılmaktadır.";

        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Ürünler listelendi";
        public static string AuthorizationDenied = "Yetkiniz yoktur";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string FailAddedImageLimit = "Resim limitine erişildi!";
        public static string RentalCarMessage ="Bu araç kiralanamaz";
    }
}
