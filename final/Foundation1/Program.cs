using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        // video1
        Video vid1 = new Video("Satisfying Therapeutic HORSESHOEING | Farrier", "ss_horseshoeing", 799);
        vid1.Comment("AndrewT", "My goodness the intelligence and trust of this horse is amazing!");
        vid1.Comment("JonF", "I hope there is a part 2. I would like to see how well this worked.");
        vid1.Comment("SophiaW", "I've never actually seen something so intriguing to watch, this was genuinely amazing!");
        _videos.Add(vid1);

        // video2
        Video vid2 = new Video("Horseshoeing 101", "Trevorhirshberg7310", 1377);
        vid2.Comment("LiamH", "it is easy to see just how much you love your job! and it shows in the brilliant work you do.");
        vid2.Comment("HalenD", "I love how understanding and trustworthy the horse is!");
        vid2.Comment("HorseT", "I'm studying to become a farrier. I would love to see more from you!");
        _videos.Add(vid2);

        // video3
        Video vid3 = new Video("Mini donkeys may be the cutest livestock we've ever seen", "King5Seattle", 177);
        vid3.Comment("VictorR", "It is literally incomprehensible how awwwdorable they are.");
        vid3.Comment("HaileyS", "So cute! If I had a donkey, I'd name him Lampwick!");
        vid3.Comment("FredD", "Everyone loves donkeys of all sizes, they are so sweet!");
        _videos.Add(vid3);

        foreach (Video video in _videos)
        {
            video.GetVideo();
        }
    }
}