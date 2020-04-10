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
            return $"BIO:\n\t{_artist.Bio}";
        }

        public string getTitle()
        {
            return $"ARTIST:\n\t{_artist.Fullname}";
        }
    }
}