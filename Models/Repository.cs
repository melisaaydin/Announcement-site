namespace Homework.Models
{
    public static class Repository
    {
        private static List<Announcement> announce = new();
        public static IEnumerable<Announcement> Announce => announce;
        static Repository()
        {
            announce.Add(new Announcement()
            {
                Id = 1,
                Title = "Artificial Intelligence Academic Thesis Program Begins",
                Text = "The program aims to increase competencies in the field of artificial intelligence in the defense industry, contribute to the need for qualified human resources in the sector and establish cooperation between academia and industry in the field of artificial intelligence. Students accepted to the program will be announced on October 31. Successful students will benefit from opportunities such as internship, candidate engineering program and project support in line with their competencies.",
                ResponsiblePerson = "Alican",
                AnnouncedAt = DateTime.Now.AddDays(-5).AddHours(-12)
            });
            announce.Add(new Announcement()
            {
                Id = 2,
                Title = "2209-A - University Students Research Projects Support Program Call",
                Text = "2209-A University Students Research Projects Support Program 2024 1st semester call is open for application. Applications can be made via TUBITAK Management Information System (tybs.tubitak.gov.tr) until 17.30 on November 01, 2024.",
                ResponsiblePerson = "Nurcan",
                AnnouncedAt = DateTime.Now.AddDays(-7).AddHours(+1)
            });
            announce.Add(new Announcement()
            {
                Id = 3,
                Title = "4001 National and International Competition/Event Participation Support 2nd Call",
                Text = "The 2nd call for 4001 National and International Competition/Event Participation Support, whose first call period was held between August 2 and September 30, was published on October 1, 2024 and opened for application.",
                ResponsiblePerson = "Gülcan",
                AnnouncedAt = DateTime.Now.AddDays(-7).AddHours(+3)
            });
            announce.Add(new Announcement()
            {
                Id = 3,
                Title = "Adaptation to University Life Program",
                Text = "An orientation program has been organized for our new students to get to know university life and Sakarya University more closely; the topics, programs, people and places to be informed are attached.",
                ResponsiblePerson = "Mehmetcan",
                AnnouncedAt = DateTime.Now.AddDays(-10).AddHours(-4)
            });
        }
        public static List<Announcement> Announcements
        {
            get
            {
                return announce;
            }
        }
        public static void Add(Announcement announcement)
        {
            //for increase Id of adding announcement
            announcement.Id = announce.Max(a => a.Id) + 1;
            announce.Add(announcement);
        }
    }
}