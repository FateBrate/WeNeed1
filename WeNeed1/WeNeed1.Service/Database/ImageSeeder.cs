namespace WeNeed1.Service.Database
{
    public class ImageSeeder
    {
        private readonly WeNeed1Context _context;

        public ImageSeeder(WeNeed1Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            SeedUserImages();
            SeedSportsCenterImages();
            SeedSportsFieldImages();
            SeedTeamImages();
            _context.SaveChanges();
        }

        private void SeedUserImages()
        {
            var defaultProfilePicture = File.ReadAllBytes("profilePictureSeed.png");

            var usersWithoutImage = _context.Users
                .Where(u => u.ProfilePicture == null)
                .ToList();

            foreach (var user in usersWithoutImage)
            {
                user.ProfilePicture = defaultProfilePicture;
            }
        }

        private void SeedSportsCenterImages()
        {
            var defaultCenterImage = File.ReadAllBytes("sportCenterImageSeed.jpg");

            var centersWithoutImage = _context.SportsCenters
                .Where(c => c.Image == null)
                .ToList();

            foreach (var center in centersWithoutImage)
            {
                center.Image = defaultCenterImage;
            }
        }

        private void SeedSportsFieldImages()
        {
            var defaultFieldImage = File.ReadAllBytes("sportFieldSeedImage.jpg");

            var fieldsWithoutImage = _context.SportsFields
                .Where(f => f.Image == null)
                .ToList();

            foreach (var field in fieldsWithoutImage)
            {
                field.Image = defaultFieldImage;
            }
        }

        private void SeedTeamImages()
        {
            var defaultImage = File.ReadAllBytes("teamPictureSeed.jpg");
            var teamsWithoutImage = _context.Teams.
                Where(t => t.TeamPicture == null)
                .ToList();

            foreach (var team in teamsWithoutImage)
            {
                team.TeamPicture = defaultImage;
            }
        }
    }
}