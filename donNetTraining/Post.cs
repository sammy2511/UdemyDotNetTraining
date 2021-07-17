using System;
using System.Collections.Generic;
using System.Text;

namespace donNetTraining
{
    class Post
    {
        private String _title { get; set; }
        private String _description { get; set; }
        private DateTime _createdAt { get; set; }
        private int _votesCount { get; set; }

        public Post(String title,String description)
        {
            _title = title;
            _description = description;
            _createdAt = DateTime.Now;
            _votesCount = 0;
        }

        public void UpVote()
        {
            _votesCount += 1;
        }

        public void DownVote()
        {
            _votesCount -= 1;
        }

        public int ShowVotes()
        {
            return _votesCount;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
