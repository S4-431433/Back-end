namespace S4_BmBackend.DTO
{
    public class Article
    {
        public Article(PersonalTrainer personalTrainer, int id, string title, string subject, string text, DateTime date)
        {
            Author = personalTrainer;
            Id = id;
            Title = title;
            Subject = subject;
            Text = text;
            Date = date;
        }

        PersonalTrainer Author { get; set; }
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Subject { get; private set; }
        public string Text { get; private set; }
        public DateTime Date { get; private set; }
    }
}
