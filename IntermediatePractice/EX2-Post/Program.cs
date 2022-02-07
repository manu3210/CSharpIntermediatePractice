using EX2_Post;

/*Design a class called Post. This class models a StackOverflow post. It should have properties
for title, description and the date/time it was created. We should be able to up-vote or down-vote
a post. We should also be able to see the current vote value. In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value.
In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
and down-voting. You should not give the ability to set the Vote property from the outside,
because otherwise, you may accidentally change the votes of a class to 0 or to a random
number. And this is how we create bugs in our programs. The class should always protect its
state and hide its implementation detail.*/

static void EX2Post()
{
    var post = new Post();
    Console.WriteLine("Creating a new Post!");
    Console.WriteLine("Set a Tittle: ");
    var tittle = Console.ReadLine();

    Console.WriteLine("Set a description: ");
    var description = Console.ReadLine();
    

    if (!string.IsNullOrWhiteSpace(tittle) && !string.IsNullOrWhiteSpace(description))
    {
        post.Tittle = tittle;
        post.Description = description;
    }
    else
    {
        Console.WriteLine("Something went wrong");
    }

    Console.WriteLine("\n------------------------------------------------------------------\n");
    Console.WriteLine("Your post: ");
    Console.WriteLine(post.ToString());

    Console.WriteLine("\n Do you like this post? Y/N");
    var vote = Console.ReadLine();

    if (vote == "y" || vote == "Y")
    {
        post.UpVote();
    }
    else
    {
        post.DownVote();
    }

    Console.WriteLine("\n------------------------------------------------------------------\n");
    Console.WriteLine(post.ToString());
}

