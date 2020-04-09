namespace Bridge
{
    public class ArtistRessource : IRessource
    {
        public Artist _artist;

        public ArtistRessource(Artist artist)
        {
            _artist = artist;
        }

        public string getImage()
        {
            return _artist.Image;
        }

        public string getSnippet()
        {
            return _artist.Bio;
        }

        public string getTitle()
        {
            return _artist.Fullname;
        }
    }
}