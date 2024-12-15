using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_movies_
{
    public class ProductionCompany : LegalEntity
    {
        public List<Movie> ProducedMovies { get; set; } = new List<Movie>();


        public ProductionCompany(string name, string address, BankAccount bankAccount, string taxId)
            : base(name, address, bankAccount, taxId)
        {
        }

        public void AddMovie(Movie movie)
        {
            ProducedMovies.Add(movie);
        }

        public string GetInfo()
        {
            return $"ProductionCompany: {Name}, Address: {Address}, Tax ID: {TaxId}";
        }
    }

}
