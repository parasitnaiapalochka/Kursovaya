using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_movies_
{
    public class Supplier : LegalEntity
    {
        public List<Movie> SuppliedMovies { get; set; } = new List<Movie>();


        public Supplier(string name, string address, BankAccount bankAccount, string taxId)
            : base(name, address, bankAccount, taxId)
        {
        }

        public void AddMovie(Movie movie)
        {
            SuppliedMovies.Add(movie);
        }

        public string GetInfo()
        {
            return $"Supplier: {Name}, Address: {Address}, Tax ID: {TaxId}";
        }
    }

}
