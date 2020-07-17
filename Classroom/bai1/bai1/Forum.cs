using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    public class Forum
    {
        public SortedList<int, Post> Posts { get; set; }

        public Forum()
        {
            Posts = new SortedList<int, Post>();
        }

        public int findID(int Id)
        {
            for (int i = 0; i < Posts.Count; i++)
            {
                if (Posts[i].Id1 == Id)
                {
                    return i;
                }
            }
            return -1;
        }

        public void findTitle(string Title)
        {
            for (int i = 0; i < Posts.Count; i++)
            {
                if (Posts[i].Title1 == Title)
                {
                    Posts[i].Display();
                }
            }
        }

        public void findAuthor(string Author)
        {
            for (int i = 0; i < Posts.Count; i++)
            {
                if (Posts[i].Author1 == Author)
                {
                    Posts[i].Display();
                }
            }
        }
        
        public void AddPost(Post post)
        {
            Posts.Add(post.Id1, post);
        }

        public void Update(int Id, string New_Content)
        {
            int pos = findID(Id);
            if (pos >= 0)
            {
                Posts[pos].Content1 = New_Content;
            }
            else
            {
                Console.WriteLine("ID not found \"Enter\" to continue...");
                Console.ReadKey();
            }
        }

        public void Remove (int Id)
        {
            if(Posts.Count != 0 )
            {
                Posts.Remove(Id);
            }
            else
            {
                Console.WriteLine("Post emty \"Enter\" to continue");
                Console.ReadKey();
            }
        }

        public void Show()
        {
            if (Posts.Count != 0)
            {
                for(int i = 0; i < Posts.Count; i++)
                {
                    Posts[i].Display();
                }
            }
            else
            {
                Console.WriteLine("Post Emty \"Enter\" to continue");
                Console.ReadKey();
            }
        }
    }
}
