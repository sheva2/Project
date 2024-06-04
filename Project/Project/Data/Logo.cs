namespace Project.Data
{
    public class Logo: BDItem
    {
        private int _id;
        private string _link;
        public int Id { get { return _id; } set { _id = value; } }
        public string PhotoLink { get { return _link; } set { _link = value; } }
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("PhotoLink",ParametrType.STRING)
            };
            return list;
        }
    }
}
