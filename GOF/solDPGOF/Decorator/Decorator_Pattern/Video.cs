using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class Video : LibraryItem
    {
        private string _director;
        private string _title;
        private int _playTime;

        // Constructor

        public Video(string director, string title,
          int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            this.NumCopies = numCopies;
            this._playTime = playTime;
        }

        public override List<string> Display()
        {
            var data = new List<string>();

            data.Add("\nVideo ----- ");
            data.Add(" Director: " + _director);
            data.Add(" Title: " + _title);
            data.Add(" # Copies: " + NumCopies);
            data.Add(" Playtime: "+ _playTime);

            return data;
        }
    }
}
