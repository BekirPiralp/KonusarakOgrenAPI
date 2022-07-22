namespace Response
{
    public class ObjectResponse<DataType>
        where DataType : class
    {
        public bool Success { get;}
        public DataType Data { get;}
        public String Message { get; }
        private ObjectResponse(bool success, DataType data, string message)
        {
            if(data == null)
            {
                Success = false;
                Data = null;
                Message = "Nesne gelmedi";
            }else if (data is ICollection<object> list && list.Count<=0)
            {
                Success = false;
                Data = null;
                Message = "Nesneler gelmedi";
            }
            else
            {
                Success = success;
                Data = data;
                Message = message;
            }
        }

        public ObjectResponse(string message):this(false,null,message)
        {
        }

        public ObjectResponse(DataType data):this(true,data,null)
        {
        }
    }
}