using Notes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Notes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class NoteService : INote
    {
        public int AddNote(String Username, String Heading, String Body)
        {
            int x = 0;
            Username = Username.ToLower();
            using (var Context = new NoteDatabaseEntities())
            {
                var no = new Note() { Body = Body, Heading = Heading, Username = Username, Date = DateTime.Now };
                Context.Notes.Add(no);
                if (Context.SaveChanges() > 0)
                {
                    x = 1;
                };

            }

            return x;
        }

        public int DeleteNote(int id, String Username)
        {
            int x = 0;
            Username = Username.ToLower();
            using (var Context = new NoteDatabaseEntities())
            {
                var no = Context.Notes.Where(s => s.Id == id && s.Username.Equals(Username)).FirstOrDefault();
                Context.Notes.Remove(no);
                if (Context.SaveChanges() > 0)
                {
                    x = 1;
                };

            }
            return 0;
        }

        public int UpdateNoteBody(int id, String UserName, String Body)
        {
            int x = 0;
            UserName = UserName.ToLower();
            using (var Context = new NoteDatabaseEntities())
            {
                var no = Context.Notes.Where(s => s.Id == id && s.Username.Equals(UserName)).FirstOrDefault();
                no.Body = Body;
                no.Date = DateTime.Now;
                if (Context.SaveChanges() > 0)
                {
                    x = 1;
                };

            }

            return x;
        }

        public int UpdateNoteHeading(int id, String UserName, String Heading)
        {
            int x = 0;
            UserName = UserName.ToLower();
            using (var Context = new NoteDatabaseEntities())
            {
                var no = Context.Notes.Where(s => s.Id == id && s.Username.Equals(UserName)).FirstOrDefault();
                no.Heading = Heading;
                no.Date = DateTime.Now;
                if (Context.SaveChanges() > 0)
                {
                    x = 1;
                };

            }
            return 0;
        }


        public Note GetNote(string Username, int id)
        {
            var no = new Note();
            Username = Username.ToLower();
            using (var Context = new NoteDatabaseEntities())
            {
                no = Context.Notes.Where(s => s.Id == id && s.Username.Equals(Username)).FirstOrDefault();
            }
            return no;
        }

        public List<Note> GetAllNote(string Username)
        {
            var no = new List<Note>();
            Username = Username.ToLower();
            using (var Context = new NoteDatabaseEntities())
            {
                no = Context.Notes.Where(s => s.Username.Equals(Username)).ToList();

            }
            return no;
        }
    }
}
