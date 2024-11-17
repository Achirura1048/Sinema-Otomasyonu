using Achi_Sinema.Tables;

namespace Achi_Sinema.Classes
{
    public class ActorMovie
    {
        public int ActorMoviesMovieID { get; set; }

        public int MovieActorsActorID { get; set; }

        public Movie Movie { get; set; }

        public Actor Actor { get; set; }
    }
}