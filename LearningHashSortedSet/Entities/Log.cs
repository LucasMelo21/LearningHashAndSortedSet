namespace LearningHashSortedSet.Entities {
    internal class Log {
        public string Username { get; set; }
        public DateTime Moment { get; set; }

        public Log() { }
        public Log(string csvLog) {
            string[] vect = csvLog.Split(", ");
            Username = vect[0];
            Moment = DateTime.Parse(vect[1]);
        }
        public override int GetHashCode() {
            return Username.GetHashCode();
        }
        public override bool Equals(object? obj) {
            if(!(obj is Log)) {
                return false;
            }
            Log other = obj as Log;
            return Username.Equals(other.Username);
        }

    }
}
