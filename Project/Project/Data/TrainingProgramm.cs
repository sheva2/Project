namespace Project.Data
{
    public class TrainingProgramm : BDItem
    {
        private int _id;
        private string _name;
        private string _description;
        private double _cost;
        private int _hardLevel;
        private int _programmDuration;
        private bool _isVisible;
        private int _coachId;
        private int _logoId;
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public double Cost { get { return _cost; } set { _cost = value; } }
        public int HardLevel { get { return _hardLevel; } set { _hardLevel = value; } }
        public int ProgrammDuration { get { return _programmDuration; } set { _programmDuration = value; } }
        public bool IsVisible { get { return _isVisible; } set { _isVisible = value; } }
        public int CoachId { get { return _coachId; } set { _coachId = value; } }
        public int LogoId { get { return _logoId; } set { _logoId = value; } }
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("Name",ParametrType.STRING),
                new BDItemParametr("Description",ParametrType.STRING),
                new BDItemParametr("Cost",ParametrType.DOUBLE),
                new BDItemParametr("HardLevel",ParametrType.INT),
                new BDItemParametr("ProgrammDuration",ParametrType.INT),
                new BDItemParametr("IsVisible",ParametrType.BOOL),
                new BDItemParametr("CoachId",ParametrType.INT),
                new BDItemParametr("LogoId",ParametrType.INT)
            };
            return list;
        }
    }
}
