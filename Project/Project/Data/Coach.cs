namespace Project.Data
{
    public class Coach:BDItem
    {
        private int _id;
        private int? _maxPupils;
        private bool _isReady;
        private int _userId;
        public int Id { get { return _id; } set { _id = value; } }
        public int? MaxPupils { get { return _maxPupils; } set { _maxPupils = value; } }
        public bool IsReady { get { return _isReady; } set { _isReady = value; } }
        public int UserId { get { return _userId; } set { _userId = value; } }
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("MaxPupils",ParametrType.INT),
                new BDItemParametr("IsReady",ParametrType.BOOL),
                new BDItemParametr("UserId",ParametrType.INT),
            };
            return list;
        }
    }
}
