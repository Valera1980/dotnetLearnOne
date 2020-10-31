namespace DelegatesExamples
{
    public class LoggerWithDelegate
    {
        private delegate string AppendParam(string _append);

       
        public string getMessage(string p)
        {
            // var append = new AppendParam(_append); one method
            AppendParam del = _append;         // two method
            return del(p);
        }
         private string _append(string p)
        {
            return p + " 10.10.2020";
        }
    }
}