using System;

namespace bai1
{
    class Program
    {
        public static Forum forum = new Forum();
        public static int newID = 0;
        static void Main(string[] args)
        {
            byte choice = 8;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Update Post");
                Console.WriteLine("3. Remove Post");
                Console.WriteLine("4. Show Posts");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Rating");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Create Post: ");
                        CreatePost();
                        break;
                    case 2:
                        Console.WriteLine("Update Post by ID: ");
                        UpdatePost();
                        break;
                    case 3:
                        Console.WriteLine("Remove Post by ID: ");
                        RemovePost();
                        break;
                    case 4:
                        forum.Show();
                        break;
                    case 5:
                        byte choiceSearch;
                        Console.WriteLine("Search");
                        Console.WriteLine("1. Search by Tittle");
                        Console.WriteLine("2, Search by Author");
                        choiceSearch = byte.Parse(Console.ReadLine());
                        switch (choiceSearch)
                        {
                            case 1:
                                Console.WriteLine("Enter Tittle search: ");
                                string title = Console.ReadLine();
                                Console.WriteLine("Result: ");
                                forum.findTitle(title);
                                break;
                            case 2:
                                Console.Write("Enter Author search: ");
                                string author = Console.ReadLine();
                                Console.WriteLine("Result: ");
                                forum.findAuthor(author);
                                break;
                            default:
                                Console.WriteLine("No choice");
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Rating by Id: ");
                        int Id = GetID();
                        int index = forum.findID(Id);
                        if (index == -1)
                        {
                            Console.WriteLine("Invalid Post");
                        }
                        else
                        {
                            Console.WriteLine("Result: ");
                            forum.Posts[index].Display();
                        }
                        break;
                    case 7:
                        Console.WriteLine("No choice");
                        break;
                }
            }
        }

        public static void CreatePost()
        {
            Post post = new Post();
            Console.Write("Title: ");
            post.Title1 = Console.ReadLine();
            Console.Write("Author: ");
            post.Author1 = Console.ReadLine();
            Console.Write("Content: ");
            post.Content1 = Console.ReadLine();
            for (int i = 0; i < post.Rates.Length; i++)
            {
                Console.WriteLine($"Enter VoteRate {i + 1}: ");
                string temp = Console.ReadLine();
                while (!Int32.TryParse(temp, out post.Rates[i]) || (post.Rates[i] < Post.MinRating || post.Rates[i] > Post.MaxRating))
                {
                    Console.Write($"Enter again vote rate {i + 1}:");
                    temp = Console.ReadLine();
                }
            }
            post.Id1 = newID;
            newID++;
            forum.AddPost(post);
        }

        public static int GetID()
        {
            Console.WriteLine("Enter ID:");
            int Id = int.Parse(Console.ReadLine());
            while (Id < 0 )
            {
                Console.WriteLine($"Enter again ID");
                Id = int.Parse(Console.ReadLine());
            }
            return Id;
        }

        public static void UpdatePost()
        {
            int Id = GetID();
            Console.WriteLine("Enter new content: ");
            string newContent = Console.ReadLine();
            forum.Update(Id, newContent);
        }

        public static void RemovePost()
        {
            int Id = GetID();
            forum.Remove(Id);
        }
    }
}
