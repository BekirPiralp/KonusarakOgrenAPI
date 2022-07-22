namespace Library
{
    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
        public string DataConnection { get; set; }


        private ConnectionStrings()
        {

        }

        private static readonly Lazy<ConnectionStrings> lazy = new Lazy<ConnectionStrings>(()=> new ConnectionStrings());
        
        public static ConnectionStrings get
        {
            get { return lazy.Value; }
        }
    }
}
