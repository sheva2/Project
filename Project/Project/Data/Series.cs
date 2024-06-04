using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Project.Data
{
    public class Series : BDItem
    {
        private int _id;
        private int _num;
        private double? _weight;
        private int _timeOfBreak;
        private int _exerciseSessionId;
        public int Id { get { return _id; } set { _id = value; } }
        public int Num { get { return _num; } set { _num = value; } }
        public double? Weight { get { return _weight; } set { _weight = value; } }
        public int TimeOfBreak { get { return _timeOfBreak; } set { _timeOfBreak = value; } }
        public int ExerciseSessionId { get { return _exerciseSessionId; } set { _exerciseSessionId = value; } }
        
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("Num",ParametrType.INT),
                new BDItemParametr("Weight",ParametrType.DOUBLE),
                new BDItemParametr("TimeOfBreak",ParametrType.DATE),
                new BDItemParametr("ExerciseSessionId",ParametrType.INT),
            };
            return list;
        }
    }
}
