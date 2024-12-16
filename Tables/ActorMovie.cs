namespace Achi_Sinema.Tables
{
    public class ActorMovie
    {
        public int ActorMoviesMovieID { get; set; }

        public int MovieActorsActorID { get; set; }

        public Movie Movie { get; set; }

        public Actor Actor { get; set; }
    }
}