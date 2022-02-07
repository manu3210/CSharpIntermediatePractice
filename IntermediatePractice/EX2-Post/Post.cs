namespace EX2_Post
{
    public class Post
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int Vote { get; set; }

        public Post()
        {
            CreationDate = DateTime.Now;
        }

        public void UpVote()
        {
            Vote++;
        }

        public void DownVote()
        {
            Vote--;
        }

        public override string ToString()
        {
            return "Tittle: " + Tittle + "\nDescription: \n" + Description + "\nDate: " + CreationDate + "\nTotal Votes: " + Vote;
        }
    }
}
