// See https://aka.ms/new-console-template for more information
using EntLibrary;
using EntLibrary.EntModels.GenresModel;

Console.WriteLine("Hello, World!");

using (_DbContext db = new _DbContext())
{
    Console.WriteLine(  "In using ");
    GameGenre genre = new GameGenre();
    genre.Name = "RPG";
    db.GamesGenres.Add(genre);
    db.SaveChanges();


}
