using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_movies_
{
    public class Cinema : LegalEntity
    {
        public string PhoneNumber { get; set; }
        public int SeatCount { get; set; }
        public Person Director { get; set; }

        // Owner может быть как Company, так и Individual, используем полиморфизм
        [JsonConverter(typeof(OwnerConverter))]  // Пользовательский конвертер для поля Owner
        public LegalEntity Owner { get; set; }

        // Конструктор по умолчанию для десериализации
        public Cinema() { }

        // Конструктор с параметрами для установки свойств
        public Cinema(string name, string address, BankAccount bankAccount, string taxId,
                      string phoneNumber, int seatCount, Person director, LegalEntity owner)
            : base(name, address, bankAccount, taxId)
        {
            PhoneNumber = phoneNumber;
            SeatCount = seatCount;
            Director = director;
            Owner = owner;
        }

        public string GetInfo()
        {
            return $"Cinema: {Name}, Address: {Address}, Director: {Director.FullName}, Owner: {Owner.Name}, Seats: {SeatCount}";
        }
    }
}
