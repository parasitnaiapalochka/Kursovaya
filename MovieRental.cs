using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_movies_
{
    public class MovieRental
    {
        // Свойства
        public Cinema Cinema { get; set; }
        public Movie Movie { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal RentalFee { get; set; }
        public decimal Deposit { get; set; }

        // Конструктор по умолчанию
        public MovieRental() { }

        // Конструктор с параметрами
        public MovieRental(Cinema cinema, Movie movie, DateTime startDate, DateTime endDate,
                           decimal rentalFee, decimal deposit)
        {
            Cinema = cinema;
            Movie = movie;
            StartDate = startDate;
            EndDate = endDate;
            RentalFee = rentalFee;
            Deposit = deposit;
            Console.WriteLine($"MovieRental created: {cinema.Name}, {movie.Title}, {rentalFee}");
        }

        // Метод для получения информации о прокате
        public string GetInfo()
        {
            return $"Rental: {Cinema.Name}, Movie: {Movie.Title}, Start Date: {StartDate.ToShortDateString()}, End Date: {EndDate.ToShortDateString()}, Fee: {RentalFee}, Deposit: {Deposit}";
        }
    }
}
