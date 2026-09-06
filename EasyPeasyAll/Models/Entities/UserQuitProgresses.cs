namespace EasyPeasyAll.Models.Entities
{
    public class UserQuitProgresses
    {

        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int AddictionCategoryId { get; set; }

        public AddictionCategory AddictionCategory { get; set; }

        public DateTime RecoveryDate { get; set; }
        public bool IsActive { get; set; }
    }
}
