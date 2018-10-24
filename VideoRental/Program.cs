using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContextEntities();
            //var data = new Video()
            //{
            //    Id = 1,
            //    Name = "ASA",
            //    ReleaseDate = DateTime.Now
            // };
            DateTime x = DateTime.Now;
            var y = Convert.ToByte(Classification.Platinum);
            //context.Videos.Add(data);
            // context.SaveChanges();
            context.AddVideo("Maze",x, "Horror",y);
        }
        
    }
}
