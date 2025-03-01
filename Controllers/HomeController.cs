using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    //This is HomeCoontroller
    public class HomeController:Controller
    {
        //3 numaralı kategoriye ait olan filmleri burada listeleyelim.
        // Home/Index/3
        public IActionResult Index(int? id)
        {
            
           // return View(ProductRepository.Movies);
           // MovieRepository.Movies
           // CategoryRepositories.Categories
           // MovieCategoryModel model = new MovieCategoryModel();
           // model.Categories = CategoryRepository.Categories;
           // model.Movies = MovieRepository.Movies;
           var movies = MovieRepository.Movies;
           //Console.WriteLine(movies.GetType().FullName);
           List<Movie> movies1 = MovieRepository.Movies;
           if(id!=null)
           {
                movies1 = movies.Where(i => i.CategoryId == id).ToList();
                //movies = movies1;
           }

           return View(movies1);
        }

        public IActionResult Details(int id)
        {
            //return View(MovieRepository.GetById(id));
            // MovieCategoryModel model = new MovieCategoryModel();
            // model.Categories = CategoryRepository.Categories;
            // model.Movie = MovieRepository.GetById(id);

            return View(MovieRepository.GetById(id));
        }

        public IActionResult Contact()
        {
            return View();
        }
        
    }
}