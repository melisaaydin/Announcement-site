using System.ComponentModel.DataAnnotations;

namespace Homework.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required!")]
        public String? Title { get; set; } = String.Empty;
        [Required(ErrorMessage = " Text is required!")]
        public String? Text { get; set; } = String.Empty;
        public String? ResponsiblePerson { get; set; } = String.Empty;
        [Required(ErrorMessage = " Name is required!")]
        public String? Name { get; set; } = String.Empty;
        [Required(ErrorMessage = " Surname is required!")]
        public String? Surname { get; set; } = String.Empty;
        // public String? FullName => $"{CapitalizeFirstLetter(Name)} {Surname?.ToUpper()}";
        public String? FullName => $"{Name} {Surname?.ToUpper()}";
        public string CapitalizeFirstLetter(string name)
        {
            if (string.IsNullOrEmpty(name))
                return name;

            return char.ToUpper(name[0]) + name.Substring(1);
        }
        public DateTime AnnouncedAt { get; set; }

        public Announcement()
        {
            AnnouncedAt = DateTime.Now;
        }
    }
}
