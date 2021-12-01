using System.Collections.Generic;

namespace Lesson12

{
    class NewsProvider
    {
        public delegate void NewsHandler(string message);
        public event NewsHandler Notify;

        private List<News> _news;

        public NewsProvider()
        {
            _news = new List<News>();
        }

        public void AddNews (News news)
        {
            _news.Add(news);

            Notify?.Invoke($"{news.Title} was added");
            
        }

    }
}
