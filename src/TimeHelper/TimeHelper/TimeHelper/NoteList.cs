using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeHelper;
namespace TimeHelper
{
    class NoteList
    {
        public List<Note> ListOfNotes { get; }
        
        public NoteList()
        {
            ListOfNotes = new List<Note>();
        }

        public void AddNote(String name, String description)
        {
            Note item = new Note(name, description);
            ListOfNotes.Add(item);
            return;
        }
    }
}
