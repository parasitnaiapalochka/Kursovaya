using LAB_movies_;
using Newtonsoft.Json;

namespace LAB_movies.v2_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private List<Cinema> GetCinemas()
        {
            if (File.Exists("cinemas.json"))
            {
                string json = File.ReadAllText("cinemas.json");
                return JsonConvert.DeserializeObject<List<Cinema>>(json);
            }
            else
            {
                return new List<Cinema>();
            }
        }

        private List<Movie> GetMovies()
        {
           
            if (File.Exists("movies.json"))
            {
                string json = File.ReadAllText("movies.json");
                List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(json); // Загружаем фильмы из JSON
                
                return movies;
    }
            else
            {
                return new List<Movie>();
            }
        }

       
        private List<Supplier> GetPersons()
        {
           
    {
         if (File.Exists("suppliers.json"))
            {
                // Чтение JSON строки из файла
                string json = File.ReadAllText("suppliers.json");

                // Преобразование JSON строки обратно в список поставщиков
                return JsonConvert.DeserializeObject<List<Supplier>>(json);
            }
            else
            {
                // Если файл не существует, возвращаем пустой список
                return new List<Supplier>();
            }
        };
        }

        private List<LegalEntity> GetLegalEntities()
        {
            return new List<LegalEntity>
    {
        new Company("Company 1", "Address 1", new BankAccount("Bank 1", "111111"), "001"),
        new Company("Company 2", "Address 2", new BankAccount("Bank 2", "222222"), "002"),
        new Company("Company 3", "Address 3", new BankAccount("Bank 3", "333333"), "003"),
        new Company("Company 4", "Address 4", new BankAccount("Bank 4", "444444"), "004")
    };
        }



        private void btnMovieForm_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.Show();
        }

        private void btnSupplierForm_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();
        }

        private void btnMovieRentalForm_Click(object sender, EventArgs e)
        {
            List<Cinema> cinemas = GetCinemas();  // Получите список кинотеатров
            List<Movie> movies = GetMovies();      // Получите список фильмов

            MovieRentalForm rentalForm = new MovieRentalForm(cinemas, movies);
            rentalForm.Show();  // Показать форму
        }

        private void btnCinemaForm_Click(object sender, EventArgs e)
        {

            
            List<Supplier> persons = GetPersons();
            List<LegalEntity> legalEntities = GetLegalEntities();

            
            CinemaForm cinemaForm = new CinemaForm(persons, legalEntities);
            cinemaForm.Show();

        }
    }
}
