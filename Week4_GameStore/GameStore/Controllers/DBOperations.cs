using System.Linq;
using DAL.Model;
using Entities;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GameStore2.Controllers
{
    public class DBOperations
    {
        public GameContext _context = new GameContext();
        Logger logger = new Logger();


        public void AddGame(Game _game)
        {
            try
            {
                _context.Game.Add(_game);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                logger.createLog("HATA "+ex.Message);
            }
        }

        public List<Game> GetGames()
        {
            return  _context.Game.ToList();      
        }

        public Game GetGame(int id)
        {
            return _context.Game.FirstOrDefault(g => g.Id == id);
        } 

        public Game FindGame(int id = 0, string Name = "")
        {
            if(!string.IsNullOrEmpty(Name) )
            {
                return _context.Game.FirstOrDefault(g => g.Name == Name);
            }
            else 
                return null;
            
        }

        public bool DeleteGamel(int id)
        {
            try
            {
                _context.Game.Remove(GetGame(id));
                _context.SaveChanges();
                return true;
            }
            catch (Exception exc)
            {
                logger.createLog("HATA " + exc.Message);
                return false;
            }
        }

        public bool UpdateGame(int id, Game updatedGame)
        {
            var game = _context.Game.FirstOrDefault(_game => _game.Id == id);
            if (game is not null)
            {
                game.Genre = updatedGame.Genre != default ? updatedGame.Genre : game.Genre;
                if (updatedGame.Name != "string") game.Name = updatedGame.Name;
                game.Publisher = updatedGame.Publisher != default ? updatedGame.Publisher : game.Publisher;
                game.PublishDate = updatedGame.PublishDate != default ? updatedGame.PublishDate : game.PublishDate;
                _context.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
