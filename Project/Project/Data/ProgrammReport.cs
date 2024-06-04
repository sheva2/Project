namespace Project.Data
{
    public class ProgrammReport:BDItem
    {
        private int _id;
        private DateTime _date;
        private int _programmId;
        private int _userId;
        private string _reason;
        public int Id { get { return _id; } set { _id = value; } }
        public int UserId { get { return _userId; } set { _userId = value; } }
        public int ProgrammId { get { return _programmId; } set { _programmId = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        
        public string Reason { get { return _reason; } set { _reason = value; } }
        

        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("UserId",ParametrType.INT),
                new BDItemParametr("ProgrammId",ParametrType.INT),
                new BDItemParametr("Date",ParametrType.DATE),
                new BDItemParametr("Reason",ParametrType.STRING)

            };
            return list;
        }
    }
}
