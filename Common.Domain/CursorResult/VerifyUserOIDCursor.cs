namespace Common.Domain.CursorResult
{
    public class VerifyUserOIDCursor
    {
        public VerifyUserOIDCursor(string result, string error)
        {
            this.Result = result;
            this.Error = error;
        }

        public string Result { get; set; }
        public string Error { get; set; }
    }
}
