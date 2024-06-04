namespace Project.Data
{
    public class Admin: BDItem
    {
        private int _id;
        private int _userId;
        public int Id { get { return _id; } set { _id = value; } }
        public int UserId { get { return _userId; } set { _userId = value; } }
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("UserId",ParametrType.INT)
            };
            return list;
        }
    }
}
