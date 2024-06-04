namespace Project.Data
{
    public class TrainingDay : BDItem
    {
        private int _id;
        private int _number;
        private int _trainingWeekId;
        public int Id { get { return _id; } set { _id = value; } }
        public int Number { get { return _number; } set { _number = value; } }
        public int TrainingWeekId { get { return _trainingWeekId; } set { _trainingWeekId = value; } }
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("Number",ParametrType.INT),
                new BDItemParametr("TrainingWeekId",ParametrType.INT)

            };
            return list;
        }
    }
}
