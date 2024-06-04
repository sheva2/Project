namespace Project.Data
{
    public class RatingExercise:BDItem
    {
        private int _id;
        private DateTime _date;
        private int _rating;
        private int _exerciseId;
        private int _userId;
        private string _comment;
        public int Id { get { return _id; } set { _id = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public int Rating { get { return _rating; } set { _rating = value; } }
        public string Comment { get { return _comment; } set { _comment = value; } }
        public int UserId { get { return _userId; } set { _userId = value; } }
        public int ExerciseId { get { return _exerciseId; } set { _exerciseId = value; } }
        
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("Date",ParametrType.DATE),
                new BDItemParametr("Rating",ParametrType.INT),
                new BDItemParametr("Comment",ParametrType.STRING),
                new BDItemParametr("UserId",ParametrType.INT),
                new BDItemParametr("ExerciseId",ParametrType.INT)
                
            };
            return list;
        }
    }
}
