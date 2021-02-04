using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace All_Range_Market.Models
{

    public class Order
    {

        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Нам важно знать, как к Вам обращаться")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите адрес")]
        public string Line1 { get; set; }

        [Required(ErrorMessage = "Введите город доставки")]
        public string City { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите регион")]
        public string State { get; set; }
        public string Zip { get; set; }
        public bool GiftWrap { get; set; }
        [Required (ErrorMessage = "Как нам доставить заказ?")]
        public DeliveryType DeliveryType { get; set; }
        [Required(ErrorMessage = "Введите номер телефона, мы его никому не скажем")]
        public string PhoneNumber { get; set; }
        public PaymentMethod Method { get; set; }
        [BindNever]
        public bool Shipped { get; set; }
    }
    public enum DeliveryType
    {
        Courier,
        Removal
    }
    public enum PaymentMethod
    {
        Cash,
        Debit_card
    }

}
