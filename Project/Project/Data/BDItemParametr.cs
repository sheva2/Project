namespace Project.Data
{
    public enum ParametrType
    {
        INT,
        STRING,
        DATE,
        BOOL,
        DOUBLE

    }
    public class BDItemParametr
    {
        private string parametrName;
        public string ParametrName { get { return parametrName; } set {  parametrName = value; } }
        public ParametrType ParametrType { get; set; }
        public BDItemParametr(string parametrName, ParametrType @paramType) {
            this.ParametrName = parametrName;   
            ParametrType = @paramType;
        }
    }
}
