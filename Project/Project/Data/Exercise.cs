
namespace Project.Data
{
    public class Exercise:BDItem
    {
        private int _id;
        private string _name;
        private string _description;
        private bool _isVisible;
        private DateTime _dateOfLastUpdate;
        private int _videoId;
        private int _coachId;
        public int Id { get { return _id;}set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description=value; } }
        public bool IsVisible { get { return _isVisible; } set { _isVisible = value; } }
        public DateTime DateOfLastUpdate { get { return _dateOfLastUpdate; } set {_dateOfLastUpdate=value ;} }
        public int VideoId { get { return _videoId;} set {_videoId=value;} }
        public int CoachId { get { return _coachId; } set { _coachId=value;} }
        
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("Name",ParametrType.STRING),
                new BDItemParametr("Description",ParametrType.STRING),
                new BDItemParametr("IsVisible",ParametrType.BOOL),
                new BDItemParametr("DateOfLastUpdate",ParametrType.DATE),
                new BDItemParametr("VideoId",ParametrType.INT),
                new BDItemParametr("CoachId",ParametrType.INT)
            };
            return list;
        }
    }
}
