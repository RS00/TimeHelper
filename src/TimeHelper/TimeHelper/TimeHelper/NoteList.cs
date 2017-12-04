using System;
using System.Collections.Generic;
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
