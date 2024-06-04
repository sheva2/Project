namespace Project.Data
{
    public class TrainingWeek : BDItem
    {
        private int _id;
        private int _number;
        private int _trainingProgrammId;
        public int Id { get { return _id; } set { _id = value; } }
        public int Number { get { return _number; } set { _number = value; } }
        public int TrainigProgrammId { get { return _trainingProgrammId; } set { _trainingProgrammId = value; } }
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("Number",ParametrType.INT),
                new BDItemParametr("TrainigProgrammId",ParametrType.INT)
                
            };
            return list;
        }
    }
}
