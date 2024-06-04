namespace Project.Data
{
    public class BlockedUser:BDItem
    {
        private int _id;
        private int _userId;
        private int _adminId;
        private string _reason;
        private DateTime _dateOfBlock;
        private int _term;
        public int Id { get { return _id; } set { _id = value; } }
        public int UserId { get { return _userId; } set { _userId = value; } }
        public int AdminId { get { return _adminId; } set { _adminId = value; } }
        public string Reason { get { return _reason; } set { _reason = value; } }
        public DateTime DateOfBlock { get { return _dateOfBlock; } set { _dateOfBlock = value; } }
        public int Term { get { return _term; } set { _term = value; } }
        
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("UserId",ParametrType.INT),
                new BDItemParametr("AdminId",ParametrType.INT),
                new BDItemParametr("Reason",ParametrType.STRING),
                new BDItemParametr("DateOfBlock",ParametrType.DATE),
                new BDItemParametr("Term",ParametrType.INT)
            };
            return list;
        }
    }
}
