namespace Project.Data
{
    public enum Operator
    {
        AND,
        OR,
        NONE
    }
    public class QueryParametr
    {
        private string str;
        public string Str {get { return str;} set { str = value;} }
        public Operator Operator { get; set; }
        public QueryParametr(string str, Operator @operator)
        {
            this.str = str;
            Operator = @operator;
        }
    }
}
