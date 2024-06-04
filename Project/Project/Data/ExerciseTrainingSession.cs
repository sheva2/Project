using System;

namespace Project.Data
{
    
    public class ExerciseTrainingSession : BDItem
    {
        private int _id;
        private int _exerciseId;
        private int _sessionId;
        private string? _comment;
        public int Id { get { return _id; } set { _id = value; } }
        public int ExerciseId { get { return _exerciseId; } set { _exerciseId = value; } }
        public int SessionId { get { return _sessionId; } set { _sessionId = value; } }
        public string? Comment { get { return _comment; } set { _comment = value; } }
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("ExerciseId",ParametrType.INT),
                new BDItemParametr("SessionId",ParametrType.INT),
                new BDItemParametr("Comment",ParametrType.STRING)
            };
            return list;
        }
    }
}
