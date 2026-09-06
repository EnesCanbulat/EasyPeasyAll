namespace EasyPeasyAll.Models.Entities
{
    public class UserQuitProgress
    {

        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int AddictionId { get; set; }

        public Addiction Addiction { get; set; }

        public DateTime RecoveryDate { get; set; }
        public bool IsActive { get; set; }
    }
}
