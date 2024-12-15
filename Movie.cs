using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_movies_
{
    public class Movie
    {
        private string v1;
        private object value1;
        private object value2;
        private object value3;
        private int v2;
        private int v3;
        private object value4;

        public string Title { get; set; }
        public Category Category { get; set; }
        public Person ScriptWriter { get; set; }
        public Person Director { get; set; }
        public ProductionCompany ProductionCompany { get; set; }
        public int ReleaseYear { get; set; }
        public double Cost { get; set; }
        public Supplier Supplier { get; set; }

        public Movie() { }
        public Movie(string title, Category category, Person scriptWriter, Person director,
                     ProductionCompany productionCompany, int releaseYear, double cost, Supplier supplier)
        {
            Title = title;
            Category = category;
            ScriptWriter = scriptWriter;
            Director = director;
            ProductionCompany = productionCompany;
            ReleaseYear = releaseYear;
            Cost = cost;
            Supplier = supplier;
        }

        public Movie(string v1, object value1, object value2, object value3, int v2, int v3, object value4)
        {
            this.v1 = v1;
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
            this.v2 = v2;
            this.v3 = v3;
            this.value4 = value4;
        }

        public string GetInfo()
        {
            return $"Movie: {Title}, Category: {Category}, Director: {Director.FullName}, Release Year: {ReleaseYear}";
        }
    }

}
