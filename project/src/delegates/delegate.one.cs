namespace DelegatesExamples
{
    public class LoggerWithDelegate
    {
        private delegate string AppendParam(string _append);

        private string _append(string p)
        {
            return p + " 10.10.2020";
        }
        public string getMessage(string p)
        {
            var append = new AppendParam(_append);
            return append(p);
        }
    }
}