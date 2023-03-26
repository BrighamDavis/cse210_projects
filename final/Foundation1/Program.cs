using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "My First Video";
        video1._creator = "Timmy";
        video1._length = 209;
        
        Comment comments1_1 = new Comment();
            comments1_1._author = "Joe";
            comments1_1._comment = "great video";

        video1.comments.Add(comments1_1);

        Comment comments1_2 = new Comment();
            comments1_2._author = "Greg";
            comments1_2._comment = "Well Produced";

        video1.comments.Add(comments1_2);

        Comment comments1_3 = new Comment();
            comments1_3._author = "Jinny";
            comments1_3._comment = "Looks good!";

        video1.comments.Add(comments1_3);
        video1.Display();





        Video video2 = new Video();
        video2._title = "Crazy Second Video";
        video2._creator = "Jonny";
        video2._length = 114;

        Comment comments2_1 = new Comment();
            comments2_1._author = "Bobby";
            comments2_1._comment = "Awesome Sauce";

        video2.comments.Add(comments2_1);

        Comment comments2_2 = new Comment();
            comments2_2._author = "Scout";
            comments2_2._comment = "Nice Bro";

        video2.comments.Add(comments2_2);

        Comment comments2_3 = new Comment();
            comments2_3._author = "Penney";
            comments2_3._comment = "Sooo Good!";

        video2.comments.Add(comments2_3);
        video2.Display();
        





        Video video3 = new Video();
        video3._title = "Awesome Third Video";
        video3._creator = "Jimmy";
        video3._length = 312;

        Comment comments3_1 = new Comment();
            comments3_1._author = "James";
            comments3_1._comment = "Very Impressive";

        video3.comments.Add(comments3_1);

        Comment comments3_2 = new Comment();
            comments3_2._author = "Lola";
            comments3_2._comment = "Stunning!";

        video3.comments.Add(comments3_2);

        Comment comments3_3 = new Comment();
            comments3_3._author = "Reese";
            comments3_3._comment = "I've Never seen this before!";

        video3.comments.Add(comments3_3);
        video3.Display();

    }
} 
