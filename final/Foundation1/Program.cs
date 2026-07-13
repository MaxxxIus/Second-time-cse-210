using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> vidList = new List<Video>();

        List<Comment> comList1 = new List<Comment>();
        Video vid1 = new Video("How fruit loops can make you wiser!!!", "JohnThinks", 615);
        Comment com11 = new Comment("JimmyJeanLover249", "Well, guess I'm sleeping with a box of fruitloops from now on. Sorry Teddie.");
        comList1.Add(com11);
        Comment com12 = new Comment("JillSandwitch843", "You could honestly write a book on this and I think it'd be very useful. Good video.");
        comList1.Add(com12);
        Comment com13 = new Comment("QwertyWarrior12", "I clicked on this thinking it was a joke. now I dont really know what to think.");
        comList1.Add(com13);
        vid1.AddComments(comList1);
        vidList.Add(vid1);

        Video vid2 = new Video("Why you should hate Birds", "WillyPilly", 366);
        List<Comment> comList2 = new List<Comment>();
        Comment com21 = new Comment("Carolish", "pov: A bird crapped on your car and now you need to tell someone about it");
        comList2.Add(com21);
        Comment com22 = new Comment("SnailMaster", "Going to be honest, This just sounds like you woke up on the wrong side of the bed");
        comList2.Add(com22);
        Comment com23 = new Comment("RoyalMuffin78", "Another example of the internets oh so possitive charm");
        comList2.Add(com23);
        Comment com24 = new Comment("BigVodooBagel", "Dude, just go outside and get some sunlight on your skin");
        comList2.Add(com24);
        vid2.AddComments(comList2);
        vidList.Add(vid2);

        Video vid3 = new Video("Just a little video about Mice, nothing more", "SlimJimmy", 433);
        List<Comment> comList3 = new List<Comment>();
        Comment com31 = new Comment("SuperGoober24", "Indeed a video about just mice, nothing else to see here.");
        comList3.Add(com31);
        Comment com32 = new Comment("MrSkillet", "I cant believe this entire video consists of nothing but mice, amazing");
        comList3.Add(com32);
        Comment com33 = new Comment("Ke4p0inT", "Mice are nice.");
        comList3.Add(com33);
        vid3.AddComments(comList3);
        vidList.Add(vid3);

        foreach (Video vid in vidList)
        {
            vid.DisplayInfo();
        }
    }
}