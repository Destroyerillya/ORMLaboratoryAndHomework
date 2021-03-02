using System;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            
            context.Database.EnsureDeleted();
            
            context.Database.EnsureCreated();
            
            context.Dispose();
        }
    }
}