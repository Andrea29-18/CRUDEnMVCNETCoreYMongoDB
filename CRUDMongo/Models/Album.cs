using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CRUDMongo.Models
{
    public class Album
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string AlbumName { get; set; }
        public string Artist { get; set; } 
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }

        //Un album puede tener una Lista de Canciones
        // Album es el Maestro y SONG es el detalle
        public List<Song> Songs { get; set; }

        //Prueba
        //public Artist Artist2 { get; set; }
    }
}
