using System;
using System.Collections.Generic;
using ModelLibrary;

namespace CGHSample_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to this CodeGenHero ConsoleApp Example");

            //Let's pass some data through our models via our mappers
            //the models and mapper classes have been generated via CodeGenHero
            Console.WriteLine("Let's build out one blog record with three post records, as they would exist in a database...");
            var blog1_DTO = new ModelLibrary.DTO.Blogger.Blog() { BlogId = 1, Url = "http://www.myblog.com" };
            var post1_DTO = new ModelLibrary.DTO.Blogger.Post() { PostId = 1, BlogId = 1, Title = "My First Post", Content = "My First Post Content" };
            var post2_DTO = new ModelLibrary.DTO.Blogger.Post() { PostId = 2, BlogId = 1, Title = "My Second Post", Content = "My Second Post Content" };
            var post3_DTO = new ModelLibrary.DTO.Blogger.Post() { PostId = 3, BlogId = 1, Title = "My Third Post", Content = "My Third Post Content" };

            //map DTO to model data - this would be for peristant storage in SQLite
            Console.WriteLine("Let's map out DTOs to Model Data records, as they would exist in persistant storage, like SQLite...");
            var blog1_ModelData = blog1_DTO.ToModelData();
            var post1_ModelData = post1_DTO.ToModelData();
            var post2_ModelData = post2_DTO.ToModelData();
            var post3_ModelData = post3_DTO.ToModelData();

            //map model data to model objects for MVVM
            Console.WriteLine("Let's map our peristant storage model data records to model obj records, as we would use in MVVM...");
            var blog1_ModelObj = blog1_ModelData.ToModelObj();
            var post1_ModelObj = post1_ModelData.ToModelObj();
            var post2_ModelObj = post2_ModelData.ToModelObj();
            var post3_ModelObj = post3_ModelData.ToModelObj();
            //rehydrate your models
            blog1_ModelObj.Posts.Add(post1_ModelObj);
            blog1_ModelObj.Posts.Add(post2_ModelObj);
            blog1_ModelObj.Posts.Add(post3_ModelObj);

            Console.WriteLine("What does our ModelObjs look like?");
            Console.WriteLine($"BlogId: {blog1_ModelObj.BlogId} URL: {blog1_ModelObj.Url}");

            foreach(var p in blog1_ModelObj.Posts)
            {
                Console.WriteLine($"PostId: {p.PostId} Title: {p.Title} Content: {p.Content}");
            }
        }
    }
}
