namespace Project.Data
{
    public class QueryCreator
    {
        
        public static string CreateSelect(string TableName)
        {
            return $"Select * from dbo.[{TableName}]"; 
        }
        public static string CreateSelect(string TableName, string OrderString)
        {
            return $"Select * from dbo.[{TableName}] order by [{OrderString}]";
        }
        public static string CreateSelect(string TableName, List<QueryParametr> conditions)
        {
            string queryString = $"Select * from dbo.[{TableName}] where ";
            foreach (QueryParametr param in conditions)
            {
                queryString += param.Str;
                switch (param.Operator)
                {
                    case Operator.AND:
                        queryString += "and";
                        break;
                    case Operator.OR:
                        queryString += "or";
                        break;
                    case Operator.NONE:
                        queryString += " ";
                        break;
                }
            }
            return queryString;
        }
        public static string CreateSelect(string TableName, List<QueryParametr> conditions, string OrderString)
        {
            string queryString = $"Select * from dbo.[{TableName}] where ";
            foreach (QueryParametr param in conditions)
            {
                queryString += param.Str;
                switch (param.Operator)
                {
                    case Operator.AND:
                        queryString += "and";
                        break;
                    case Operator.OR:
                        queryString += "or";
                        break;
                    case Operator.NONE:
                        queryString += " ";
                        break;
                }
            }
            queryString += $"\n order by {OrderString}";
            return queryString;
        }
        public static string CreateInsert(string TableName,BDItem item)
        {
            string queryString = $"Insert Into dbo.[{TableName}] (";
            List<BDItemParametr> parametrs = item.GetParams() ;
            for(int i=1;i<parametrs.Count; i++)
            {
                queryString += "["+ parametrs[i].ParametrName + "],";
            }
            queryString =queryString.Remove(queryString.Length - 1); 
            queryString += ") Values(";
            for (int i = 1; i < parametrs.Count; i++)
            {
                queryString += "@" + parametrs[i].ParametrName + ",";
            }
            queryString =queryString.Remove(queryString.Length - 1);
            queryString += ")";
            return queryString;
        }
        public static string CreateInsert(string TableName, BDItem item,bool key)
        {
            string queryString = $"Insert Into dbo.[{TableName}] (";
            List<BDItemParametr> parametrs = item.GetParams();
            for (int i = 1; i < parametrs.Count; i++)
            {
                queryString +="[" +parametrs[i].ParametrName + "],";
            }
            queryString = queryString.Remove(queryString.Length - 1);
            queryString += ") Values(";
            for (int i = 1; i < parametrs.Count; i++)
            {
                queryString += "@" + parametrs[i].ParametrName + ",";
            }
            queryString = queryString.Remove(queryString.Length - 1);
            queryString += ")  Select @@IDENTITY as [Identity]";
            return queryString;
        }
        public static string CreateUpdate(string TableName, BDItem item)
        {
            string queryString = $"Update dbo.[{TableName}] Set ";
            List<BDItemParametr> parametrs = item.GetParams();
            for (int i = 1; i < parametrs.Count; i++)
            {
                queryString += "["+parametrs[i].ParametrName + $"]=@{parametrs[i].ParametrName},";
            }
            queryString = queryString.Remove(queryString.Length - 1);
            queryString += $" where [{parametrs[0].ParametrName}]=@{parametrs[0].ParametrName}";
            return queryString;
        }
        public static string CreateDelete(string TableName, List<QueryParametr> conditions)
        {
            string queryString = $"Delete from dbo.[{TableName}] where ";
            foreach (QueryParametr param in conditions)
            {
                queryString += param.Str;
                switch (param.Operator)
                {
                    case Operator.AND:
                        queryString += "and";
                        break;
                    case Operator.OR:
                        queryString += "or";
                        break;
                    case Operator.NONE:
                        queryString += " ";
                        break;
                }
            }
            return queryString;
        }
    }
}
