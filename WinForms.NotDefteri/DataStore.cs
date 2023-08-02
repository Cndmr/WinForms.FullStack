using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.NotDefteri
{
    public class DataStore
    {
        public static AppUser AppUser = new AppUser { Id = 1, UserName = "Admin", Password = "123" };
        public static List<Note> Notes = new List<Note>() 
        {
            new Note() { Id = 1,Description="C#"},
            new Note() { Id = 2,Description="İngilizce"},
            new Note() { Id = 3,Description="HMTL"},
            new Note() { Id = 4,Description="CSS"},
            new Note() { Id = 5,Description="BOOTSTRAP"},
        };

       
    }
    public class Note
    {
        public int Id { get; set; }     
        public string Description { get; set; }     
    }
    public class AppUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}
