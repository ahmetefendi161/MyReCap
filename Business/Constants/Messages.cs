using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string carAdded = "Araç kayıt işlemi başarılı"; 
        public static string colorAdded = "Renk kayıt işlemi başarılı"; 
        public static string brandAdded = "Marka kayıt işlemi başarılı";
        public static string rentalAdded = "Kiralama işlemi başarılı";
        public static string carDeleted = "Araç silme işlemi başarılı"; 
        public static string carUpdated = "Araç güncelleme işlemi başarılı";
        public static string colorUpdated= "Renk güncelleme işlemi başarılı";
        public static string brandUpdated = "Marka güncelleme işlemi başarılı";
        public static string colorDeleted = "Renk silme işlemi başarılı";
        public static string brandDeleted = "Marka silme işlemi başarılı";
        public static string colorAddError = "Eklemek istediğiniz renk zaten mevcut.Farklı bir renk giriniz."; 
        public static string brandAddError = "Eklemek istediğiniz marka zaten mevcut.Farklı bir marka giriniz.";
        public static string colorUpdateError = "Renk zaten güncel.";
        public static string brandUpdateError = "Marka zaten güncel.";
        public static string rentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string brandDeletedError = "Silmek istediginiz Marka mevcut degil";
        public static string carDeletedError = "Silmek istediginiz araç mevcut degil";
        //public static string carUpdateError;
        public static string colorDeleteError = "Silmek istediginiz renk mevcut degil";
        internal static string customerAdded = "Müşteri kayıt işlemi başarılı";
        internal static string customerAddError="Eklemek istediğiniz müşteri zaten mevcut.";
        internal static string customerUpdated;
        internal static string customerDeleted;
        internal static string customerDeletedError;
        internal static Customer customerGetByIdError;
        internal static string rentalAddError;
        internal static string rentalReturnDateError;
        internal static string rentalDeleteError;
        internal static string rentalDeleted;
        internal static string rentalIsRentedTrue;
        internal static string rentalReceivedCar;
        internal static string userAdded;
        internal static string userDeleted;
        internal static string userUpdated;
    }
}
