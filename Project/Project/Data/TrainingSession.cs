namespace Project.Data
{
    public class TrainingSession:BDItem
    {
        private int _id;
        private string? _name;
        private int _hardLevel;
        private int _duration;
        
        private int _trainingDayId;
        public int Id { get { return _id; } set { _id = value; } }
        public string? Name { get { return _name; } set { _name = value; } }
        public int HardLevel { get { return _hardLevel; } set { _hardLevel = value; } }
        public int Duration { get { return _duration; } set { _duration = value; } }
        public int TrainingDayId { get { return _trainingDayId; } set { _trainingDayId = value; } }

        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("Name",ParametrType.STRING),
                new BDItemParametr("HardLevel",ParametrType.INT),
                new BDItemParametr("Duration",ParametrType.INT),
                new BDItemParametr("TrainingDayId",ParametrType.INT)
               
            };
            return list;
        }
    }
}
