using System;

namespace LAB_movies_
{
    public class Company : LegalEntity
    {
        // Конструктор по умолчанию для десериализации
       

        // Конструктор с параметрами
        public Company(string name, string address, BankAccount bankAccount, string taxId)
            : base(name, address, bankAccount, taxId)
        {
        }

        public Company()  
        {
        }

        public class Individual : LegalEntity
        {
            public string SocialSecurityNumber { get; set; }
            // Другие свойства, специфичные для индивидуальных владельцев
        }

        // Метод для получения информации о компании
        public string GetInfo()
        {
            return $"Company: {Name}, Address: {Address}, Tax ID: {TaxId}";
        }
    }
}
